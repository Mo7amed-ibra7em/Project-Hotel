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

namespace Project_Hoteel
{
    public partial class F_LOGIN_SIGNUP_2 : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";
        //"انشاء متغيرات للبريد وكلمة المرور"
        public string username = "Filed";
        public string password = "Filed";
        public int id_employee;
        public bool Login_emp = false;
        public bool Login_manager = false;
        public string l_user = "";

        ///////
        private int _ticks;
        //
        bool ExpandMenu;
        public F_LOGIN_SIGNUP_2()
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void b_login_2_Click(object sender, EventArgs e)
        {
            t_password_2.PasswordChar = '*';

            if (t_email_2.Text != "Password" && t_email_2.Text != "" && t_password_2.Text != "UserName" && t_password_2.Text != "")
            {
                if(t_email_2.Text != "اسم المستخدم" && t_email_2.Text != "" && t_password_2.Text != "كلمة المرور" && t_password_2.Text != "")
                {
                    SqlConnection sqlconn = new SqlConnection();
                    try
                    {
                        sqlconn.ConnectionString = connstr;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    SqlDataReader dread;
                    try
                    {
                        sqlcmd.CommandText = "select username, password, id_emp, emp_name from SECURITY_LOGIN where username = " + t_email_2.Text + "";
                        sqlconn.Open();
                        dread = sqlcmd.ExecuteReader();
                        while (dread.Read())
                        {
                            username = dread["username"].ToString();
                            password = dread["password"].ToString();
                            id_employee = Convert.ToInt32(dread["id_emp"]);
                            l_user = dread["emp_name"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                }
            }

            if (t_password_2.Text == "Password" && t_email_2.Text == "UserName" || t_email_2.Text == "اسم المستخدم" && t_password_2.Text == "كلمة المرور" || t_password_2.Text == "" && t_email_2.Text == "")
            {
                L_2.Text = "!... ادخل معلوماتك ";
                t_password_2.Text = "";
                t_email_2.Text = "";
            }
            else if (t_password_2.Text != Convert.ToString(password) || t_email_2.Text != username)
            {
                L_2.Text = "!... اسم المستخدم او كلمة المرور خطأ ";
                t_password_2.Text = "";
                t_email_2.Text = "";
            }
            else if (t_email_2.Text == username && t_password_2.Text == Convert.ToString(password))
            {
                l_username_2.Text = "Welcome  " + l_user;
                L_2.Text = "تم تسجيل الدخول بنجاح";
                if (id_employee == 0)
                {
                    Login_emp = true;
                    timer_progress_2.Start();
                }
                else if (id_employee == 1)
                {
                    Login_manager = true;
                    timer_progress_2.Start();
                }
            }
        }


        private void timer_progress_2_Tick(object sender, EventArgs e)
        {
            if (Login_emp == true || Login_manager == true)
            {
                ProgressBar_2.Value += ProgressBar_2.Step;
                l_progress_2.Text = Convert.ToString(ProgressBar_2.Value / 5) + " %";
                if (ProgressBar_2.Value == 500)
                {
                    timer_progress_2.Stop();
                    if (Login_emp == true)
                    {
                        F_ADMIN_5 f_5 = new F_ADMIN_5();
                        f_5.ShowDialog();
                        Login_emp = false;
                        ProgressBar_2.Value = 5;
                        l_progress_2.Text = "1 %";
                    }
                    else if (Login_manager == true)
                    {
                        F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
                        f_1.ShowDialog();
                        Login_manager = false;
                        ProgressBar_2.Value = 5;
                        l_progress_2.Text = "1 %";
                    }
                }
            }
        }

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
        }

        private void t_email_2_TextChanged(object sender, EventArgs e)
        {
            if (t_email_2.Text.Length > 0)
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
            t_email_2.ForeColor = Color.White;
            panel2.BackColor = Color.Plum;
            if (t_email_2.Text == "UserName" || t_email_2.Text == "اسم المستخدم")
            {
                t_email_2.Text = "";
            }
        }

        private void t_email_2_Leave(object sender, EventArgs e)
        {
            t_email_2.ForeColor = b_login_2.ForeColor;
            panel2.BackColor = Color.RoyalBlue;
            if (t_email_2.Text == "")
            {
                if(this.RightToLeft == RightToLeft.Yes)
                {
                    t_email_2.Text = "اسم المستخدم";
                }
                else
                {
                    t_email_2.Text = "UserName";

                }
                t_email_2.ForeColor = Color.LightGray;
            }
        }

        private void t_password_2_Click(object sender, EventArgs e)
        {
            t_password_2.ForeColor = Color.White;
            panel1.BackColor = Color.Plum;
            if (t_password_2.Text == "Password")
            {
                t_password_2.Text = "";
            }
            if (t_password_2.Text == "" || t_password_2.Text != "Password")
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

        //private void b_login_2_MouseHover(object sender, EventArgs e)
        //{
        //    b_login_2.FlatAppearance.BorderColor = Color.Plum;
        //}

        //private void b_login_2_MouseLeave(object sender, EventArgs e)
        //{
        //    b_login_2.FlatAppearance.BorderColor = Color.CornflowerBlue;
        //}

        private void picture_cancel_12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picture_cancel_12_MouseHover(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cancel_2x2;
        }

        private void picture_cancel_12_MouseLeave(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cancel_2x;
        }

        //private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(toggleButton1.Checked == true)
        //    {
        //        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        //        this.Controls.Clear();
        //        InitializeComponent();
        //        this.RightToLeft= RightToLeft.No;
        //        this.RightToLeftLayout = false;
               
        //    }
        //    else
        //    {
        //        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-US");
        //        this.Controls.Clear();
        //        InitializeComponent();
        //        this.RightToLeft = RightToLeft.Yes;
        //        this.RightToLeftLayout = true;
        //    }
        //}

        private void F_LOGIN_SIGNUP_2_Load(object sender, EventArgs e)
        {

        }

        ///////

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
    }

}
