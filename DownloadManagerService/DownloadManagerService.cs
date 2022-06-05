using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;

namespace DownloadManagerService
{
    public partial class DownloadManagerService : ServiceBase
    {
        const string hashesCfg =@"C:\ProgramData\DownloadManager\hashes.cfg";
        const string dirCfg =@"C:\ProgramData\DownloadManager\directory.cfg";
        const string logFile = @"C:\ProgramData\DownloadManager\DownloadManager.log";
        bool allDirs = false;
        List<string> hashes = new List<string>();
        string[] hashesArray;
        List<string> dirs = new List<string>();
        List<DownloadFileSystemWatcher> watchers = new List<DownloadFileSystemWatcher>();
        public DownloadManagerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            File.AppendAllText(logFile, $"[{DateTime.Now}] Service started!{Environment.NewLine}");
            //Read hashes and directories
            if (File.Exists(hashesCfg))
            {
                foreach (string line in File.ReadLines(hashesCfg))
                {
                    hashes.Add(line);
                }
            }
            else
            {
                File.AppendAllText(logFile, $"[{DateTime.Now}] There are no blocked hashes so the service has stopped itself!{Environment.NewLine}");
                Environment.Exit(0);
            }

            hashesArray = hashes.ToArray();

            if (File.Exists(dirCfg))
            {
                foreach (string line in File.ReadLines(dirCfg))
                {
                    dirs.Add(line);
                }
                //Make FileSystemWatchers
                for(int i = 0; i<dirs.Count; i++)
                {
                    DownloadFileSystemWatcher watcher;
                    if (dirs[i] == "All")
                    {
                        DriveInfo[] drives = DriveInfo.GetDrives();
                        foreach (DriveInfo drive in drives)
                        {
                            watcher = new DownloadFileSystemWatcher(drive.Name, hashesArray);
                            watchers.Add(watcher);
                        }
                        allDirs = true;
                        break;
                    }
                    else
                    {
                        watcher = new DownloadFileSystemWatcher(dirs[i], hashesArray);
                        watchers.Add(watcher);
                    }
                }
            }
            else
            {
                File.AppendAllText(logFile, $"[{DateTime.Now}] There is no specified directories to be monitored so the service has stopped itself!{Environment.NewLine}");
                Environment.Exit(0);
            }

            if (allDirs)
            {
                //Raise an event once a USB drive is plugged in
                ManagementEventWatcher usbWatcher = new ManagementEventWatcher();
                WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
                usbWatcher.EventArrived += new EventArrivedEventHandler(UsbPluggedIn);
                usbWatcher.Query = query;
                usbWatcher.Start();
            }
        }

        protected override void OnStop()
        {
            File.AppendAllText(logFile, $"[{DateTime.Now}] Service stopped!{Environment.NewLine}");
        }

        private void UsbPluggedIn(object sender, EventArrivedEventArgs e)
        {
            string driveLetter = e.NewEvent.Properties["DriveName"].Value.ToString();
            DownloadFileSystemWatcher watcher = new DownloadFileSystemWatcher(driveLetter, hashesArray);
            watchers.Add(watcher);
        }
    }
}
