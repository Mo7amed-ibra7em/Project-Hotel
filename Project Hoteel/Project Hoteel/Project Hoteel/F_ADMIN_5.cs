using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            F_NEW_RESERVATION_6 f_6 = new F_NEW_RESERVATION_6();
            f_6.Show();
        }



        private void l_change_password_5_MouseHover_1(object sender, EventArgs e)
        {
            l_change_password_5.ForeColor = Color.SteelBlue;
        }

        private void l_change_password_5_MouseLeave(object sender, EventArgs e)
        {
            l_change_password_5.ForeColor = Color.Black;
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
            F_CHANGE_PASSWORD_9 f_9 = new F_CHANGE_PASSWORD_9();
            f_9.ShowDialog();
        }

        private void b_residents_5_Click(object sender, EventArgs e)
        {
            F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();
            f_10.ShowDialog();
        }

        private void b_debartures_5_Click(object sender, EventArgs e)
        {
            F_DEBARTURES_11 f_11 = new F_DEBARTURES_11();
            f_11.ShowDialog();
        }

        private void F_ADMIN_5_Load(object sender, EventArgs e)
        {
            
            PB_weather_5.Image = Properties.Resources.weather;
            PB_language_5.Image = Properties.Resources.language;

            /////

            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = connstr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select Id as 'الرقم الافتراضي', N_room as 'رقم الغرفة' , T_room as 'نوع الغرفة' , P_room as 'سعر الغرفة' , Room_condition as 'حالة الغرفة' from ROOMS;";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_5.DataSource = mylist;
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

        private void b_hanging_reservations_5_Click(object sender, EventArgs e)
        {
            F_HANGING_RESERVATION_13 f_13 = new F_HANGING_RESERVATION_13();
            f_13.Show();
        }

        private void l_sign_out_5_Click(object sender, EventArgs e)
        {
            F_LOGIN_SIGNUP_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_SIGNUP_2;
            f_2.Close();
        }

        private void b_search_5_Click(object sender, EventArgs e)
        {
            
        }

        private void b_add_rooms_5_Click(object sender, EventArgs e)
        {
            F_ROOMS_12 f_12 = new F_ROOMS_12();
            f_12.ShowDialog();
        }

        private void b_edit_rooms_5_Click(object sender, EventArgs e)
        {
            if (b_edit_rooms_5.BackColor == Color.LightSteelBlue)
            {
                dgv_5.ReadOnly = false;
                b_edit_rooms_5.BackColor = Color.SeaShell;
                b_edit_rooms_5.ForeColor= Color.SteelBlue;
                b_edit_rooms_5.Image = Properties.Resources.edit__2_;
            }
            else if (b_edit_rooms_5.BackColor == Color.SeaShell)
            {
                dgv_5.ReadOnly = true;
                b_edit_rooms_5.BackColor = Color.LightSteelBlue;
                b_edit_rooms_5.ForeColor= Color.Black;
                b_edit_rooms_5.Image = Properties.Resources.edit__3_;



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
                    sqlcmd.CommandText = "update ROOMS set N_room = " + dgv_5.CurrentRow.Cells[1].Value +" , T_room = '" + dgv_5.CurrentRow.Cells[2].Value +"', P_room = " + dgv_5.CurrentRow.Cells[3].Value +" where id = " + dgv_5.CurrentRow.Cells[0].Value +";";
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

                try
                {
                    sqlconn.ConnectionString = connstr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.Connection = sqlconn;
                sqlcmd1.CommandText = "select Id as 'الرقم الافتراضي' , N_room as 'رقم الغرفة' , T_room as 'نوع الغرفة' , P_room as 'سعر الغرفة' , Room_condition 'حالة الغرفة' from ROOMS;";
                SqlDataAdapter sqladap = new SqlDataAdapter();
                sqladap.SelectCommand = sqlcmd1;
                DataTable mylist = new DataTable();
                try
                {
                    sqlconn.Open();
                    sqladap.Fill(mylist);
                    dgv_5.DataSource = mylist;
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

        private void b_delete_rooms_5_Click(object sender, EventArgs e)
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
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "delete from ROOMS where Id = " + dgv_5.CurrentRow.Cells[0].Value +";";
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

            try
            {
                sqlconn.ConnectionString = connstr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select Id as 'الرقم الافتراضي' , N_room as 'رقم الغرفة' , T_room as 'نوع الغرفة' , P_room as 'سعر الغرفة' , Room_condition as 'حالة الغرفة' from ROOMS;";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_5.DataSource = mylist;
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
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gB_list_5_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t_search_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gb_1_5_Enter(object sender, EventArgs e)
        {

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

    }
}
