using Project_Hoteel.Class_Forms.Login_2;
using Project_Hoteel.Notification;
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
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hotel Reservation;Integrated Security = True";

        string room_singular = "",
               room_dualism = "",
               room_trilogy = "",
               room_sweet = "";

        bool Expand = true;
        F_F_ADMIN_15 f_15 = Application.OpenForms["F_F_ADMIN_15"] as F_F_ADMIN_15;

        public F_ROOMS_12()
        {
            InitializeComponent();
        }


        private void b_add_room_12_Click(object sender, EventArgs e)
        {
            F_F_ADMIN_15 f_15 = Application.OpenForms["F_F_ADMIN_15"] as F_F_ADMIN_15;
            if(cbox_type_room_12.Text != "" && t_number_room_12.Text != "" && t_price_room_12.Text != "")
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
                    sqlcmd.CommandText = "insert into ROOMS (Room_condition , N_room , T_room , P_room) values ( 'فارغة' ," + t_number_room_12.Text + ",'" + cbox_type_room_12.SelectedItem.ToString() + "'," + t_price_room_12.Text + ")";
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

                l_notificatio_12.Text = "تم عملية الإضافة بنجاح";
                MessageCollection.showNatification(l_notificatio_12.Text);
                cbox_type_room_12.SelectedIndex = -1;
                t_number_room_12.Text = "";
                t_price_room_12.Text = "";
            }
        }

        private void F_ROOMS_12_Load(object sender, EventArgs e)
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
                sqlcmd.CommandText = "select count(*) from ROOMS";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_count_rooms_12.Text = dread[""].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select count(N_room) from ROOMS where T_room = 'مفردة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_singular_12.Text = dread[""].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select count(N_room) from ROOMS where T_room = 'مزدوجة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_dualism_12.Text = dread[""].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select count(N_room) from ROOMS where T_room = 'ثلاثية'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_trilogy_12.Text = dread[""].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select count(N_room) from ROOMS where T_room = 'سويت'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_sweet_12.Text = dread[""].ToString();
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
            /////Price Room
            
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
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'مفردة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    room_singular = dread["P_room"].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'مزدوجة' group by P_room";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    room_dualism = dread["P_room"].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'ثلاثية'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    room_trilogy = dread["P_room"].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'سويت'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    room_sweet = dread["P_room"].ToString();
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

        private void timer_room_12_Tick(object sender, EventArgs e)
        {
            if (Expand == false)
            {
                this.Height -= 5;
                if (this.Height == this.MinimumSize.Height)
                {
                    timer_room_12.Stop();
                    Expand = true;
                }
            }
            else if(Expand == true)
            {
                this.Height += 5;
                if (this.Height == this.MaximumSize.Height)
                {
                    timer_room_12.Stop();
                    Expand = false;
                }
            }
        }

        private void l_add_rooms_12_Click(object sender, EventArgs e)
        {
            timer_room_12.Start();
            Transition_12.HideSync(l_add_rooms_12);
        }
        private void l_add_rooms_12_MouseHover(object sender, EventArgs e)
        {
            l_add_rooms_12.ForeColor = Color.LightSteelBlue;
        }

        private void l_add_rooms_12_MouseLeave(object sender, EventArgs e)
        {
            F_PRIVACY_9 f_9 = new F_PRIVACY_9();
            l_add_rooms_12.ForeColor = f_9.l_changePassword_9.ForeColor;
        }

        private void b_close_12_Click(object sender, EventArgs e)
        {
            timer_room_12.Start();
            Transition_12.ShowSync(l_add_rooms_12);
        }

        private void cbox_type_room_12_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbox_type_room_12.SelectedIndex == 0)
            {
                t_price_room_12.Text = room_singular.ToString();
            }
            else if (cbox_type_room_12.SelectedIndex == 1)
            {
                t_price_room_12.Text = room_dualism.ToString();
            }
            else if (cbox_type_room_12.SelectedIndex == 2)
            {
                t_price_room_12.Text = room_trilogy.ToString();
            }
            else
            {
                t_price_room_12.Text = room_sweet.ToString();
            }
        }
    }
}
