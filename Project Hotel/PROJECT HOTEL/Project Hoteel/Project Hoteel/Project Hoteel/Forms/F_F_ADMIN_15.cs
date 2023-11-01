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

namespace Project_Hoteel
{
    public partial class F_F_ADMIN_15 : Form
    {
        string connstr11 = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hoteel Reservation;Integrated Security = True";
        string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        public F_F_ADMIN_15()
        {
            InitializeComponent();
        }
        private void DeleteRoom()
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    SqlCommand sqlcmd = new SqlCommand("DeleteRoom", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    // تمرير قيمة الرقم الافتراضي للغرفة إلى الإجراء المخزن
                    sqlcmd.Parameters.AddWithValue("@roomNumber", dgv_15.CurrentRow.Cells[0].Value);

                    sqlconn.Open();
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDataRoom()
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    SqlCommand sqlcmd = new SqlCommand("GetRoomData", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlconn.Open();

                    using (SqlDataAdapter sqladap = new SqlDataAdapter(sqlcmd))
                    {
                        DataTable mylist = new DataTable();
                        sqladap.Fill(mylist);
                        dgv_15.DataSource = mylist;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchRoom()
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    SqlCommand sqlcmd = new SqlCommand("SearchRooms", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@searchText", t_search_15.Text);

                    sqlconn.Open();

                    using (SqlDataAdapter sqladap = new SqlDataAdapter(sqlcmd))
                    {
                        DataTable mylist = new DataTable();
                        sqladap.Fill(mylist);
                        dgv_15.DataSource = mylist;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b_add_rooms_15_Click(object sender, EventArgs e)
        {
            F_ROOMS_12 f_12 = new F_ROOMS_12();
            f_12.ShowDialog();
        }
        private void b_delete_rooms_15_Click(object sender, EventArgs e)
        {
            DeleteRoom();
            LoadDataRoom();
        }
        private void F_F_ADMIN_15_Load(object sender, EventArgs e)
        {
            LoadDataRoom();
            if (C_LOGIN_2.Login_emp_accounting == true)
            {
                b_add_room_15.Visible = false;
                b_delete_rooms_15.Visible = false;
            }
        }
        private void b_add_room_15_Click(object sender, EventArgs e)
        {
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
            f__16.but2 = true;
            f__16.timer_liner_16.Start();
            ////
            f__16.b_privac_16.BackColor = f__16.pnl_admin_1.BackColor;
            //
            f_12.timer_room_12.Enabled = true;
        }
        private void t_search_15_TextChanged(object sender, EventArgs e)
        {
            SearchRoom();
        }
        
    }
}
