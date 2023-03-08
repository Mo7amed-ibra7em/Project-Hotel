using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;

namespace Project_Hoteel.Notification
{


    internal class MessageCollection
    {   
       
        public static void showNatification(string l_notificatio)
        { 
            SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\RWDA TECH\Desktop\Visual S\Project Hoteel\Project Hoteel\Project Hoteel\Sound\Background_Sound.wav");
            _soundPlayer.Play();
            F_NOTIFICATION_22 f_22 = new F_NOTIFICATION_22();
            f_22.Show();
            f_22.label_notification_22.Text = l_notificatio;
        }
    }
}
