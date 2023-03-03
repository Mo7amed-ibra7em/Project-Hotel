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
    public partial class F_LOGIN_SIGNUP_2 : Form
    {
        //"انشاء متغيرات للبريد وكلمة المرور"
        public string email = "Mohamed-ibrahem";
        public int password = 123456789;

        private int _ticks;
       
        public F_LOGIN_SIGNUP_2()
        {
            InitializeComponent();
            
        }

        private void F_LOGIN_LOGUP_2_Load(object sender, EventArgs e)
        {
            timer2.Start();
            //"التحديد على مربع النص بعد تحميل الفورم"
            t_email_2.Select();
        }

        private void b_signup_2_Click_1(object sender, EventArgs e)
        {
            //"الانتقال للفورم 3 بمجرد الضغط على الزر"
            F_USER_3 f_3 = new F_USER_3();
            f_3.ShowDialog();
        }

       

        private void b_login_2_Click(object sender, EventArgs e)
        {
            //"اختبار البريد وكلمة المرور لتسجيل الدخول "

            if (t_email_2.Text == "" && t_password_2.Text == "")
            {
                L_2.Text = "!... ادخل معلوماتك";
            }
            if (t_email_2.Text == email && t_password_2.Text == "")
            {
                L_2.Text = "!... ادخل كلمة المرور";
            }
            if (t_email_2.Text == "" && t_password_2.Text == Convert.ToString(password))
            {
                L_2.Text = "!... ادخل البريد الالكتروني";
            }
            if (t_email_2.Text != email && t_email_2.Text != "")
            {
                L_2.Text = "!... البريد الالكتروني غير موجود";
                t_email_2.Text = "";
            }
            if (t_password_2.Text != Convert.ToString(password) && t_password_2.Text != "")
            {
                L_2.Text = "!... كلمة المرور خطأ";
                t_password_2.Text = "";
            }
            if (t_email_2.Text == email)
            {
                if (t_password_2.Text == Convert.ToString(password))
                {
                    L_2.Text = "تم تسجيل الدخول بنجاح";
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //"عند ادخال معلومات تسجيل الدخول الصحيحة يتم الانظار 3 ثواني والانتقال للفور 5"
            if (L_2.Text == "تم تسجيل الدخول بنجاح")
            {
                _ticks++;
                if (_ticks == 2)
                {
                    t_password_2.Text = "";
                    t_email_2.Text = "";
                    L_2.Text = "";
                    timer2.Stop();
                    F_ADMIN_5 f_5 = new F_ADMIN_5();
                    f_5.ShowDialog();
                    

                }
            }
        }

        private void b_login_2_MouseHover(object sender, EventArgs e)
        {
            b_login_2.ForeColor = Color.Red;
        }

        private void b_login_2_MouseLeave(object sender, EventArgs e)
        {
            b_login_2.ForeColor = Color.DarkRed;
        }

        private void t_password_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
    
}
