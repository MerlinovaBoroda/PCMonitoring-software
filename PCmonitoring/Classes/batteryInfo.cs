using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCmonitoring.Classes
{
    class batteryInfo
    {
        PowerStatus pwr = SystemInformation.PowerStatus;
        int battery = 0;
    }
}
