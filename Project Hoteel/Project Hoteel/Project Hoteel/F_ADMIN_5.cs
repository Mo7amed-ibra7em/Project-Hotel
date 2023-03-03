using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_Hoteel.F_LOGIN_SIGNUP_2;

namespace Project_Hoteel
{
    public partial class F_ADMIN_5 : Form
    {
        int Weather = 0, language = 0;
        bool ExpandMenu = true;
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public F_ADMIN_5()
        {
            InitializeComponent();
        }

        private void b_new_reservation_5_Click(object sender, EventArgs e)
        {
            pnl_load_form_5.Controls.Clear();
            F_NEW_RESERVATION_6 f_6 = new F_NEW_RESERVATION_6();
            f_6.TopLevel = false;
            pnl_load_form_5.Controls.Add(f_6);
            f_6.Show();
        }


        private void l_sign_out_5_MouseHover(object sender, EventArgs e)
        {
            l_sign_out_5.ForeColor = Color.SteelBlue;
        }

        private void l_sign_out_5_MouseLeave(object sender, EventArgs e)
        {
            l_sign_out_5.ForeColor = Color.Black;
        }

        private void l_change_password_5_Click(object sender, EventArgs e)
        {
           F_PRIVACY_9 f_9 = new F_PRIVACY_9();
            f_9.ShowDialog();
        }

        private void b_residents_5_Click(object sender, EventArgs e)
        {
            pnl_load_form_5.Controls.Clear();
            F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();
            f_10.TopLevel = false;
            pnl_load_form_5.Controls.Add(f_10);
            f_10.Show();
        }

        private void b_debartures_5_Click(object sender, EventArgs e)
        {
            F_DEBARTURES_11 f_11 = new F_DEBARTURES_11();
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            f_11.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_11);
            f_11.Show();
            f_11.BringToFront();
        }

        private void F_ADMIN_5_Load(object sender, EventArgs e)
        {

            PB_weather_5.Image = Properties.Resources.weather;
            PB_language_5.Image = Properties.Resources.language;

            ///////
            pnl_load_form_5.Controls.Clear();
            F_F_ADMIN_15 f_15 = new F_F_ADMIN_15();
            f_15.TopLevel = false;
            pnl_load_form_5.Controls.Add(f_15);
            f_15.Show();

            ////
        }

        private void b_hanging_reservations_5_Click(object sender, EventArgs e)
        {
            F_HANGING_RESERVATION_13 f_13 = new F_HANGING_RESERVATION_13();
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            f_13.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_13);
            f_13.Show();
            f_13.BringToFront();
        }

        private void l_sign_out_5_Click(object sender, EventArgs e)
        {
            F_LOGIN_SIGNUP_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_SIGNUP_2;
            f_2.Close();
        }


        private void PB_language_5_Click(object sender, EventArgs e)
        {
            if (language != 0)
            {
                PB_language_5.Image = Properties.Resources.language_blue;
                language = 0;
            }
            else
            {
                PB_language_5.Image = Properties.Resources.language;
                language = 1;
            }
        }

        private void PB_weather_5_Click(object sender, EventArgs e)
        {

            if (Weather != 0)
            {
                PB_weather_5.Image = Properties.Resources.weather_blue;
                Weather = 0;
            }
            else
            {
                PB_weather_5.Image = Properties.Resources.weather;
                Weather = 1;
            }
        }

        private void PB_menu_5_Click(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void b_main_5_Click(object sender, EventArgs e)
        {
            pnl_load_form_5.Controls.Clear();
            F_F_ADMIN_15 f_15 = new F_F_ADMIN_15();
            f_15.TopLevel = false;
            pnl_load_form_5.Controls.Add(f_15);
            f_15.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            F_SETTINGS_ADMIN_16 f_16 = new F_SETTINGS_ADMIN_16();
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            f_16.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_16);
            f_16.Show();
            f_16.BringToFront();
            ///
            f_16.pnl_load_form_16.Controls.Clear();
            F_PRIVACY_9 f_9 = new F_PRIVACY_9();
            f_9.TopLevel = false;
            f_16.pnl_load_form_16.Controls.Add(f_9);
            f_9.Show();
            ///
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            f_16.b_privac_16.BackColor = f_1.BackColor;

        }

        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;
        private void F_ADMIN_5_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    NativeMethods.ReleaseCapture();
            //    NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            //}
        }
        //public class NativeMethods
        //{
        //    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //    public static extern IntPtr CreateRoundRectRgn
        //     (
        //      int nLeftRect, // x-coordinate of upper-left corner
        //      int nTopRect, // y-coordinate of upper-left corner
        //      int nRightRect, // x-coordinate of lower-right corner
        //      int nBottomRect, // y-coordinate of lower-right corner
        //      int nWidthEllipse, // height of ellipse
        //      int nHeightEllipse // width of ellipse
        //     );

        //    [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        //    public static extern bool DeleteObject(IntPtr hObject);
        //    [DllImportAttribute("user32.dll")]
        //    public static extern bool ReleaseCapture();

        //    [DllImportAttribute("user32.dll")]
        //    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //}

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            if (ExpandMenu == true)
            {
                PB_list_bg_5.Width -= 5;
                PB_menu_5.BackgroundImage = Properties.Resources.menu;
                if (PB_list_bg_5.Width == PB_list_bg_5.MinimumSize.Width)
                {
                    ExpandMenu = false;
                    timer_menu.Stop();
                }
            }
            else
            {
                PB_list_bg_5.Width += 5;
                PB_menu_5.BackgroundImage = Properties.Resources.menu_blue;
                if (PB_list_bg_5.Width == PB_list_bg_5.MaximumSize.Width)
                {
                    ExpandMenu = true;
                    timer_menu.Stop();
                }
            }
        }

        ////
        ///
    }
}
