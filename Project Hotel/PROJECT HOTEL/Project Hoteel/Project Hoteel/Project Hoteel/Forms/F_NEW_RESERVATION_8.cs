using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Project_Hoteel.Class_Forms.Login_2;
using Project_Hoteel.Notification;
using System.Data.SqlTypes;

namespace Project_Hoteel
{
    public partial class F_NEW_RESERVATION_8 : Form
    {
        #region اتصال مع قاعدة البيانات ومتغيرات
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        public double price_8_1 = 0, price_8_2 = 0, price_8_3 = 0, price_8_4 = 0, price_room = 0;
        string RoomType = "";
        string[] Array1;
        string[] Array2;
        #endregion
        public F_NEW_RESERVATION_8(string [] Array1, string [] Array2)
        {
            InitializeComponent();
            this.Array1 = Array1;
            this.Array2 = Array2;
        }
        private void GetPriceRoom()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("GetRoomPrices", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dread = sqlcmd.ExecuteReader())
                    {
                        if (dread.Read())
                        {
                            price_8_4 = Convert.ToDouble(dread["Room1Price"]);
                            price_8_3 = Convert.ToDouble(dread["Room2Price"]);
                            price_8_2 = Convert.ToDouble(dread["Room3Price"]);
                            price_8_1 = Convert.ToDouble(dread["Room4Price"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }   
        private void TestRoomSingle()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "TestRooms";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@RoomType", RoomType);

                    SqlParameter outputParam = new SqlParameter("@Room_Number", SqlDbType.NVarChar, 50);
                    outputParam.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(outputParam);

                    sqlcmd.ExecuteNonQuery();

                    string Test = outputParam.Value.ToString();

                    if (string.IsNullOrEmpty(Test))
                    {
                        MessageCollection.showNatification("لا يوجد شاغر بالغرف المفردة");
                    }
                    else
                    {
                        n_room_8.Text = Test;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TestRoomsDouble()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "TestRooms";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@RoomType", RoomType);

                    SqlParameter outputParam = new SqlParameter("@Room_Number", SqlDbType.NVarChar, 50);
                    outputParam.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(outputParam);

                    sqlcmd.ExecuteNonQuery();

                    string test = outputParam.Value.ToString();

                    if (string.IsNullOrEmpty(test))
                    {
                        if (radio_panel1_2_8.Checked)
                        {
                            n_room_8.Text = "";
                            MessageCollection.showNatification("لا يوجد شاغر بالغرف المزدوجة");
                        }
                    }
                    else
                    {
                        n_room_8.Text = test;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TestRoomsThree()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "TestRooms";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@RoomType", RoomType);

                    SqlParameter outputParam = new SqlParameter("@Room_Number", SqlDbType.NVarChar, 50);
                    outputParam.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(outputParam);

                    sqlcmd.ExecuteNonQuery();

                    string test = outputParam.Value.ToString();

                    if (string.IsNullOrEmpty(test))
                    {
                        if (radio_panel1_3_8.Checked)
                        {
                            n_room_8.Text = "";
                            MessageCollection.showNatification("لا يوجد شاغر بالغرف الثلاثية");
                        }
                    }
                    else
                    {
                        n_room_8.Text = test;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void TestRoomSweet()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "TestRooms";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@RoomType", RoomType);

                    SqlParameter outputParam = new SqlParameter("@Room_Number", SqlDbType.NVarChar, 50);
                    outputParam.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(outputParam);

                    sqlcmd.ExecuteNonQuery();

                    string test = outputParam.Value.ToString();

                    if (radio_panel1_4_8.Checked)
                    {
                        if (string.IsNullOrEmpty(test))
                        {
                            n_room_8.Text = "";
                            MessageCollection.showNatification("لا يوجد شاغر بالغرف سويت");
                        }
                        else
                        {
                            n_room_8.Text = test;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FindRoom()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                string roomNumber = n_room_8.Text;
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("GetRoomNumber", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@roomNumber", roomNumber);

                    SqlDataReader dread = sqlcmd.ExecuteReader();

                    if (dread.Read())
                    {
                        AddCustomer();
                    }
                    else
                    {
                        MessageCollection.showNatification("الغرفة غير موجودة");
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
        private void AddCustomer()
        {
            DateTime startDate = DateTime.Parse(Array1[5]);
            DateTime endDate = DateTime.Parse(Array1[6]);
            int Day = (int)(endDate - startDate).TotalDays;

            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("AddReservation", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@name", Array1[0]);
                    sqlcmd.Parameters.AddWithValue("@nationality", Array1[1]);
                    sqlcmd.Parameters.AddWithValue("@age", Convert.ToInt32(Array1[2]));
                    sqlcmd.Parameters.AddWithValue("@identification_number", Convert.ToInt32(Array1[3]));
                    sqlcmd.Parameters.AddWithValue("@telephone_number", Convert.ToInt32(Array1[4]));
                    sqlcmd.Parameters.AddWithValue("@wife_name", Array2[0]);
                    sqlcmd.Parameters.AddWithValue("@wife_identity_number", Array2[1]);
                    sqlcmd.Parameters.AddWithValue("@number_people", Array2[2]);
                    sqlcmd.Parameters.AddWithValue("@room_type", RoomType);
                    sqlcmd.Parameters.AddWithValue("@number_room", Convert.ToInt32(n_room_8.Text));
                    sqlcmd.Parameters.AddWithValue("@reservation_date", DateTime.Parse(Array1[5]));
                    sqlcmd.Parameters.AddWithValue("@reservation_expires", DateTime.Parse(Array1[6]));
                    sqlcmd.Parameters.AddWithValue("@Price", t_price_8.Text);
                    sqlcmd.Parameters.AddWithValue("@DayNumber", Day);

                    sqlcmd.ExecuteNonQuery();

                    MessageCollection.showNatification("تمت العملية بنجاح");
                    //////
                    F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();
                    F_NEW_RESERVATION_6 f_6 = Application.OpenForms["F_NEW_RESERVATION_6"] as F_NEW_RESERVATION_6;
                    f_6.Close();
                    ////
                    F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
                    f_10.TopLevel = false;
                    f_5.pnl_load_form_5.Controls.Add(f_10);
                    f_10.Show();
                    f_10.BringToFront();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void F_NEW_RESERVATION_8_Load(object sender, EventArgs e)
        {
            GetPriceRoom();
            {
                F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
                radio_panel1_1_8.Checked = true;
                RoomType = "مفردة";
                price_room = price_8_1 * Convert.ToDouble(Array2[3]);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            TestRoomSingle();
        }
        private void b_back_8_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void radio_panel1_1_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "مفردة";
            if (double.Parse(Array2[3]) != 0)
            {
                price_room = price_8_1 * Convert.ToDouble(Array2[3]);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            ////
            if (radio_panel1_1_8.Checked)
            {
                TestRoomSingle();
            }
        }
        private void radio_panel1_2_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "مزدوجة";
            if (double.Parse(Array2[3]) != 0)
            {
                price_room = price_8_2 * Convert.ToDouble(Array2[3]);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            if (radio_panel1_2_8.Checked)
            {
                TestRoomsDouble();
            }
        }
        private void radio_panel1_3_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "ثلاثية";
            if (double.Parse(Array2[3]) != 0)
            {
                price_room = price_8_3 * Convert.ToDouble(Array2[3]);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            if (radio_panel1_3_8.Checked)
            {
                TestRoomsThree();
            }
        }
        private void radio_panel1_4_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "سويت";
            if (double.Parse(Array2[3]) != 0)
            {
                price_room = price_8_4 * Convert.ToDouble(Array2[3]);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            if (radio_panel1_4_8.Checked)
            {
                TestRoomSweet();
            }
        }
        private void b_reserve_8_Click(object sender, EventArgs e)
        {
            FindRoom();
        }
    }
}