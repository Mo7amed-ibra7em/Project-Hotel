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

namespace Project_Hoteel
{
    public partial class F_NEW_RESERVATION_8 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";
        public double price_8_1 = 0, price_8_2 = 0, price_8_3 = 0, price_8_4 = 0, price_room = 0;
        double price_bb_2 = 2,  price_hb_4 = 4,  price_fb_6 = 6,  price_meals = 0;
        string RoomType = "";
        

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
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);

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
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            //if (f_7.radio_panel2_1_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_2_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if(f_7.radio_panel2_3_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if(f_7.radio_panel2_4_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if(f_7.radio_panel3_1_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if(f_7.radio_panel3_2_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if(f_7.radio_panel3_3_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if(f_7.radio_panel3_4_7.Checked)
            //{
            //    price_room = price_8_1 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}

        }


        private void radio_panel1_2_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "مزدوجة";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            //if (f_7.radio_panel2_1_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_2_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_3_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_4_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_1_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_2_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_3_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_4_7.Checked)
            //{
            //    price_room = price_8_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
        }

        private void n_room_8_TextChanged(object sender, EventArgs e)
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
                    if (dread["N_room"].ToString() == n_room_8.Text)
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

            if (ROOMTYPE == "محجوزة")
            {
                n_room_8.ForeColor = Color.Red;
            }
            else
            {
                n_room_8.ForeColor = b_reserve_8.ForeColor;
            }
        }

        private void radio_panel1_3_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "ثلاثية";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            //if (f_7.radio_panel2_1_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_2_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_3_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_4_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_1_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_2_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_3_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_4_7.Checked)
            //{
            //    price_room = price_8_3 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
        }

        private void radio_panel1_4_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            RoomType = "سويت";
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            //if (f_7.radio_panel2_1_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_2_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_3_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel2_4_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_1_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_2_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_3_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
            //else if (f_7.radio_panel3_4_7.Checked)
            //{
            //    price_room = price_8_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            //    t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }


        private void radio_bb_8_CheckedChanged(object sender, EventArgs e)
        {
            //t_meal_type_8.Text = "وجبة الافطار فقط .";
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            price_meals = price_bb_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            t_price_8.Text = "$ " + Convert.ToString(price_meals+price_room);
        }

        private void radio_hb_8_CheckedChanged(object sender, EventArgs e)
        {
            //t_meal_type_8.Text = "وجبتي طعام ( الإفطار والعشاء ) .";
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            price_meals = price_hb_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            t_price_8.Text = "$ " + Convert.ToString(price_meals + price_room);
        }

        private void radio_fb_8_CheckedChanged(object sender, EventArgs e)
        {
            //t_meal_type_8.Text = "ثلاث وجبات .";
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            price_meals = price_fb_6 * Convert.ToDouble(f_7.t_number_all_7.Text);
            t_price_8.Text = "$ " + Convert.ToString(price_meals + price_room);
        }


        private void b_reserve_8_Click(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_6 f_6 = Application.OpenForms["F_NEW_RESERVATION_6"] as F_NEW_RESERVATION_6;
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();

            SqlConnection sqlconn = new SqlConnection();
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
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "INSERT INTO F_RESIDENTS_10(inmates_name, nationality, age, identification_number, telephone_number, wife_name, wife_identity_number, number_of_individuals, room_type, n_room, reservation_date, reservation_expires, Price) VALUES ('" + f_6.t_fore_name_6.Text + " " + f_6.t_last_name_6.Text + "', '" + f_6.t_nationality_6.Text + "', " + f_6.t_age_6.Text + ", " + f_6.t_identification_number_6.Text + "," + f_6.t_telephone_number_6.Text + ", '" + f_7.WifeName + "', '" + f_7.iNumber + "', " + f_7.t_number_of_people_7.Text + ",'" + RoomType + "', " + int.Parse(n_room_8.Text) +", '" + f_6.d_date_of_entry_6.Text + "', '" + f_6.d_exit_date_6.Text + "', " + t_price_8.Text + ");";
                if(n_room_8.ForeColor != Color.Red)
                {
                    sqlcmd.CommandText += "update ROOMS set Room_condition = 'محجوزة' where N_room = "+n_room_8.Text+";";
                }
                sqlconn.Open();
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
