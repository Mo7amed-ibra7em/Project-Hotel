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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_Hoteel
{
    public partial class F_CHANGE_PASSWORD_9 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        private int _ticks;
        public F_CHANGE_PASSWORD_9()
        {
            InitializeComponent();
        }

        private void b_change_password_9_Click(object sender, EventArgs e)
        {
            F_LOGIN_SIGNUP_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_SIGNUP_2;


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
                sqlcmd.CommandText = "select password from Security_Login";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    f_2.password = Convert.ToInt32(dread["password"]);
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

            if (t_password_old_9.Text == "" && t_password_new_9.Text == "")
            {
                L_9.Text = "!... إملاأ الحقول";
            }
            if (t_password_old_9.Text == Convert.ToString(f_2.password) && t_password_new_9.Text == "")
            {
                L_9.Text = "!... ادخل كلمة المرور الجديدة";
            }
            if (t_password_old_9.Text == "" && t_password_new_9.Text != "")
            {
                L_9.Text = "!... ادخل كلمة مرورك الحالية ";
            }
            if (t_password_old_9.Text != Convert.ToString(f_2.password) && t_password_old_9.Text != "")
            {
                L_9.Text = "!... كلمة المرور الحالية غير صحيحة";
                t_password_old_9.Text = "";
            }
            if (t_password_old_9.Text == Convert.ToString(f_2.password))
            {
                if (t_password_new_9.Text != "")
                {

                    SqlConnection sqlconn1 = new SqlConnection();
                    try
                    {
                        sqlconn1.ConnectionString = connstr;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        SqlCommand sqlcmd1 = new SqlCommand();
                        sqlcmd1.Connection = sqlconn1;
                        sqlcmd1.CommandText = "update Security_Login set password = '"+t_password_new_9.Text+"'";
                        sqlconn1.Open();
                        sqlcmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlconn1.Close();
                    }

                    L_9.Text = "تم تغيير كلمة المرور بنجاح";
                }
            }
        }

        private void t_password_old_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void t_password_new_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (L_9.Text == "تم تغيير كلمة المرور بنجاح")
            {
                _ticks++;
                if (_ticks == 2)
                {
                    t_password_old_9.Text = "";
                    t_password_new_9.Text = "";
                    L_9.Text = "";
                    timer1.Stop();
                    this.Close();
                }
            }
        }

        private void picture_cancel_12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picture_cancel_12_MouseHover(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cancel_2x2;
        }

        private void picture_cancel_12_MouseLeave(object sender, EventArgs e)
        {
            picture_cancel_12.BackgroundImage = Properties.Resources.cancel_2x;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void t_password_old_9_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_password_new_9_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_old_9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_9_Click(object sender, EventArgs e)
        {

        }

        private void l_new_9_Click(object sender, EventArgs e)
        {

        }
    }
}
