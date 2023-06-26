using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;
using System.Reflection;
using System.Configuration.Install;

namespace DownloadManager
{
    public partial class MainForm : Form
    {
        public Point mouseLocation;
        const string hashesCfg = @"C:\ProgramData\DownloadManager\hashes.cfg";
        const string dirCfg = @"C:\ProgramData\DownloadManager\directory.cfg";
        const string dirCfgBack = @"C:\ProgramData\DownloadManager\directoryBackup.cfg";
        const string servicePath = @"C:\Program Files\DownloadManagerService\DownloadManagerService.exe";
        const string downloadService = "DownloadManagerService";
        List<string> hashes = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\ProgramData\DownloadManager"))
            {
                Directory.CreateDirectory(@"C:\ProgramData\DownloadManager");
            }
            ReadHashes();
        }
        
        private void ReadHashes()
        {
            if (File.Exists(hashesCfg))
            {
                foreach (string line in File.ReadLines(hashesCfg))
                {
                    hashes.Add(line);
                }
                for (int i = 0; i < hashes.Count; i++)
                {
                    HashesListBox.Items.Add(hashes[i]);
                }
            }
            if (File.Exists(dirCfg))
            {
                string[] dirs = File.ReadAllLines(dirCfg);
                for (int i = 0; i<dirs.Length; i++)
                {
                    if (dirs[i] == "All")
                    {
                        AllDirsCheckbox.Checked = true;
                        DirectoryInputBox.Enabled = false;
                        SaveDirButton.Enabled = false;
                        if (File.Exists(dirCfgBack))
                        {
                            string[] dirsBack = File.ReadAllLines(dirCfgBack);
                            for(int j = 0; j<dirsBack.Length; j++)
                            {
                                if (j == dirsBack.Length - 1)
                                {
                                    DirectoryInputBox.Text += dirsBack[j];
                                }
                                else
                                {
                                    DirectoryInputBox.Text += dirsBack[j] + ", ";
                                }
                            }
                        }
                        break;
                    }
                    else if (i == dirs.Length - 1)
                    {
                        DirectoryInputBox.Text += dirs[i];
                    }
                    else
                    {
                        DirectoryInputBox.Text += dirs[i] + ", ";
                    }
                }
            }
            if (Service.IsServiceInstalled(downloadService))
            {
                InstallServiceButton.Text = "Uninstall Service";
            }
        }

        //code for moving window
        private void mouseDown_dock(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouseMove_dock(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!hashes.Contains(HashInputBox.Text) && HashInputBox.Text != "")
            {
                hashes.Add(HashInputBox.Text);
                File.AppendAllText(hashesCfg, HashInputBox.Text+Environment.NewLine);
                HashesListBox.Items.Add(HashInputBox.Text);
            }else if (HashInputBox.Text == "")
            {
                MessageBox.Show("Please enter a hash!", "Warning");
            }else if (hashes.Contains(HashInputBox.Text))
            {
                MessageBox.Show("Hash already added!", "Warning");
            }
            HashInputBox.Text = "";
            Service.Restart(downloadService);
        }

        private void Enter_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AddButton_Click(sender, e);
            }
        }

        private void ClearAllHashesButton_Click(object sender, EventArgs e)
        {
            File.Delete(hashesCfg);
            HashesListBox.Items.Clear();
            hashes.Clear();
            Service.StopService(downloadService);
        }

        private void RemoveHash_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = HashesListBox.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                string removedItem = selectedItems[i].ToString();
                hashes.Remove(removedItem);
                File.Delete(hashesCfg);
                File.WriteAllLines(hashesCfg, hashes);
                HashesListBox.Items.Remove(selectedItems[i]);
                if (File.ReadAllLines(hashesCfg).Length == 0)
                {
                    File.Delete(hashesCfg);
                    Service.StopService(downloadService);
                    return;
                }
                Service.Restart(downloadService);
            }
        }

        private void SaveDirButton_Click(object sender, EventArgs e)
        {
            if (DirectoryInputBox.Text.Contains(","))
            {
                if (Directory.Exists(DirectoryInputBox.Text))
                {
                    File.WriteAllText(dirCfg, DirectoryInputBox.Text);
                    Service.Restart(downloadService);
                    MessageBox.Show("Directory saved successfully!");
                }
                else
                {
                    List<string> directories = new List<string>();
                    string value = DirectoryInputBox.Text;
                    bool validDirectory = true;
                    while (value.Contains(","))
                    {
                        int index = value.IndexOf(",");
                        string temp = value.Remove(index);
                        directories.Add(temp);
                        value = value.Substring(index);
                        value = value.Remove(0, 1);
                        if (value[0] == ' ')
                        {
                            value = value.Remove(0, 1);
                        }
                    }
                    directories.Add(value);
                    for (int i=0; i<directories.Count; i++)
                    {
                        if (!Directory.Exists(directories[i]))
                        {
                            validDirectory = false;
                        }
                    }
                    if (validDirectory)
                    {
                        File.WriteAllLines(dirCfg, directories);
                        Service.Restart(downloadService);
                        MessageBox.Show("Directories saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("1 or more directories aren't valid!", "Warning");
                    }

                }
            }
            else
            {
                if (Directory.Exists(DirectoryInputBox.Text))
                {
                    File.WriteAllText(dirCfg, DirectoryInputBox.Text);
                    Service.Restart(downloadService);
                    MessageBox.Show("Directory saved successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid directory!", "Warning");
                }
            }
        }

        private void InstallServiceButton_Click(object sender, EventArgs e)
        {
            
            if (InstallServiceButton.Text == "Install Service")
            {
                if (File.Exists("DownloadManagerService.exe"))
                {
                    if (!Directory.Exists(@"C:\Program Files\DownloadManagerService"))
                    {
                        Directory.CreateDirectory(@"C:\Program Files\DownloadManagerService");
                    }
                    File.Move("DownloadManagerService.exe", servicePath);
                    Assembly assembly = Assembly.LoadFrom(servicePath);
                    Service.InstallService(downloadService, assembly);
                    InstallServiceButton.Text = "Uninstall Service";
                    Service.Restart(downloadService);
                    MessageBox.Show("Service installed successfully!");
                }
                else
                {
                    MessageBox.Show("Make sure the DownloadManagerService.exe is in the same directory as Download Manager before installing it!", "Warning");
                }
                
            }
            else
            {
                Assembly assembly = Assembly.LoadFrom(servicePath);
                Service.StopService(downloadService);
                Service.UninstallService(downloadService, assembly);
                File.Move(servicePath, "DownloadManagerService.exe");
                Directory.Delete(@"C:\Program Files\DownloadManagerService", true);
                InstallServiceButton.Text = "Install Service";
                MessageBox.Show("Service uninstalled successfully!");
            }
        }

        private void AllDirsCheckChanged(object sender, EventArgs e)
        {
            if (AllDirsCheckbox.Checked)
            {
                DirectoryInputBox.Enabled = false;
                SaveDirButton.Enabled = false;
                if (File.Exists(dirCfg))
                {
                    File.Copy(dirCfg, dirCfgBack, true);
                }
                File.WriteAllText(dirCfg, "All");
                Service.Restart(downloadService);
                MessageBox.Show("The service is now monitoring all directories!");
            }
            else
            {
                DirectoryInputBox.Enabled = true;
                SaveDirButton.Enabled = true;
                if (File.Exists(dirCfg))
                {
                    File.Delete(dirCfg);
                }
                if (File.Exists(dirCfgBack))
                {
                    File.Copy(dirCfgBack, dirCfg);
                    File.Delete(dirCfgBack);
                    Service.Restart(downloadService);
                }
                else
                {
                    Service.StopService(downloadService);
                }
                MessageBox.Show("The service is no longer monitoring all directories!");
            }
        }
    }

    internal static class Service
    {
        public static void InstallService(string serviceName, Assembly assembly)
        {
            if (IsServiceInstalled(serviceName))
            {
                return;
            }

            using (AssemblyInstaller installer = GetInstaller(assembly))
            {
                IDictionary state = new Hashtable();
                try
                {
                    installer.Install(state);
                    installer.Commit(state);
                }
                catch
                {
                    try
                    {
                        installer.Rollback(state);
                    }
                    catch { }
                    throw;
                }
            }
        }

        public static void UninstallService(string serviceName, Assembly assembly)
        {
            if (IsServiceInstalled(serviceName))
            {
                using (AssemblyInstaller installer = GetInstaller(assembly))
                {
                    IDictionary state = new Hashtable();
                    try
                    {
                        installer.Uninstall(state);
                    }
                    catch
                    {
                        throw;
                    }
                    
                }
            }
        }

        public static bool IsServiceInstalled(string serviceName)
        {
            using (ServiceController controller = new ServiceController(serviceName))
            {
                try
                {
                    ServiceControllerStatus status = controller.Status;
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }

        private static AssemblyInstaller GetInstaller(Assembly assembly)
        {
            AssemblyInstaller installer = new AssemblyInstaller(assembly, null);
            installer.UseNewContext = true;
            return installer;
        }

        public static void Restart(string serviceName)
        {
            if (IsServiceInstalled(serviceName))
            {
                ServiceController service = new ServiceController(serviceName);
                
                TimeSpan timeout = TimeSpan.FromSeconds(5);

                if(service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }

                service.Start();
                try
                {
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                catch { }
                
            }
        }

        public static void StopService(string serviceName)
        {
            if (IsServiceInstalled(serviceName))
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(5));
                }
            }
        }
    }
}