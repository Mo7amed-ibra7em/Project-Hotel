using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Hoteel.Notification
{
    internal class MessageCollection
    {
        public static void showNatification()
        {
            F_NOTIFICATION_22 f_22 = new F_NOTIFICATION_22();
            f_22.Show();
        }
    }
}
