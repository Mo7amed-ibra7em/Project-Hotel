using Project_Hoteel.Class_Forms.Login_2;
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
    public partial class F_CUSTOMIZE_MANAGER_21 : Form
    {
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hoteel Reservation;Integrated Security = True";

        public F_CUSTOMIZE_MANAGER_21()
        {
            InitializeComponent();
        }

        private void F_CUSTOMIZE_MANAGER_21_Load(object sender, EventArgs e)
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
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'مفردة'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_singular_12.Text = dread["P_room"].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'مزدوجة' group by P_room";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_dualism_12.Text = dread["P_room"].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'ثلاثية'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_trilogy_12.Text = dread["P_room"].ToString();
                }
                sqlconn.Close();
                sqlcmd.CommandText = "select P_room from ROOMS where T_room = 'سويت'";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_sweet_12.Text = dread["P_room"].ToString();
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
    }
}
