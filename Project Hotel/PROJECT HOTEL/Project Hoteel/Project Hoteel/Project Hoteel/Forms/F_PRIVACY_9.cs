using Project_Hoteel.Class_Forms.Login_2;
using Project_Hoteel.Notification;
using System;
using System.Data.SqlClient;
using System.Drawing;

using System.Windows.Forms;


namespace Project_Hoteel
{
    public partial class F_PRIVACY_9 : Form
    {        
        string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        string password = "";
        int IdSub = C_LOGIN_2.IdSub;
        bool Pass = false;
        private int _ticks;
        bool Expand = false;

        public F_PRIVACY_9()
        {
            InitializeComponent();
        }

        private void GetPassword()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();
                    using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[GetPasswordByIdSubEmp] @IdSub", sqlconn))
                    {
                        sqlcmd.Parameters.AddWithValue("@IdSub", IdSub);

                        SqlDataReader dread = sqlcmd.ExecuteReader();
                        if (dread.Read())
                        {
                            password = Convert.ToString(dread["Password"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        private void b_change_password_9_Click(object sender, EventArgs e)
        {
            GetPassword();
            if (string.IsNullOrEmpty(t_password_old_9.Text) || string.IsNullOrEmpty(t_password_new_2_9.Text) || string.IsNullOrEmpty(t_password_new_9.Text))
            {
                l_notificatio_9.Text = "!... ادخل معلوماتك";
            }
            else if (t_password_old_9.Text != password)
            {
                l_notificatio_9.Text = "!... كلمة مرورك خطأ";
            }
            else if (t_password_new_9.Text != t_password_new_2_9.Text)
            {
                l_notificatio_9.Text = "!... كلمة المرور غير متطابقة";
                t_password_new_9.Text = "";
                t_password_new_2_9.Text = "";
            }
            else
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    try
                    {
                        sqlconn.Open();

                        using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[UpdatePasswordEmpPrivacy] @IdSub, @OldPassword, @NewPassword", sqlconn))
                        {
                            sqlcmd.Parameters.AddWithValue("@IdSub", IdSub);
                            sqlcmd.Parameters.AddWithValue("@OldPassword", t_password_old_9.Text);
                            sqlcmd.Parameters.AddWithValue("@NewPassword", t_password_new_2_9.Text);

                            sqlcmd.ExecuteNonQuery();

                            l_notificatio_9.Text = "تم تغيير كلمة المرور بنجاح";
                            Pass = true;
                            _ticks = 0;
                            timer_Close.Start();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageCollection.showNatification(l_notificatio_9.Text);
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
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();
                    using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[GetDataEmpPrivacy] @Username, @Password", sqlconn))
                    {
                        sqlcmd.Parameters.AddWithValue("@Username", C_LOGIN_2.username.ToString());
                        sqlcmd.Parameters.AddWithValue("@Password", C_LOGIN_2.password.ToString());

                        SqlDataReader dread = sqlcmd.ExecuteReader();
                        while (dread.Read())
                        {
                            t_emp_name_9.Text = dread["Emp_Name"].ToString();
                            t_sex_9.Text = dread["Emp_Sex"].ToString();
                            t_age_9.Text = dread["Emp_Age"].ToString();
                            t_type_emp_9.Text = dread["Emp_Jop"].ToString();
                            t_telephone_number_9.Text = dread["Emp_Number"].ToString();
                            t_email_9.Text = dread["Emp_Email"].ToString();
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
