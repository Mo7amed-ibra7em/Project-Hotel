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
    public partial class F_F_ADMIN_15 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public bool Expand2 = false;
        public F_F_ADMIN_15()
        {
            InitializeComponent();
        }

        private void b_add_rooms_15_Click(object sender, EventArgs e)
        {
            F_ROOMS_12 f_12 = new F_ROOMS_12();
            f_12.ShowDialog();
        }

        private void b_edit_rooms_15_Click(object sender, EventArgs e)
        {
            if (b_edit_rooms_15.FillColor == b_delete_rooms_15.FillColor)
            {
                dgv_15.ReadOnly = false;
                b_edit_rooms_15.FillColor = Color.LightSteelBlue;
                b_edit_rooms_15.ForeColor = Color.RoyalBlue;
                b_edit_rooms_15.Image = Properties.Resources.edit__2_;
            }
            else if (b_edit_rooms_15.FillColor == Color.LightSteelBlue)
            {
                dgv_15.ReadOnly = true;
                b_edit_rooms_15.FillColor = b_delete_rooms_15.FillColor;
                b_edit_rooms_15.ForeColor = Color.Black;
                b_edit_rooms_15.Image = Properties.Resources.edit__3_;



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
                    sqlcmd.CommandText = "update ROOMS set N_room = " + dgv_15.CurrentRow.Cells[1].Value + " , T_room = '" + dgv_15.CurrentRow.Cells[2].Value + "', P_room = " + dgv_15.CurrentRow.Cells[3].Value + " where id = " + dgv_15.CurrentRow.Cells[0].Value + ";";
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
                    dgv_15.DataSource = mylist;
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

        private void b_delete_rooms_15_Click(object sender, EventArgs e)
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
                sqlcmd.CommandText = "delete from ROOMS where Id = " + dgv_15.CurrentRow.Cells[0].Value + ";";
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
                dgv_15.DataSource = mylist;
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
        private void F_F_ADMIN_15_Load(object sender, EventArgs e)
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
                dgv_15.DataSource = mylist;
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
        private void b_add_room_15_Click(object sender, EventArgs e)
        {
            Expand2 = true;
            /////
            F_SETTINGS_ADMIN_16 f__16 = new F_SETTINGS_ADMIN_16();
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            f__16.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f__16);
            f__16.Show();
            f__16.BringToFront();
            /////
            f__16.pnl_load_form_16.Controls.Clear();
            F_ROOMS_12 f_12 = new F_ROOMS_12();
            f_12.TopLevel = false;
            f__16.pnl_load_form_16.Controls.Add(f_12);
            f_12.Show();
            //////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            f__16.b_rooms_16.BackColor = f_1.BackColor;
            f__16.pnl_line2_16.Visible = true;
            ////
            f__16.b_privac_16.BackColor = f__16.pnl_admin_1.BackColor;
            f__16.pnl_line1_16.Visible = false;
        }

        private void t_search_15_TextChanged(object sender, EventArgs e)
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
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select Id as 'الرقم الافتراضي' , N_room as 'رقم الغرفة' , T_room as 'نوع الغرفة' , P_room as 'سعر الغرفة' , Room_condition 'حالة الغرفة' from ROOMS where id like '%"+t_search_15.Text+"%' or N_room like '%"+t_search_15.Text+"%' or P_room like '%"+t_search_15.Text+"%' or T_room like '%"+t_search_15.Text+"%' or Room_condition like '%"+t_search_15.Text+"%'";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_15.DataSource = mylist;
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
