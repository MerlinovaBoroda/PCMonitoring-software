using System;
using System.Diagnostics;
using MonitoringLibrary;

namespace PCmonitoring
{
    public partial class Monitoring : MetroFramework.Forms.MetroForm
    {
        const double MbInGB = 1024;
        static string compName = Environment.MachineName;

        public Monitoring()
        {
            InitializeComponent();
            this.Text = compName + " Monitoring";
        }

        //Form loading Setup
        private void Monitoring_Load(object sender, EventArgs e)
        {
            //Setup the RAM info 
            ramProgressBar.Maximum = RamInfo.TotalRamInMB();
            ramAmountLabel.Text = "Amount of RAM = " + Convert.ToString(Math.Round(RamInfo.TotalRamInMB() / MbInGB, 1)) + "GB";

            //Setup the Computer name for counters 
            cpuCounter.MachineName = compName;
            sysUpTimeCounter.MachineName = compName;

            DiskInfo.CheckDiskC();

            //cpuTemperatureTimer.Start();
        }

        //TODO: Try to change it in normal way
        private void cpucount()
        {
            var cpuval = cpuCounter.NextValue();
            cpuProgressBar.Text = Math.Floor(100 * cpuval / 100).ToString() + "%";
            cpuProgressBar.Value = (int)cpuval;
        }

        //Calculating the free RAM
        private void ramcount()
        {
            ramProgressBar.Text = Convert.ToString(Math.Round(RamInfo.FreeRamInMB() / MbInGB, 1)) + " GB";
            ramProgressBar.Value = RamInfo.FreeRamInMB();
        }

        //Calculating the system uptime
        private void sysuptime()
        {
            var sysval = sysUpTimeCounter.NextValue();
            systemUpTimeLabel.Text = "System Up Time: " + (int)sysval / 60 / 60 + " Hours";
        }

        //Disk info counter
        private void diskcount()
        {
            diskCLabel1.Text = "Drive: " + DiskInfo.diskName;
            diskCLabel2.Text = "Total Disk Space = " + DiskInfo.totalDiskSpaceInGb + " GB";
            diskCLabel3.Text = "Total Free Disk Space = " + DiskInfo.avaliableDiskSpace + " GB";

            diskProgressBar.Maximum = Convert.ToInt32(DiskInfo.totalDiskSpaceInGb);
            diskProgressBar.Text = Convert.ToString(DiskInfo.DiskFreeSpace()) + " GB";
            diskProgressBar.Value = DiskInfo.DiskFreeSpace();
        }

        //timer for all counts
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            cpucount();
            ramcount();
            sysuptime();
            diskcount();
        }

        //timer for CPU Temperature
        private void cpuTemperatureTimer_Tick(object sender, EventArgs e)
        {
            cpuTempLabel.Text = SystemInformation.GetSystemInfo().ToString() + " \u00b0C";
            cpuTempBar.Value = Convert.ToInt32(SystemInformation.GetSystemInfo());
        }
    }
}
