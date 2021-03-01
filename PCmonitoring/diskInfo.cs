using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;

namespace PCmonitoring
{
    class diskInfo
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
}
