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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_Hoteel
{
    public partial class F_PRIVACY_9 : Form
    {        
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";
        Class_Forms.Login_2.C_LOGIN_2 c_2 = new Class_Forms.Login_2.C_LOGIN_2();

        bool Pass = false;
        private int _ticks;
        public F_PRIVACY_9()
        {
            InitializeComponent();
        }

        private void b_change_password_9_Click(object sender, EventArgs e)
        {
            F_LOGIN_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_2;


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
                    Class_Forms.Login_2.C_LOGIN_2.password = Convert.ToString(dread["password"]);
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

            if (t_password_old_9.Text == "" && t_password_new_2_9.Text == "" && t_password_new_9.Text == "")
            {
                l_notificatio_9.Text = "!... ادخل معلوماتك";
            }
            else if (t_password_old_9.Text == Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_9.Text == "" &&t_password_new_2_9.Text == "")
            {
                l_notificatio_9.Text = "!... ادخل كلمة المرور الجديدة";
            }
            else if (t_password_old_9.Text == "" && t_password_new_9.Text != "" && t_password_new_2_9.Text != "")
            {
                l_notificatio_9.Text = "!... ادخل كلمة مرورك الحالية ";
            }
            else if(t_password_old_9.Text != "" && t_password_new_9.Text == "" )
            {
                l_notificatio_9.Text = "!... ادخل كلمة المرور الجديدة ";
            }
            else if(t_password_old_9.Text != Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_9.Text != "" && t_password_new_2_9.Text != "")
            {
                l_notificatio_9.Text = "!... كلمة مرورك خطأ ";
            }
            else if (t_password_old_9.Text == Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_9.Text != "" && t_password_new_2_9.Text == "" || t_password_old_9.Text != Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_9.Text != "" && t_password_new_2_9.Text == "")
            {
                l_notificatio_9.Text = "!... أعد كتابة كلمة المرور ";
            }
            else if(t_password_new_9.Text != t_password_new_2_9.Text && t_password_old_9.Text != "" && t_password_new_9.Text != "" && t_password_new_2_9.Text != "")
            {
                l_notificatio_9.Text = "!... كلمة المرور غير متطابقة";
                t_password_new_9.Text = "";
                t_password_new_2_9.Text = "";
            }
            else if (t_password_old_9.Text == Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_9.Text == t_password_new_2_9.Text && t_password_new_9.Text != "")
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
                    sqlcmd1.CommandText = "update Security_Login set password = '" + t_password_new_2_9.Text + "' where password = '" + t_password_old_9.Text + "'";
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

                l_notificatio_9.Text = "تم تغيير كلمة المرور بنجاح";
                Pass = true;
                _ticks = 0;
                timer_Close.Start();

            }
            MessageCollection.showNatification(l_notificatio_9.Text);
        }

        private void t_password_old_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void t_password_new_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void timer_Close_Tick(object sender, EventArgs e)
        {
            if (Pass == true)
            {
                _ticks++;
                if (_ticks == 1)
                {
                    t_password_old_9.Text = "";
                    t_password_new_2_9.Text = "";
                    t_password_new_9.Text = "";
                    l_notificatio_9.Text = "";
                    timer_Close.Stop();
                    timer_Password.Start();
                }
            }
        }

        private void l_changePassword_9_Click(object sender, EventArgs e)
        {
            timer_Password.Start();
            Transition_9.HideSync(l_changePassword_9);
        }
        bool Expand = false;
        private void timer_Password_Tick(object sender, EventArgs e)
        {
            if (Expand == true)
            {
                this.Height -= 5;
                if (this.Height == this.MinimumSize.Height)
                {
                    timer_Password.Stop();
                    Expand = false;
                }
            }
            else
            {
                this.Height += 5;
                if (this.Height == this.MaximumSize.Height)
                {
                    timer_Password.Stop();
                    Expand = true;
                }
            }
        }

        private void b_close_9_Click(object sender, EventArgs e)
        {
            timer_Password.Start();
            Transition_9.ShowSync(l_changePassword_9);
        }

        private void l_changePassword_9_MouseHover(object sender, EventArgs e)
        {
            l_changePassword_9.ForeColor = Color.LightSteelBlue;
        }

        private void l_changePassword_9_MouseLeave(object sender, EventArgs e)
        {
            F_ROOMS_12 f_12 = new F_ROOMS_12();
            l_changePassword_9.ForeColor = f_12.l_add_rooms_12.ForeColor;
        }

        private void F_PRIVACY_9_Load(object sender, EventArgs e)
        {
            F_LOGIN_2 f_2 = Application.OpenForms["F_LOGIN_SIGNUP_2"] as F_LOGIN_2;
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
                sqlcmd.CommandText = "select emp_name, sex_emp, age_emp, type_emp_name, telephon_emp, email_emp from SECURITY_LOGIN where username = '"+Class_Forms.Login_2.C_LOGIN_2.username.ToString()+"' and password = '"+Class_Forms.Login_2.C_LOGIN_2.password.ToString() +"';";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_emp_name_9.Text = dread["emp_name"].ToString();
                    t_sex_9.Text = dread["sex_emp"].ToString();
                    t_age_9.Text = dread["age_emp"].ToString();
                    t_type_emp_9.Text = dread["type_emp_name"].ToString();
                    t_telephone_number_9.Text = dread["telephon_emp"].ToString();
                    t_email_9.Text = dread["email_emp"].ToString();
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
