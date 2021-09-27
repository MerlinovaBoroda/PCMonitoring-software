using System;
using System.IO;
using OpenHardwareMonitor.Hardware;

namespace MonitoringLibrary
{
    public class DiskInfo
    {
        public static string diskName;
        public static double totalDiskSpaceInGb;
        public static double avaliableDiskSpace;

        public void CheckDiskC()
        {
            const double BytesInGB = 1073741824;
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
}
