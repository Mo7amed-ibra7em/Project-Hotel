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
        string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        string password = "";
        string username = "";
        bool Expand = false;

        public F_PRIVACY_MANAGER_20()
        {
            InitializeComponent();
        }
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
            t_password_new_20.Text = "";
            t_password_new_2_20.Text = "";
            t_password_old_20.Text = "";
            t_username_new_20.Text = "";
            t_username_old_20.Text = "";
        }
        private void b_save_edit_20_Click(object sender, EventArgs e)
        {
            // التحقق من وجود النافذة المفتوحة
            F_NOTIF_PASSWORD_24 f_24 = Application.OpenForms.OfType<F_NOTIF_PASSWORD_24>().FirstOrDefault();
            if (f_24 != null)
            {
                try
                {
                    string correctPassword;
                    using (SqlConnection sqlconn = new SqlConnection(connstr))
                    {
                        sqlconn.Open();

                        // استدعاء الإجراء للحصول على كلمة المرور
                        using (SqlCommand getPasswordCmd = new SqlCommand("EXEC [dbo].[GetDataManagerPassword]", sqlconn))
                        {
                            correctPassword = Convert.ToString(getPasswordCmd.ExecuteScalar());
                        }
                    }
                    if (f_24.t_enter_pass_24.Text == correctPassword)
                    {
                        using (SqlConnection sqlconn = new SqlConnection(connstr))
                        {
                            sqlconn.Open();
                            // استدعاء الإجراء لتحديث بيانات المدير
                            using (SqlCommand updateCmd = new SqlCommand("EXEC [dbo].[UpdateDataManager] @EmpName, @Age, @TelephoneNumber, @Email", sqlconn))
                            {
                                updateCmd.Parameters.AddWithValue("@EmpName", t_name_20.Text);
                                updateCmd.Parameters.AddWithValue("@Age", Convert.ToInt32(t_age_20.Text));
                                updateCmd.Parameters.AddWithValue("@TelephoneNumber", t_telephone_20.Text);
                                updateCmd.Parameters.AddWithValue("@Email", t_email_20.Text);
                                updateCmd.ExecuteNonQuery();
                            }
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                F_NOTIF_PASSWORD_24 newF_24 = new F_NOTIF_PASSWORD_24();
                newF_24.Show();
                SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\RWDA TECH\Desktop\Visual S\Project Hoteel\Project Hoteel\Project Hoteel\Sound\Background_Sound.wav");
                _soundPlayer.Play();
            }
        }
        private void b_change_password_9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();

                    using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[GetDataManagerPassword]", sqlconn))
                    {
                        SqlDataReader dread = sqlcmd.ExecuteReader();
                        if (dread.Read())
                        {
                            password = Convert.ToString(dread["password"]);
                            username = Convert.ToString(dread["UserName"]);
                        }
                    }
                }

                if (string.IsNullOrEmpty(t_password_old_20.Text) || string.IsNullOrEmpty(t_password_new_2_20.Text) || string.IsNullOrEmpty(t_password_new_20.Text) || string.IsNullOrEmpty(t_username_new_20.Text) || string.IsNullOrEmpty(t_username_old_20.Text))
                {
                    MessageCollection.showNatification("تأكد من ملء كامل المعلومات");
                }
                else if (t_password_new_20.Text != t_password_new_2_20.Text)
                {
                    MessageCollection.showNatification("كلمة المرور غير متطابقة");
                    t_password_new_20.Text = "";
                    t_password_new_2_20.Text = "";
                }
                else if (t_password_old_20.Text == Convert.ToString(password) && t_password_new_20.Text == t_password_new_2_20.Text && t_password_new_20.Text != "" && t_username_old_20.Text == username)
                {
                    using (SqlConnection sqlconn = new SqlConnection(connstr))
                    {
                        sqlconn.Open();

                        using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[UpdateManagerUsernameAndPassword] @OldUsername, @OldPassword, @NewUsername, @NewPassword", sqlconn))
                        {
                            sqlcmd.Parameters.AddWithValue("@OldUsername", t_username_old_20.Text);
                            sqlcmd.Parameters.AddWithValue("@OldPassword", t_password_old_20.Text);
                            sqlcmd.Parameters.AddWithValue("@NewUsername", t_username_new_20.Text);
                            sqlcmd.Parameters.AddWithValue("@NewPassword", t_password_new_2_20.Text);

                            sqlcmd.ExecuteNonQuery();

                            MessageCollection.showNatification("تم التغيير بنجاح");
                        }
                    }
                }
                else
                {
                    MessageCollection.showNatification("اسم المستخدم او كلمة المرور خطأ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void F_PRIVACY_MANAGER_20_Load(object sender, EventArgs e)
        {
            LoadManagerData();
        }
        private void LoadManagerData()
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();

                    using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[GetDataManager]", sqlconn))
                    {
                        using (SqlDataReader reader = sqlcmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                t_name_20.Text = reader["Emp_Name"].ToString();
                                t_age_20.Text = reader["Emp_Age"].ToString();
                                t_telephone_20.Text = reader["Emp_Number"].ToString();
                                t_email_20.Text = reader["Emp_Email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
