using Project_Hoteel.Notification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel.Class_Forms.Login_2
{
    internal class C_LOGIN_2
    {
        #region متغيرات + اتصال مع قاعدة البانات
        static public string SERVER1 = "M-A-IBRAHEM";
        static string connstr = "Data Source="+SERVER1+ "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";
        static F_LOGIN_2 f_2 = Application.OpenForms["F_LOGIN_2"] as F_LOGIN_2;
        //"انشاء متغيرات للبريد وكلمة المرور"
        static public string username = "Filed";
        static public string password = "Filed";
        static public int Emp_jop_index;
        static public bool Login_emp_add = false;
        static public bool Login_emp_accounting = false;
        static public bool Login_manager = false;
        static public string l_user = "";
        static public int IdSub;
        ///////
        private int _ticks;
        //
        bool ExpandMenu;
        #endregion

        public static void ButtonLogin()
        {
            if (f_2.t_username_2.Text != "Password" && f_2.t_username_2.Text != "" && f_2.t_password_2.Text != "UserName" && f_2.t_password_2.Text != "")
            {
                if (f_2.t_username_2.Text != "اسم المستخدم" && f_2.t_username_2.Text != "" && f_2.t_password_2.Text != "كلمة المرور" && f_2.t_password_2.Text != "")
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
                        sqlcmd.CommandText = "EXEC GetDataLogin "+f_2.t_username_2.Text+","+f_2.t_password_2.Text+"";
                        sqlconn.Open();
                        dread = sqlcmd.ExecuteReader();
                        while (dread.Read())
                        {
                            username = dread["username"].ToString();
                            password = dread["password"].ToString();
                            Emp_jop_index = Convert.ToInt32(dread["Emp_Jop_index"]);
                            l_user = dread["emp_name"].ToString();
                            IdSub = Convert.ToInt32(dread["Id_Sub"]);
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

            if (f_2.t_password_2.Text == "Password" && f_2.t_username_2.Text == "UserName" || f_2.t_username_2.Text == "اسم المستخدم" && f_2.t_password_2.Text == "كلمة المرور")
            {
                //f_2.l_notificatio_2.Text = "ادخل معلوماتك";
                if (f_2.t_password_2.Text == "Password")
                {
                    f_2.t_password_2.Text = "Password";
                    f_2.t_username_2.Text = "UserName";
                }
                else
                {
                    f_2.t_password_2.Text = "كلمة المرور";
                    f_2.t_username_2.Text = "اسم المستخدم";
                }
                f_2.t_password_2.PasswordChar = char.MinValue;
                MessageCollection.showNatification("ادخل معلوماتك");
            }
            else if (f_2.t_password_2.Text != Convert.ToString(password) || f_2.t_username_2.Text != username)
            {
                if (f_2.RightToLeft == RightToLeft.No)
                {
                    f_2.t_password_2.Text = "Password";
                    f_2.t_username_2.Text = "UserName";
                }
                else
                {
                    f_2.t_password_2.Text = "كلمة المرور";
                    f_2.t_username_2.Text = "اسم المستخدم";
                }
                f_2.t_password_2.PasswordChar = char.MinValue;
                MessageCollection.showNatification("اسم المستخدم او كلمة المرور خطأ");
            }
            else if (f_2.t_username_2.Text == username && f_2.t_password_2.Text == Convert.ToString(password))
            {
                f_2.l_username_2.Text = "أهلا وسهلاً   " + l_user;
                
                if (Emp_jop_index == 0)
                {
                    f_2.Transition_form_2.HideSync(f_2.b_login_2);
                    Login_emp_add = true;
                    f_2.timer_progress_2.Start();
                }
                else if (Emp_jop_index == 1)
                {
                    f_2.Transition_form_2.HideSync(f_2.b_login_2);
                    Login_emp_accounting = true;
                    f_2.timer_progress_2.Start();
                }
                else if (Emp_jop_index == 3)
                {
                    f_2.Transition_form_2.HideSync(f_2.b_login_2);
                    Login_manager = true;
                    f_2.timer_progress_2.Start();
                }
                MessageCollection.showNatification("تم تسجيل الدخول بنجاح");
            }
        }
        public static void TimerLogin()
        {
            if (Login_emp_add == true || Login_manager == true  || Login_emp_accounting == true)
            {
                f_2.ProgressBar_2.Value += f_2.ProgressBar_2.Step;
                f_2.l_progress_2.Text = Convert.ToString(f_2.ProgressBar_2.Value / 5) + " %";
                if (f_2.ProgressBar_2.Value == 500)
                {
                    f_2.timer_progress_2.Stop();
                    if (Login_emp_add == true)
                    {
                        F_ADMIN_5 f_5 = new F_ADMIN_5();
                        f_5.b_hanging_reservations_5.Visible = false;
                        f_5.b9.Visible = false;
                        f_5.b10.Visible = false;
                        f_5.ShowDialog();
                        Login_emp_add = false;
                        f_2.ProgressBar_2.Value = 5;
                        f_2.l_progress_2.Text = "1 %";
                        f_2.Transition_form_2.ShowSync(f_2.b_login_2);
                    }
                    else if (Login_emp_accounting == true)
                    {
                        F_ADMIN_5 f_5 = new F_ADMIN_5();
                        f_5.b_new_reservation_5.Visible = false;
                        f_5.b_hanging_reservations_5.Location = new System.Drawing.Point(4, 126);
                        f_5.b_hanging_reservations_5.BringToFront();
                        f_5.b9.Visible = false;
                        f_5.b10.Visible = false;
                        f_5.b_residents_5.Visible = false;
                        f_5.b7.Visible = false;
                        f_5.b8.Visible = false;
                        f_5.b_debartures_5.Visible = false;
                        f_5.b5.Visible = false;
                        f_5.b6.Visible = false;
                        f_5.ShowDialog();
                        
                        Login_emp_add = false;
                        f_2.ProgressBar_2.Value = 5;
                        f_2.l_progress_2.Text = "1 %";
                        f_2.Transition_form_2.ShowSync(f_2.b_login_2);
                    }
                    else if (Login_manager == true)
                    {
                        F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
                        f_1.ShowDialog();
                        Login_manager = false;
                        f_2.ProgressBar_2.Value = 5;
                        f_2.l_progress_2.Text = "1 %";
                        f_2.Transition_form_2.ShowSync(f_2.b_login_2);
                    }
                }
            }
        }
    }
}
