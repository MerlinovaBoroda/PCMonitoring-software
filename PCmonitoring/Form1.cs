using System;
using System.Management;
using System.Diagnostics;
using OpenHardwareMonitor.Hardware;


namespace PCmonitoring
{
    public partial class Monitoring : MetroFramework.Forms.MetroForm
    {
        const double mbInGB = 1024;
        UInt32 SizeinMB;
        float? temperature;

        PerformanceCounter cDiskCounter = new PerformanceCounter("LogicalDisk", "Free Megabytes", "C:", "vs-nb-104");
                
        public Monitoring()
        {
            string compName = System.Environment.GetEnvironmentVariable("COMPUTERNAME");
            InitializeComponent();
            this.Text = compName + " Monitoring";
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        float? GetSystemInfo()
        {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            temperature = computer.Hardware[i].Sensors[j].Value;
                            
                    }
                }
            }
            computer.Close();
            return temperature;
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            diskInfo disk = new diskInfo();
            timer2.Start();
            string Query = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(Query);
            foreach (ManagementObject WniPART in searcher.Get())
            {
                SizeinMB = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value) / 1024;
                ramProgressBar.Maximum = (int)SizeinMB;
                ramAmountLabel.Text = "Amount of RAM = " + SizeinMB.ToString() + " MB";
            }
            
            string compName = System.Environment.GetEnvironmentVariable("COMPUTERNAME");
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
            diskCLabel1.Text = "Drive: " + diskInfo.diskName;
            diskCLabel2.Text = "Total Disk Space = " + diskInfo.totalDiskSpaceInGb + " GB";
            diskCLabel3.Text = "Total Free Disk Space = " + diskInfo.avaliableDiskSpace + " GB";

            
            double diskval = Math.Round(cDiskCounter.NextValue() / mbInGB, 2);
            diskProgressBar.Maximum = Convert.ToInt32(diskInfo.totalDiskSpaceInGb);
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
            cpuTempLabel.Text = GetSystemInfo().ToString() + " \u00b0C";
            cpuTempBar.Value = (int)GetSystemInfo();
        }
    }
}
