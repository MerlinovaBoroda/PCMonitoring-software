using System;
using System.IO;
using OpenHardwareMonitor.Hardware;
using System.Management;

namespace MonitoringLibrary
{

    public class DiskInfo
    {
        public static string diskName;
        public static double totalDiskSpaceInGb;
        public static double avaliableDiskSpace;

        const double BytesInGB = 1073741824;
        const double BytesInMB = 1048576;

        public static void CheckDiskC()
        {

            string cdrive = "C:\\";
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Skip to next loop cycle when drive is not ready
                if (drive.IsReady == true && drive.Name == cdrive)
                {
                    diskName = drive.Name;
                    totalDiskSpaceInGb = Math.Round(drive.TotalSize / BytesInGB, 2);
                    avaliableDiskSpace = Math.Round(drive.TotalFreeSpace / BytesInGB, 2);
                }
            }
        }

        //TODO: пофіксити діск чек по аналогії з оперативкою
        public static int DiskFreeSpace()
        {
            var freeSpace = 0;
            string cdrive = "C:\\";
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Skip to next loop cycle when drive is not ready
                if (drive.IsReady == true && drive.Name == cdrive)
                {
                    freeSpace = Convert.ToInt32(Math.Round(drive.TotalFreeSpace / BytesInMB));
                }
            }
            return freeSpace;
        }
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

    public class SystemInformation
    {
        static float? temperature;

        public static float? GetSystemInfo()
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
    }

    public class RamInfo
    {
        const double KbInMB = 1024;

        public static int TotalRamInMB()
        {
            var total = 0;
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (var result in results)
            {
                total = Convert.ToInt32(Math.Round(Convert.ToDouble(result["TotalVisibleMemorySize"]) / KbInMB));
            }
            return total;
        }

        public static int FreeRamInMB()
        {
            var total = 0;
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (var result in results)
            {
                total = Convert.ToInt32(Math.Round(Convert.ToDouble(result["FreePhysicalMemory"]) / KbInMB));
            }
            return total;
        }
    }

}
