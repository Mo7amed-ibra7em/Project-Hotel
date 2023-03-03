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
    public partial class F_RESIDENTS_10 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";
        
        public F_RESIDENTS_10()
        {
            InitializeComponent();
        }

        private void F_RESIDENTS_10_Load(object sender, EventArgs e)
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
            sqlcmd1.CommandText = "select id as الرقم, inmates_name as 'اسم الزبون',nationality as الجنسية, age as العمر, identification_number as 'رقم الهوية', telephone_number as 'رقم الهاتف', wife_name as 'اسم الزوجة', wife_identity_number as 'رقم هوية الزوجة', number_of_individuals as 'عدد الافراد', room_type as 'نوع الغرفة', n_room as 'رقم الغرفة', reservation_date as 'تاريخ الحجز', reservation_expires as 'تاريخ المغادرة', Price + '' as الفاتورة from F_RESIDENTS_10;";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_10.DataSource = mylist;
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

        private void b_edit_10_Click(object sender, EventArgs e)
        {


            if (b_edit_10.BackColor == Color.CadetBlue) 
            {
                dgv_10.ReadOnly = false;
                b_edit_10.BackColor = Color.LightGray;
            }
            else if(b_edit_10.BackColor == Color.LightGray)
            {
                dgv_10.ReadOnly = true;
                b_edit_10.BackColor = Color.CadetBlue;
                int ID = Convert.ToInt32(dgv_10.CurrentRow.Cells[0].Value);
                

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
                    sqlcmd.CommandText = "UPDATE F_RESIDENTS_10 SET inmates_name = '" + dgv_10.CurrentRow.Cells[1].Value + "' , nationality = '" + dgv_10.CurrentRow.Cells[2].Value + "' , age = " + dgv_10.CurrentRow.Cells[3].Value + " , identification_number = " + dgv_10.CurrentRow.Cells[4].Value + " , telephone_number = " + dgv_10.CurrentRow.Cells[5].Value + " , wife_name = '" + dgv_10.CurrentRow.Cells[6].Value + "' , wife_identity_number = " + dgv_10.CurrentRow.Cells[7].Value + " , number_of_individuals = " + dgv_10.CurrentRow.Cells[8].Value + " , room_type = '" + dgv_10.CurrentRow.Cells[9].Value + "' , n_room = " + dgv_10.CurrentRow.Cells[10].Value + " , reservation_date = '" + dgv_10.CurrentRow.Cells[11].Value.ToString() + "' , reservation_expires = '" + dgv_10.CurrentRow.Cells[12].Value.ToString() + "' , Price = " + dgv_10.CurrentRow.Cells[13].Value +" where Id = " + ID +"";
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
                sqlcmd1.CommandText = "select id as الرقم, inmates_name as 'اسم الزبون',nationality as الجنسية, age as العمر, identification_number as 'رقم الهوية', telephone_number as 'رقم الهاتف', wife_name as 'اسم الزوجة', wife_identity_number as 'رقم هوية الزوجة', number_of_individuals as 'عدد الافراد', room_type as 'نوع الغرفة', n_room as 'رقم الغرفة',reservation_date as 'تاريخ الحجز', reservation_expires as 'تاريخ المغادرة', Price + '' as الفاتورة from F_RESIDENTS_10;";
                SqlDataAdapter sqladap = new SqlDataAdapter();
                sqladap.SelectCommand = sqlcmd1;
                DataTable mylist = new DataTable();
                try
                {
                    sqlconn.Open();
                    sqladap.Fill(mylist);
                    dgv_10.DataSource = mylist;
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

        private void b_diparting_10_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv_10.CurrentRow.Cells[0].Value);
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
                sqlcmd.CommandText = "INSERT INTO F_DEBARTURES_11 select id, inmates_name, nationality, age, identification_number, telephone_number, wife_name, wife_identity_number, number_of_individuals, room_type, n_room, reservation_date, reservation_expires, Price from F_RESIDENTS_10 where id = " + ID + " delete F_RESIDENTS_10 where id = " + ID + ";";
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
            }
            finally
            {
                sqlconn.Close();
            }


            SqlConnection sqlconn1 = new SqlConnection();
            try
            {
                sqlconn1.ConnectionString = connstr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn1;
            sqlcmd1.CommandText = "select id as الرقم, inmates_name as 'اسم الزبون',nationality as الجنسية, age as العمر, identification_number as 'رقم الهوية', telephone_number as 'رقم الهاتف', wife_name as 'اسم الزوجة', wife_identity_number as 'رقم هوية الزوجة', number_of_individuals as 'عدد الافراد', room_type as 'نوع الغرفة', n_room as 'رقم الغرفة', reservation_date as 'تاريخ الحجز', reservation_expires as 'تاريخ المغادرة', Price + '' as الفاتورة from F_RESIDENTS_10;";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn1.Open();
                sqladap.Fill(mylist);
                dgv_10.DataSource = mylist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn1.Close();
            }
        }

        private void b_cancel_10_Click(object sender, EventArgs e)
        {
            this.Close();
            ///
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            f_5.pnl_load_form_5.Controls.Clear();
            F_F_ADMIN_15 f_15 = Application.OpenForms["F_F_ADMIN_15"] as F_F_ADMIN_15;
            f_15.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_15);
            f_15.Show();
        }
    }
}
