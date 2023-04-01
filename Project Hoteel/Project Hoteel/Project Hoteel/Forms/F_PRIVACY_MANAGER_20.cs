using Project_Hoteel.Class_Forms.Login_2;
using Project_Hoteel.Forms;
using Project_Hoteel.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_PRIVACY_MANAGER_20 : Form
    {
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hotel Reservation;Integrated Security = True";
        string password = "";
        int Show_pass = 0;
        //Class_Forms.Login_2.C_LOGIN_2 c_2 = new Class_Forms.Login_2.C_LOGIN_2();
        public F_PRIVACY_MANAGER_20()
        {
            InitializeComponent();
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
        private void l_changePassword_20_Click(object sender, EventArgs e)
        {
            timer_Password.Start();
            Transition_1_20.HideSync(b_save_edit_20);
            Transition_2_20.HideSync(l_changePassword_20);
        }
        private void b_close_9_Click(object sender, EventArgs e)
        {
            timer_Password.Start();
            Transition_1_20.ShowSync(b_save_edit_20);
            Transition_2_20.ShowSync(l_changePassword_20);
        }
        private void b_save_edit_20_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<F_NOTIF_PASSWORD_24>().Any())
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
                    sqlcmd.CommandText = "select password from Security_Login where type_emp_index = 3";
                    sqlconn.Open();
                    dread = sqlcmd.ExecuteReader();
                    while (dread.Read())
                    {
                        password = Convert.ToString(dread["password"]);
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
                ///
                F_NOTIF_PASSWORD_24 f_24 = Application.OpenForms["F_NOTIF_PASSWORD_24"] as F_NOTIF_PASSWORD_24;
                if (f_24.t_enter_pass_24.Text == password)
                {
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
                        SqlCommand sqlcmd1 = new SqlCommand();
                        sqlcmd1.Connection = sqlconn;
                        sqlcmd1.CommandText = "update SECURITY_LOGIN set emp_name = '" + t_name_20.Text + "',age_emp = " + t_age_20.Text + " ,telephon_emp = " + t_telephone_20.Text + " ,email_emp = '" + t_email_20.Text + "' where type_emp_index = 3";
                        sqlconn.Open();
                        sqlcmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    f_24.Close();
                    MessageCollection.showNatification("تم التعديل بنجاح");
                }
                else
                {
                    f_24.t_enter_pass_24.Text = "";
                    f_24.t_enter_pass_24.PlaceholderText = "كلمة مرورك خطأ";
                    SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\RWDA TECH\Desktop\Visual S\Project Hoteel\Project Hoteel\Project Hoteel\Sound\Background_Sound.wav");
                    _soundPlayer.Play();
                }
            }
            else
            {
                F_NOTIF_PASSWORD_24 f__24 = new F_NOTIF_PASSWORD_24();
                f__24.Show();
                SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\RWDA TECH\Desktop\Visual S\Project Hoteel\Project Hoteel\Project Hoteel\Sound\Background_Sound.wav");
                _soundPlayer.Play();
            }

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
                sqlcmd.CommandText = "select password from Security_Login where type_emp_index = 3";
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

            if (t_password_old_20.Text == "" || t_password_new_2_20.Text == "" || t_password_new_20.Text == "" || t_username_new_20.Text == "" || t_username_old_20.Text == "")
            {
                MessageCollection.showNatification("تأكد من ملء كامل المعلومات");
            }
            //if (t_password_old_20.Text == Convert.ToString(f_2.password) && t_password_new_20.Text == "" && t_password_new_2_20.Text == "")
            //{
            //    L_20.Text = "!... ادخل كلمة المرور الجديدة";
            //}
            //if (t_password_old_20.Text == "" && t_password_new_20.Text != "" && t_password_new_2_20.Text != "")
            //{
            //    L_20.Text = "!... ادخل كلمة مرورك الحالية ";
            //}
            //if (t_password_old_20.Text != "" && t_password_new_20.Text == "")
            //{
            //    L_20.Text = "!... ادخل كلمة المرور الجديدة ";
            //}
            else if (t_password_old_20.Text != Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password))
            {
                MessageCollection.showNatification("اسم المستخدم او كلمة المرور خطأ");
            }
            else if (t_password_old_20.Text == Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_20.Text != "" && t_password_new_2_20.Text == "" || t_password_old_20.Text != Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_20.Text != "" && t_password_new_2_20.Text == "")
            {
                MessageCollection.showNatification("أعد كتابة كلمة المرور");
            }
            else if (t_password_new_20.Text != t_password_new_2_20.Text && t_password_old_20.Text != "" && t_password_new_20.Text != "" && t_password_new_2_20.Text != "")
            {
                MessageCollection.showNatification("كلمة المرور غير متطابقة");
                t_password_new_20.Text = "";
                t_password_new_2_20.Text = "";
            }
            else if (t_password_old_20.Text == Convert.ToString(Class_Forms.Login_2.C_LOGIN_2.password) && t_password_new_20.Text == t_password_new_2_20.Text && t_password_new_20.Text != "")
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
                    sqlcmd1.CommandText = "update Security_Login set password = '" + t_password_new_2_20.Text + "' , username = '"+t_username_new_20.Text+"' where password = '" + t_password_old_20.Text + "' and username = '"+t_username_old_20.Text+"'";
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
                MessageCollection.showNatification("تم التغيير بنجاح");
            }
        }

        private void F_PRIVACY_MANAGER_20_Load(object sender, EventArgs e)
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
                sqlcmd.CommandText = "select emp_name,age_emp,telephon_emp,email_emp from SECURITY_LOGIN where type_emp_index = 3";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    t_name_20.Text = dread["emp_name"].ToString();
                    t_age_20.Text = dread["age_emp"].ToString();
                    t_telephone_20.Text = dread["telephon_emp"].ToString();
                    t_email_20.Text = dread["email_emp"].ToString();
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
