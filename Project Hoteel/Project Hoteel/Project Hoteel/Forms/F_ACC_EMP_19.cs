using Project_Hoteel.Class_Forms.Login_2;
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
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public F_ACC_EMP_19()
        {
            InitializeComponent();
        }

        private void F_ACC_EMP_19_Load(object sender, EventArgs e)
        {

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
            t_emp_name_19.Text = "";
            t_telephone_emp_19.Text = "";
            t_age_19.Text = "";
            cbox_sex_19.SelectedIndex = -1;
            t_username_19.Text = "";
            t_password_19.Text = "";
            t_salary_emp_19.Text = "";
            cbox_type_emp_19.SelectedIndex = -1;
            t_email_emp_19.Text = "";
            MessageCollection.showNatification("تمت العملية بنجاح");
        }
    }
}
