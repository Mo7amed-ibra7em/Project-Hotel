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
    public partial class F_SIGN_UP_4 : Form
    {
        private int _ticks;
       
        public F_SIGN_UP_4()
        {
            InitializeComponent();
        }


        private void t_email_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void t_password_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (L_4.Text == "تم تسجيل حسابك")
            {
                _ticks++;
                if (_ticks == 2)
                {
                    L_4.Text = "يتم الانتقال لصفحة تسجيل الدخول";
                    _ticks++;
                    if (_ticks == 3)
                    {
                        timer4.Stop();
                        F_LOGIN_SIGNUP_2 f_2 = new F_LOGIN_SIGNUP_2();
                        f_2.ShowDialog();

                    }
                }
            }
        }


        private void b_sign_up_4_MouseHover(object sender, EventArgs e)
        {
            b_sign_up_4.ForeColor = Color.Red;
        }

        private void b_sign_up_4_MouseLeave(object sender, EventArgs e)
        {
            b_sign_up_4.ForeColor = Color.DarkRed;
        }

        private void b_back_4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_sign_up_4_Click(object sender, EventArgs e)
        {
            string e_mail2 = ""; double p_assword2 = 0;

            if (t_email_4.Text == "" && t_password_4.Text == "")
            {
                L_4.Text = "ادخل معلوماتك ...!";
            }
            if (t_email_4.Text != "" && t_password_4.Text == "")
            {
                L_4.Text = "ادخل كلمة المرور ...!";
            }
            if (t_email_4.Text == "" && t_password_4.Text != "")
            {
                L_4.Text = "ادخل البريد الالكتروني ...!";
            }

            if (t_email_4.Text != "")
            {
                if (t_password_4.Text != "")
                {
                    e_mail2 = t_email_4.Text;
                    p_assword2 = Convert.ToDouble(t_password_4.Text);
                    t_email_4.Text = "";
                    t_password_4.Text = "";
                    L_4.Text = "تم تسجيل حسابك";
                }
            }
        }

    }
}
