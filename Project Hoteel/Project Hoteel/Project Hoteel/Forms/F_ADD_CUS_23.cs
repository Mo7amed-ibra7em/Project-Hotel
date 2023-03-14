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
using static Project_Hoteel.F_LOGIN_2;

namespace Project_Hoteel.Forms
{
    public partial class F_ADD_CUS_23 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public F_ADD_CUS_23()
        {
            InitializeComponent();
        }

        private void F_ADD_CUS_23_Load(object sender, EventArgs e)
        {
            F_DEBARTURES_11 f_11 = Application.OpenForms["F_DEBARTURES_11"] as F_DEBARTURES_11;
            l_customer_name_23.Text = f_11.array[0];
            t_type_room_23.Text = f_11.array[1];
            t_number_room_23.Text = f_11.array[2];
            t_startDate_23.Text = f_11.array[3];
            t_endDate_23.Text = f_11.array[4];
            t_priceAll_23.Text = f_11.array[5];
        }

        private void picture_cancel_23_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        #region كود لجعل الفورم قابل للتحريك
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void F_ADD_CUS_23_MouseDown(object sender, MouseEventArgs e)
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

        private void picture_cancel_23_MouseHover(object sender, EventArgs e)
        {
            picture_cancel_23.BackgroundImage = Properties.Resources.cross__1_;
        }

        private void picture_cancel_23_MouseLeave(object sender, EventArgs e)
        {
            picture_cancel_23.BackgroundImage = Properties.Resources.cross__2_;
        }

        private void b_add_cus_23_Click(object sender, EventArgs e)
        {
            F_DEBARTURES_11 f_11 = Application.OpenForms["F_DEBARTURES_11"] as F_DEBARTURES_11;
            int ID = Convert.ToInt32(f_11.array[6]);
            SqlConnection sqlconn = new SqlConnection();
            double Number_Room = 0;
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
                sqlcmd.CommandText = "select * from ROOMS";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    if (dread["N_room"].ToString() == t_number_room_23.Text)
                    {
                        Number_Room = Convert.ToDouble(dread["N_room"]);
                    }
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
            ////
            if (Number_Room == 0)
            {
                Notification.MessageCollection.showNatification("الغرفة غير موجودة");
            }
            else
            {
                try
                {
                    sqlconn.ConnectionString = connstr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                   
                    if (t_number_room_23.ForeColor != Color.Red)
                    {
                        sqlcmd.Connection = sqlconn;
                        sqlcmd.CommandText = "INSERT INTO F_RESIDENTS_10 select inmates_name, nationality, age, identification_number, telephone_number, wife_name, wife_identity_number, number_of_individuals, room_type = '" + t_type_room_23.Text + "', n_room = " + t_number_room_23.Text + ", reservation_date = '" + t_startDate_23.Text + "', reservation_expires = '" + t_endDate_23.Text + "' , Price = " + t_priceAll_23.Text + "  from  F_DEBARTURES_11 where id = " + ID + " delete from F_DEBARTURES_11 where id = " + ID + "";
                        sqlcmd.CommandText += "update ROOMS set Room_condition = 'محجوزة' where N_room = " + t_number_room_23.Text + ";";
                        sqlconn.Open();
                        sqlcmd.ExecuteNonQuery();
                        Notification.MessageCollection.showNatification("تمت العملية بنجاح");
                        this.Close();
                    }
                    else
                    {
                        Notification.MessageCollection.showNatification("هذه الغرفة محجوزة");
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

        private void t_number_room_23_TextChanged(object sender, EventArgs e)
        {
            string ROOMTYPE = "";
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
                sqlcmd.CommandText = "select * from ROOMS";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    if (dread["N_room"].ToString() == t_number_room_23.Text)
                    {
                        ROOMTYPE = dread["Room_condition"].ToString();
                    }
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
            ///اختبار اذا كانت الغرفة محجوزة
            if (ROOMTYPE == "محجوزة")
            {
                t_number_room_23.ForeColor = Color.Red;
            }
            else
            {
                t_number_room_23.ForeColor = Color.White;
            }
            ////العثور على الغرفة من رقمها الخاص
            try
            {
                sqlconn.ConnectionString = connstr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlcmd.Connection = sqlconn;
            try
            {
                if (t_number_room_23.Text != "")
                {
                    sqlcmd.CommandText = "select T_room from ROOMS where N_room = " + t_number_room_23.Text + ";";
                    sqlconn.Open();
                    dread = sqlcmd.ExecuteReader();
                    while (dread.Read())
                    {
                            t_type_room_23.Text = dread["T_room"].ToString();
                    }
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
}
