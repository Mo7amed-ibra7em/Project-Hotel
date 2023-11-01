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

namespace Project_Hoteel.Forms
{
    public partial class F_ADD_CUS_23 : Form
    {
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";
        string[] Data;
        public F_ADD_CUS_23(string[] Data)
        {
            InitializeComponent();
            this.Data = Data;
        }
        private void F_ADD_CUS_23_Load(object sender, EventArgs e)
        {
            t_name_23.Text = Data[1];
            t_type_room_23.Text = Data[2];
            t_number_room_23.Text = Data[3];
            t_startDate_23.Text = Data[5];
            t_endDate_23.Text = Data[6];
            t_priceAll_23.Text = Data[8];
        }
        private void picture_cancel_23_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        private void picture_cancel_23_MouseHover(object sender, EventArgs e)
        {
            picture_cancel_23.BackgroundImage = Properties.Resources.cross__1_;
        }
        private void picture_cancel_23_MouseLeave(object sender, EventArgs e)
        {
            picture_cancel_23.BackgroundImage = Properties.Resources.cross__2_;
        }
        private void TestFoundRomm(double Number_Room)
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("SearchRoomNumber", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@roomNumber", Convert.ToInt32(t_number_room_23.Text));
                    sqlcmd.Parameters.Add("@foundRoomNumber", SqlDbType.Float).Direction = ParameterDirection.Output;

                    sqlcmd.ExecuteNonQuery();

                    if (sqlcmd.Parameters["@foundRoomNumber"].Value != DBNull.Value)
                    {
                        Number_Room = Convert.ToDouble(sqlcmd.Parameters["@foundRoomNumber"].Value);
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
        private void AddCusData(double Number_Room , int ID)
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    if (t_number_room_23.ForeColor != Color.Red)
                    {
                        sqlconn.Open();
                        SqlCommand sqlcmd = new SqlCommand();
                        sqlcmd.Connection = sqlconn;
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.CommandText = "AddCuspending";
                        sqlcmd.Parameters.AddWithValue("@id", ID);
                        sqlcmd.Parameters.AddWithValue("@number_room", Convert.ToInt32(t_number_room_23.Text));

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
        private void b_add_cus_23_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Data[0]);
            double Number_Room = 0;
            TestFoundRomm(Number_Room);
            AddCusData(Number_Room,ID);
            
        }
        private void t_number_room_23_TextChanged(object sender, EventArgs e)
        {
            TestFoundRomm(Convert.ToInt32(t_number_room_23.Text));
            TestTypeRoom();
        }
        private void TestTypeRoom()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;

                    // اجراء الحصول على نوع الغرفة بناءً على رقم الغرفة
                    sqlcmd.CommandText = "GetRoomTypeByNumber";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@roomNumber", Convert.ToInt32(t_number_room_23.Text));
                    SqlParameter roomTypeParam = new SqlParameter("@roomType", SqlDbType.NVarChar, -1);
                    roomTypeParam.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(roomTypeParam);

                    sqlcmd.ExecuteNonQuery();

                    string roomType = sqlcmd.Parameters["@roomType"].Value.ToString();

                    if (roomType == "محجوزة")
                    {
                        t_number_room_23.ForeColor = Color.Red;
                    }
                    else
                    {
                        t_number_room_23.ForeColor = Color.White;
                    }
                    t_type_room_23.Text = roomType;
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
    }
}
