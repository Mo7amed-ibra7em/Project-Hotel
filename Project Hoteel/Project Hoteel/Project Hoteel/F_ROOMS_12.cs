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
    public partial class F_ROOMS_12 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public F_ROOMS_12()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cancel_2x2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cancel_2x;
        }

        private void t_fore_name_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void b_add_room_12_Click(object sender, EventArgs e)
        {
            F_F_ADMIN_15 f_15 = Application.OpenForms["F_F_ADMIN_15"] as F_F_ADMIN_15;

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
                sqlcmd.CommandText = "insert into ROOMS (Room_condition , N_room , T_room , P_room) values ( 'فارغة' ,"+n_room_12.Text+",'"+t_room_12.Text+"',"+p_room_12.Text +")";
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
                f_15.dgv_15.DataSource = mylist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }

            this.Close();
        }
    }
}
