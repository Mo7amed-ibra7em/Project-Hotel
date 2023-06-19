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

namespace Project_Hoteel
{
    public partial class F_NEW_RESERVATION_8 : Form
    {
        #region اتصال مع قاعدة البيانات ومتغيرات
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hoteel Reservation;Integrated Security = True";
        public double price_8_1 = 0, price_8_2 = 0, price_8_3 = 0, price_8_4 = 0, price_room = 0;
        string RoomType = "";
        #endregion
        public F_NEW_RESERVATION_8()
        {
            InitializeComponent();
        }

        private void F_NEW_RESERVATION_8_Load(object sender, EventArgs e)
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
                sqlcmd.CommandText = "select P_room  from ROOMS where T_room = 'مفردة' group by P_room";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    price_8_1 = double.Parse((dread["P_room"]).ToString());
                }

                sqlconn.Close();
                sqlcmd.CommandText = "select P_room  from ROOMS where T_room = 'مزدوجة' group by P_room";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    price_8_2 = double.Parse((dread["P_room"]).ToString());
                }

                sqlconn.Close();
                sqlcmd.CommandText = "select P_room  from ROOMS where T_room = 'ثلاثية' group by P_room";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    price_8_3 = double.Parse((dread["P_room"]).ToString());
                }

                sqlconn.Close();
                sqlcmd.CommandText = "select P_room  from ROOMS where T_room = 'سويت' group by P_room";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    price_8_4 = double.Parse((dread["P_room"]).ToString());
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
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            radio_panel1_1_8.Checked = true;
            if (radio_panel1_1_8.Checked == true)
            {
                RoomType = "مفردة";
                price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room);

            }
            ////
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
                sqlcmd.CommandText = "select T_room,Room_condition,N_room from ROOMS where T_room ='" + RoomType + "' and Room_condition = 'فارغة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    n_room_8.Text = dread["N_room"].ToString();
                }
                if (n_room_8.Text == "")
                {
                    MessageCollection.showNatification("لا يوجد شاغر بالغرف المفردة");
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
        private void b_back_8_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void radio_panel1_1_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "مفردة";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            ////
            string Nroom = "";
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
                sqlcmd.CommandText = "select T_room,Room_condition,N_room from ROOMS where T_room ='"+RoomType+"' and Room_condition = 'فارغة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    n_room_8.Text = dread["N_room"].ToString();
                    Nroom = dread["N_room"].ToString();
                }
                n_room_8.Text = Nroom;
                if (radio_panel1_4_8.Checked == true)
                {
                    if (Nroom == "")
                    {
                        n_room_8.Text = "";
                        MessageCollection.showNatification("لا يوجد شاغر بالغرف المفردة");
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
        private void radio_panel1_2_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "مزدوجة";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            /////
            string Nroom = "";
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
                sqlcmd.CommandText = "select T_room,Room_condition,N_room from ROOMS where T_room ='" + RoomType + "' and Room_condition = 'فارغة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    n_room_8.Text = dread["N_room"].ToString();
                    Nroom = dread["N_room"].ToString();
                }
                n_room_8.Text = Nroom;
                if (radio_panel1_4_8.Checked == true)
                {
                    if (Nroom == "")
                    {
                        n_room_8.Text = "";
                        MessageCollection.showNatification("لا يوجد شاغر بالغرف المزدوجة");
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
        private void radio_panel1_3_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "ثلاثية";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            ////
            string Nroom = "";
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
                sqlcmd.CommandText = "select T_room,Room_condition,N_room from ROOMS where T_room ='" + RoomType + "' and Room_condition = 'فارغة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    n_room_8.Text = dread["N_room"].ToString();
                    Nroom = dread["N_room"].ToString();
                }
                n_room_8.Text = Nroom;
                if (radio_panel1_4_8.Checked == true)
                {
                    if (Nroom == "")
                    {
                        n_room_8.Text = "";
                        MessageCollection.showNatification("لا يوجد شاغر بالغرف الثلاثية");
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
        private void radio_panel1_4_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "سويت";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room);
            }
            /////
            string Nroom = "";
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
                sqlcmd.CommandText = "select T_room,Room_condition,N_room from ROOMS where T_room ='" + RoomType + "' and Room_condition = 'فارغة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    n_room_8.Text = dread["N_room"].ToString();
                    Nroom = dread["N_room"].ToString();
                }
                n_room_8.Text = Nroom;
                if(radio_panel1_4_8.Checked == true)
                {
                    if (Nroom == "")
                    {
                        n_room_8.Text = "";
                        MessageCollection.showNatification("لا يوجد شاغر بالغرف سويت");
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
        private void b_reserve_8_Click(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_6 f_6 = Application.OpenForms["F_NEW_RESERVATION_6"] as F_NEW_RESERVATION_6;
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();
            ////
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
                    if (dread["N_room"].ToString() == n_room_8.Text)
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
                MessageCollection.showNatification("الغرفة غير موجودة");
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
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "INSERT INTO F_RESIDENTS_10(inmates_name, nationality, age, identification_number, telephone_number, wife_name, wife_identity_number, number_of_individuals, room_type, n_room, reservation_date, reservation_expires, Price) VALUES ('" + f_6.t_fore_name_6.Text + " " + f_6.t_last_name_6.Text + "', '" + f_6.t_nationality_6.Text + "', " + f_6.t_age_6.Text + ", " + f_6.t_identification_number_6.Text + "," + f_6.t_telephone_number_6.Text + ", '" + f_7.WifeName + "', '" + f_7.iNumber + "', " + f_7.t_number_of_people_7.Text + ",'" + RoomType + "', " + int.Parse(n_room_8.Text) + ", '" + f_6.d_date_of_entry_6.Text + "', '" + f_6.d_exit_date_6.Text + "', " + t_price_8.Text + ");";
                    if (n_room_8.ForeColor != Color.Red)
                    {
                        sqlcmd.CommandText += "update ROOMS set Room_condition = 'محجوزة' where N_room = " + n_room_8.Text + ";";
                        sqlconn.Open();
                        sqlcmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageCollection.showNatification("هذه الغرفة محجوزة");
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
                if (n_room_8.ForeColor != Color.Red)
                {
                    f_6.Close();
                    ////
                    F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
                    f_10.TopLevel = false;
                    f_5.pnl_load_form_5.Controls.Add(f_10);
                    f_10.Show();
                    f_10.BringToFront();
                }
            }
        }
    }
}
