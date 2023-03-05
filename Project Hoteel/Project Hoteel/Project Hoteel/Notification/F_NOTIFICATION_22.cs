using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel.Notification
{
    public partial class F_NOTIFICATION_22 : KryptonForm
    {
        public F_NOTIFICATION_22()
        {
            InitializeComponent();
        }

        private void timer_notification_22_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void label_notification_22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictor_icon_22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_NOTIFICATION_22_Load(object sender, EventArgs e)
        {
            F_LOGIN_SIGNUP_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_SIGNUP_2;
            label_notification_22.Text = f_2.L_2.Text;
            
        }
    }
}
