using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel.Forms
{
    public partial class F_NOTIF_PASSWORD_24 : Form
    {
        public F_NOTIF_PASSWORD_24()
        {
            InitializeComponent();
        }

        private void F_NOTIF_PASSWORD_24_Load(object sender, EventArgs e)
        {
            t_enter_pass_24.Focus();
        }

        private void timer_notification_24_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void pictor_icon_24_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
