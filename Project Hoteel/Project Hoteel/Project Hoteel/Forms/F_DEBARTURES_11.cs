using Project_Hoteel.Class_Forms.Login_2;
using Project_Hoteel.Forms;
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
    public partial class F_DEBARTURES_11 : Form
    {
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hotel Reservation;Integrated Security = True";
        public string[] array = new string[] { };
        public F_DEBARTURES_11()
        {
            InitializeComponent();
        }

        private void b_cancel_11_Click(object sender, EventArgs e)
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
        private void F_DEBARTURES_11_Load(object sender, EventArgs e)
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
            sqlcmd1.CommandText = "select id as الرقم, inmates_name as 'اسم الزبون',nationality as الجنسية, age as العمر, identification_number as 'رقم الهوية', telephone_number as 'رقم الهاتف', wife_name as 'اسم الزوجة', wife_identity_number as 'رقم هوية الزوجة', number_of_individuals as 'عدد الافراد', room_type as 'نوع الغرفة', n_room as 'رقم الغرفة', reservation_date as 'تاريخ الحجز', reservation_expires as 'تاريخ المغادرة', Price as الفاتورة from F_DEBARTURES_11;";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_11.DataSource = mylist;
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
        private void b_add_11_Click(object sender, EventArgs e)
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
                sqlcmd.CommandText = "select id,inmates_name,nationality,age,identification_number,telephone_number,wife_name,wife_identity_number,number_of_individuals,room_type,n_room ,reservation_date ,reservation_expires,Price from F_DEBARTURES_11 where id = " + dgv_11.CurrentRow.Cells[0].Value +";";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    array = new string[] {dread["inmates_name"].ToString(), dread["room_type"].ToString(), dread["n_room"].ToString(), dread["reservation_date"].ToString(), dread["reservation_expires"].ToString(), dread["Price"].ToString(), dread["id"].ToString()};
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
            F_ADD_CUS_23 f_23 = new F_ADD_CUS_23();
            f_23.ShowDialog();
        }
        private void t_search_11_TextChanged(object sender, EventArgs e)
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
            sqlcmd1.CommandText = "select id as الرقم, inmates_name as 'اسم الزبون',nationality as الجنسية, age as العمر, identification_number as 'رقم الهوية', telephone_number as 'رقم الهاتف', wife_name as 'اسم الزوجة', wife_identity_number as 'رقم هوية الزوجة', number_of_individuals as 'عدد الافراد', room_type as 'نوع الغرفة', n_room as 'رقم الغرفة', reservation_date as 'تاريخ الحجز', reservation_expires as 'تاريخ المغادرة', Price + '' as الفاتورة from  F_DEBARTURES_11 where id like '%" + t_search_11.Text + "%'or inmates_name like '%" + t_search_11.Text + "%'or nationality like '%" + t_search_11.Text + "%'or age like '%" + t_search_11.Text + "%'or identification_number like '%" + t_search_11.Text + "%'or telephone_number like '%" + t_search_11.Text + "%'or wife_name like '%" + t_search_11.Text + "%'or wife_identity_number like '%" + t_search_11.Text + "%'or number_of_individuals like '%" + t_search_11.Text + "%'or room_type like '%" + t_search_11.Text + "%'or n_room like '%" + t_search_11.Text + "%'or reservation_date like '%" + t_search_11.Text + "%'or reservation_expires like '%" + t_search_11.Text + "%' or Price like '%" + t_search_11.Text + "%';";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_11.DataSource = mylist;
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

        private void dgv_11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_search_11_Click(object sender, EventArgs e)
        {

        }
    }
}
