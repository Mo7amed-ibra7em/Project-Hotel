using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_PRIVACY_MANAGER_20 : Form
    {
        public F_PRIVACY_MANAGER_20()
        {
            InitializeComponent();
        }

        bool Expand = false;
        private void timer_Password_Tick(object sender, EventArgs e)
        {
            if (Expand == true)
            {
                this.Height -= 5;
                l_changePassword_9.Width -= 5;
                if (this.Height == this.MinimumSize.Height)
                {
                    timer_Password.Stop();
                    Expand = false;
                }
            }
            else
            {
                this.Height += 5;
                l_changePassword_9.Width += 5;
                if (this.Height == this.MaximumSize.Height)
                {
                    timer_Password.Stop();
                    Expand = true;
                }
            }
        }

        private void l_changePassword_9_Click(object sender, EventArgs e)
        {
            timer_Password.Start();
        }

        private void b_close_9_Click(object sender, EventArgs e)
        {
            timer_Password.Start();
        }
    }
}
