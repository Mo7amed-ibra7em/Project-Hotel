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

namespace Project_Hoteel
{
    public partial class F_F_ADMIN_15 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

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
            if (b_edit_rooms_15.BackColor == Color.LightSteelBlue)
            {
                dgv_15.ReadOnly = false;
                b_edit_rooms_15.BackColor = Color.SeaShell;
                b_edit_rooms_15.ForeColor = Color.SteelBlue;
                b_edit_rooms_15.Image = Properties.Resources.edit__2_;
            }
            else if (b_edit_rooms_15.BackColor == Color.SeaShell)
            {
                dgv_15.ReadOnly = true;
                b_edit_rooms_15.BackColor = Color.LightSteelBlue;
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
    }
}
