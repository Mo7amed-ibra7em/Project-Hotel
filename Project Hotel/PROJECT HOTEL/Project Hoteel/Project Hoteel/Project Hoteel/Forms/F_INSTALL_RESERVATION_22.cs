using Project_Hoteel.Class_Forms.Login_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_INSTALL_RESERVATION_22 : Form
    {
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";
        string[] InstallData;
        public F_INSTALL_RESERVATION_22(string[] InstallData)
        {
            InitializeComponent();
            this.InstallData = InstallData;
        }

        private void picture_cancel_23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCusAfterPaid()
        {
            int ID =Convert.ToInt32(InstallData[0]);
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("AddCusAfterPaid", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@id", ID);

                    sqlcmd.ExecuteNonQuery();
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

        private void b_install_res_22_Click(object sender, EventArgs e)
        {
            AddCusAfterPaid();
            this.Close();
        }
        private void F_INSTALL_RESERVATION_22_Load(object sender, EventArgs e)
        {
            t_name_22.Text = InstallData[1].ToString();
            t_number_room_22.Text= InstallData[2].ToString();
            t_priceAll_22.Text = InstallData[3].ToString();
        }

        #region كود لجعل الفورم قابل للتحريك
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void F_INSTALL_RESERVATION_22_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
