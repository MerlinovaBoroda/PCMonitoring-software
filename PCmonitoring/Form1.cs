using System;
using System.Management;
using System.Diagnostics;
using MonitoringLibrary;

namespace PCmonitoring
{
    public partial class Monitoring : MetroFramework.Forms.MetroForm
    {
        
        const double mbInGB = 1024;
        UInt32 SizeinMB;
        static string compName = System.Environment.GetEnvironmentVariable("COMPUTERNAME");

        PerformanceCounter cDiskCounter = new PerformanceCounter("LogicalDisk", "Free Megabytes", "C:", compName);

        public Monitoring()
        {
            this.Text = compName + " Monitoring";
            InitializeComponent();
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            DiskInfo disk = new DiskInfo();
            timer2.Start();
            string Query = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(Query);
            foreach (ManagementObject WniPART in searcher.Get())
            {
                SizeinMB = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value) / 1024;
                ramProgressBar.Maximum = (int)SizeinMB;
                ramAmountLabel.Text = "Amount of RAM = " + SizeinMB.ToString() + " MB";
            }
            
            cpuCounter.MachineName = compName;
            memCounter.MachineName = compName;
            sysUpTimeCounter.MachineName = compName;

            disk.CheckDiskC();
        }

        private void cpucount()
        {
            var cpuval = cpuCounter.NextValue();
            cpuProgressBar.Text = Math.Floor(100 * cpuval / 100).ToString() + "%";
            cpuProgressBar.Value = (int)cpuval;
        }

        private void ramcount()
        {
            var ramAvaVal = memCounter.NextValue();
            var ramval = SizeinMB - ramAvaVal;
            ramProgressBar.Text = ramAvaVal + "MB";
            ramProgressBar.Value = (int)ramval;
        }

        private void sysuptime()
        {
            var sysval = sysUpTimeCounter.NextValue();
            systemUpTimeLabel.Text = "System Up Time: " + (int)sysval / 60 / 60 + " Hours";
        }

        private void diskcount()
        {
            diskCLabel1.Text = "Drive: " + DiskInfo.diskName;
            diskCLabel2.Text = "Total Disk Space = " + DiskInfo.totalDiskSpaceInGb + " GB";
            diskCLabel3.Text = "Total Free Disk Space = " + DiskInfo.avaliableDiskSpace + " GB";

            
            double diskval = Math.Round(cDiskCounter.NextValue() / mbInGB, 2);
            diskProgressBar.Maximum = Convert.ToInt32(DiskInfo.totalDiskSpaceInGb);
            diskProgressBar.Text = diskval.ToString() + " GB";
            diskProgressBar.Value = diskProgressBar.Maximum - (int)diskval;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpucount();
            ramcount();
            sysuptime();
            diskcount();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cpuTempLabel.Text = SystemInformation.GetSystemInfo().ToString() + " \u00b0C";
            cpuTempBar.Value = Convert.ToInt32(SystemInformation.GetSystemInfo());
        }
    }
}
