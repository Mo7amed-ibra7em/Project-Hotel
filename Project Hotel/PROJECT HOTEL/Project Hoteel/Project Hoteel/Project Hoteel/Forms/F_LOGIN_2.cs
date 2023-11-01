using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Runtime.InteropServices;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using Project_Hoteel.Notification;
using Project_Hoteel.Class_Forms.Login_2;

namespace Project_Hoteel
{
    public partial class F_LOGIN_2 : KryptonForm
    {
        public F_LOGIN_2()
        {
            InitializeComponent();
        }
        private void b_login_2_Click(object sender, EventArgs e)
        {
            C_LOGIN_2.ButtonLogin();
        }
        private void timer_progress_2_Tick(object sender, EventArgs e)
        {
            C_LOGIN_2.TimerLogin();

           
        }
        

        #region//// الستايل ////
        private void t_password_2_TextChanged(object sender, EventArgs e)
        {
            if (t_password_2.Text.Length > 0)
            {
                if (panel1.BackColor == Color.RoyalBlue)
                {
                    panel1.BackColor = Color.Plum;
                }
                else if (panel1.BackColor == Color.Plum)
                {
                    panel1.BackColor = Color.RoyalBlue;
                }
            }
            if (t_password_2.Text != "Password" || t_password_2.Text != "كلمة المرور")
            {
                t_password_2.PasswordChar = '*';
            }
            if (t_password_2.Text == "Password" || t_password_2.Text == "كلمة المرور")
            {
                t_password_2.PasswordChar = char.MinValue;
            }
        }
        private void t_email_2_TextChanged(object sender, EventArgs e)
        {
            if (t_username_2.Text.Length > 0)
            {
                if (panel2.BackColor == Color.RoyalBlue)
                {
                    panel2.BackColor = Color.Plum;
                }
                else if (panel2.BackColor == Color.Plum)
                {
                    panel2.BackColor = Color.RoyalBlue;
                }
            }
        }
        private void t_email_2_Click(object sender, EventArgs e)
        {
            t_username_2.ForeColor = Color.White;
            panel2.BackColor = Color.Plum;
            if (t_username_2.Text == "UserName" || t_username_2.Text == "اسم المستخدم")
            {
                t_username_2.Text = "";
            }
        }

        private void t_email_2_Leave(object sender, EventArgs e)
        {
            t_username_2.ForeColor = b_login_2.ForeColor;
            panel2.BackColor = Color.RoyalBlue;
            if (t_username_2.Text == "")
            {
                if(this.RightToLeft == RightToLeft.Yes)
                {
                    t_username_2.Text = "اسم المستخدم";
                }
                else
                {
                    t_username_2.Text = "UserName";

                }
                t_username_2.ForeColor = Color.LightGray;
            }
        }
        private void t_password_2_Click(object sender, EventArgs e)
        {
            t_password_2.ForeColor = Color.White;
            panel1.BackColor = Color.Plum;
            if (t_password_2.Text == "Password" || t_password_2.Text == "كلمة المرور")
            {
                t_password_2.Text = "";
            }
            if (t_password_2.Text != "Password" || t_password_2.Text != "كلمة المرور")
            {
                t_password_2.PasswordChar = '*';
            }
        }
        private void t_password_2_Leave(object sender, EventArgs e)
        {
            t_password_2.ForeColor = b_login_2.ForeColor;
            panel1.BackColor = Color.RoyalBlue;
            if (t_password_2.Text == "")
            {
                if(this.RightToLeft == RightToLeft.Yes)
                {
                    t_password_2.Text = "كلمة المرور";
                }
                else
                {
                    t_password_2.Text = "Password";
                }
                t_password_2.ForeColor = Color.LightGray;
                t_password_2.PasswordChar = char.MinValue;
            }
        }
        private void picture_cancel_12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picture_cancel_12_MouseHover(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cross__1_;
        }
        private void picture_cancel_12_MouseLeave(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cross__2_;
        }
        private void l_forget_password_2_MouseHover(object sender, EventArgs e)
        {
            l_forget_password_2.ForeColor = Color.White;
        }
        private void l_forget_password_2_MouseLeave(object sender, EventArgs e)
        {
            l_forget_password_2.ForeColor = Color.CornflowerBlue;
        }
        #endregion

        #region    ////// كود لجعل الفورم قابل للتحريك  /////
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void F_LOGIN_SIGNUP_2_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        public class NativeMethods
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn
             (
              int nLeftRect, // x-coordinate of upper-left corner
              int nTopRect, // y-coordinate of upper-left corner
              int nRightRect, // x-coordinate of lower-right corner
              int nBottomRect, // y-coordinate of lower-right corner
              int nWidthEllipse, // height of ellipse
              int nHeightEllipse // width of ellipse
             );

            [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
            public static extern bool DeleteObject(IntPtr hObject);
            [DllImportAttribute("user32.dll")]
            public static extern bool ReleaseCapture();

            [DllImportAttribute("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        }
        #endregion

    }
}
