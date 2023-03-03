using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_Hoteel
{
    public partial class F_CHANGE_PASSWORD_9 : Form
    {
        private int _ticks;
        public F_CHANGE_PASSWORD_9()
        {
            InitializeComponent();
        }

        private void b_change_password_9_Click(object sender, EventArgs e)
        {
            F_LOGIN_SIGNUP_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_SIGNUP_2;

            if (t_password_old_9.Text == "" && t_password_new_9.Text == "")
            {
                L_9.Text = "!... إملاأ الحقول";
            }
            if (t_password_old_9.Text == Convert.ToString(f_2.password) && t_password_new_9.Text == "")
            {
                L_9.Text = "!... ادخل كلمة المرور الجديدة";
            }
            if (t_password_old_9.Text == "" && t_password_new_9.Text != "")
            {
                L_9.Text = "!... ادخل كلمة مرورك الحالية ";
            }
            if (t_password_old_9.Text != Convert.ToString(f_2.password) && t_password_old_9.Text != "")
            {
                L_9.Text = "!... كلمة المرور الحالية غير صحيحة";
                t_password_old_9.Text = "";
            }
            if (t_password_old_9.Text == Convert.ToString(f_2.password))
            {
                if (t_password_new_9.Text != "")
                {
                    f_2.password = Convert.ToInt32(t_password_new_9.Text);
                    L_9.Text = "تم تغيير كلمة المرور بنجاح";
                }
            }
        }

        private void t_password_old_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void t_password_new_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (L_9.Text == "تم تغيير كلمة المرور بنجاح")
            {
                _ticks++;
                if (_ticks == 2)
                {
                    t_password_old_9.Text = "";
                    t_password_new_9.Text = "";
                    L_9.Text = "";
                    timer1.Stop();
                    this.Close();
                }
            }
        }

    }
}
