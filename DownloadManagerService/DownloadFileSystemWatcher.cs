using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace DownloadManagerService
{
    internal class DownloadFileSystemWatcher : FileSystemWatcher
    {
        string[] fileHashes;
        const string logFile = @"C:\ProgramData\DownloadManager\DownloadManager.log";
        public DownloadFileSystemWatcher(string path, string[] hashes) : base(path)
        {
            fileHashes = hashes;

            NotifyFilter = NotifyFilters.LastWrite |
                                   NotifyFilters.FileName;

            Changed += OnCreated;
            Created += OnCreated;
            Renamed += OnCreated;

            Filter = "";
            IncludeSubdirectories = true;
            EnableRaisingEvents = true;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                string hash = Checksums.SHA256CheckSum(e.FullPath);
                if (Checksums.ExceptionDetected)
                {
                    File.AppendAllText(logFile, $"[{DateTime.Now}] {hash} If this is not causing any issues with the functionality of the program you can ignore it!{Environment.NewLine}");
                }
                else
                {
                    for (int i = 0; i < fileHashes.Length; i++)
                    {
                        if (hash == fileHashes[i])
                        {
                            File.Delete(e.FullPath);
                            File.AppendAllText(logFile, $"[{DateTime.Now}] Deleted: {e.FullPath} ({hash}){Environment.NewLine}");
                        }
                    }
                }
            }
        }
    }
    internal static class Checksums
    {
        static bool exceptionDetected;
        public static string SHA256CheckSum(string filePath)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                try
                {
                    FileStream fileStream = File.OpenRead(filePath);
                    using (fileStream)
                    {
                        exceptionDetected = false;
                        return BitConverter.ToString(SHA256.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
                    }
                }catch (Exception e)
                {
                    exceptionDetected = true;
                    return e.Message;
                }
                
            }
        }
        public static bool ExceptionDetected
        {
            get { return exceptionDetected; }
        }
    }
}
