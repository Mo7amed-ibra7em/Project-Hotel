using Project_Hoteel.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_ACC_EMP_19 : Form
    {
        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public F_ACC_EMP_19()
        {
            InitializeComponent();
        }
        private void b_add_employe_19_Click(object sender, EventArgs e)
        {
            //if(Panel_1.Size == Panel_1.MaximumSize)
            //{
            //    Transition_19.HideSync(b_add_employe_19);
            //    timer_add_emp_19.Start();
            //}
        }
        private void b_close_19_Click(object sender, EventArgs e)
        {   
            //if(Panel_1.Size == Panel_1.MinimumSize)
            //{
            //    timer_add_emp_19.Start();
            //    Transition_19.ShowSync(b_add_employe_19);
            //}
        }
        bool Expand = false;
        private void timer_add_emp_19_Tick(object sender, EventArgs e)
        {
            //if (Expand == false)
            //{
            //    Panel_1.Width -= 20;
            //    if (Panel_1.Width == Panel_1.MinimumSize.Width)
            //    {
            //        timer_add_emp_19.Stop();
            //        Expand = true;
            //    }
            //}
            //else
            //{
            //    Panel_1.Width += 20;
            //    if (Panel_1.Width == Panel_1.MaximumSize.Width)
            //    {
            //        timer_add_emp_19.Stop();
            //        Expand = false;
            //    }
            //}
        }
        private void b_save_employe_19_Click(object sender, EventArgs e)
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
                sqlcmd.CommandText = "insert into SECURITY_LOGIN (emp_name,telephon_emp,sex_emp,age_emp,username,password,salary_emp,type_emp_index,type_emp_name,start_date,email_emp) values ('"+t_emp_name_19.Text+"',"+float.Parse(t_telephone_emp_19.Text)+",'"+cbox_sex_19.SelectedItem+"','"+t_age_19.Text+"','"+t_username_19.Text+"','"+t_password_19.Text+"','"+t_salary_emp_19.Text+"',"+cbox_type_emp_19.SelectedIndex+",'"+cbox_type_emp_19.SelectedItem.ToString()+"','"+date_start_date_19.Text+"','"+t_email_emp_19.Text+"')";
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
            ////
            //Refresh
            //try
            //{
            //    sqlconn.ConnectionString = connstr;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //SqlCommand sqlcmd1 = new SqlCommand();
            //sqlcmd1.Connection = sqlconn;
            //sqlcmd1.CommandText = "select emp_name as 'اسم الموظف',telephon_emp 'رقم الهاتف',sex_emp as 'الجنس',age_emp as 'العمر',username 'اسم المستخدم',password 'كلمة المرور',salary_emp 'الراتب',type_emp_name 'العمل',start_date 'تاريخ البدء',email_emp 'البريد الالكتروني' from SECURITY_LOGIN";
            //SqlDataAdapter sqladap = new SqlDataAdapter();
            //sqladap.SelectCommand = sqlcmd1;
            //DataTable mylist = new DataTable();
            //SqlDataReader dread;
            //try
            //{
            //    sqlconn.Open();
            //    sqladap.Fill(mylist);
            //    dread = sqlcmd1.ExecuteReader();
            //    dgv_19.DataSource = mylist;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    sqlconn.Close();
            //}
            t_emp_name_19.Text = "";
            t_telephone_emp_19.Text = "";
            t_age_19.Text = "";
            cbox_sex_19.SelectedIndex = -1;
            t_username_19.Text = "";
            t_password_19.Text = "";
            t_salary_emp_19.Text = "";
            cbox_type_emp_19.SelectedIndex = -1;
            t_email_emp_19.Text = "";
            l_notificatio_19.Text = "تمت العملية بنجاح";
            MessageCollection.showNatification(l_notificatio_19.Text);
        }
        private void F_ACC_EMP_19_Load(object sender, EventArgs e)
        {

            //SqlConnection sqlconn = new SqlConnection();
            //try
            //{
            //    sqlconn.ConnectionString = connstr;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //SqlCommand sqlcmd1 = new SqlCommand();
            //sqlcmd1.Connection = sqlconn;
            //sqlcmd1.CommandText = "select emp_name as 'اسم الموظف',telephon_emp 'رقم الهاتف',sex_emp as 'الجنس',age_emp as 'العمر',username 'اسم المستخدم',password 'كلمة المرور',salary_emp 'الراتب',type_emp_name 'العمل',start_date 'تاريخ البدء',email_emp 'البريد الالكتروني' from SECURITY_LOGIN";
            //SqlDataAdapter sqladap = new SqlDataAdapter();
            //sqladap.SelectCommand = sqlcmd1;
            //DataTable mylist = new DataTable();
            //SqlDataReader dread;
            //try
            //{
            //    sqlconn.Open();
            //    sqladap.Fill(mylist);
            //    dread = sqlcmd1.ExecuteReader();
            //    dgv_19.DataSource = mylist;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    sqlconn.Close();
            //}
        }
    }
}
