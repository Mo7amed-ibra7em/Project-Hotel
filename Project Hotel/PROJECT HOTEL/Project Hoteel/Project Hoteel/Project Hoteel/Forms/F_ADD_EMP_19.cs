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
    public partial class F_ADD_EMP_19 : Form
    {
        string connstr = "Data Source="+C_LOGIN_2.SERVER1+ "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";
        string[] DataEmp;
        public F_ADD_EMP_19(string[] DataEmp)
        {
            InitializeComponent();
            this.DataEmp = DataEmp;
        }
        private void F_ACC_EMP_19_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(DataEmp[11]) == true)
            {
                b_add_employe_19.Text = "تعديل";
                
                t_emp_name_19.Text = DataEmp[1];
                t_telephone_emp_19.Text = DataEmp[2];
                t_age_19.Text = DataEmp[3];
                cbox_sex_19.SelectedItem = DataEmp[4];
                t_username_19.Text = DataEmp[5];
                t_password_19.Text = DataEmp[6];
                t_salary_emp_19.Text= DataEmp[7];
                cbox_type_emp_19.SelectedItem = DataEmp[8];
                dtp_start_date_19.Value = Convert.ToDateTime(DataEmp[9]);
                t_email_emp_19.Text = DataEmp[10];
            }
            else
            {
                b_add_employe_19.Text = "إضافة";
            }
        }
        private void b_add_employe_19_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(DataEmp[11]) == true)
            {
                UpdateDataEmp();
            }
            else
            {
                AddDataEmp();
                t_emp_name_19.Text = "";
                t_telephone_emp_19.Text = "";
                t_age_19.Text = "";
                cbox_sex_19.SelectedIndex = -1;
                t_username_19.Text = "";
                t_password_19.Text = "";
                t_salary_emp_19.Text = "";
                cbox_type_emp_19.SelectedIndex = -1;
                t_email_emp_19.Text = "";
            }  
        }
        private void UpdateDataEmp()
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    SqlCommand sqlcmd = new SqlCommand("UpdateDataEmp", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@id", DataEmp[0]);
                    sqlcmd.Parameters.AddWithValue("@emp_name", t_emp_name_19.Text);
                    sqlcmd.Parameters.AddWithValue("@telephon_emp", t_telephone_emp_19.Text);
                    sqlcmd.Parameters.AddWithValue("@sex_emp", cbox_sex_19.SelectedItem.ToString());
                    sqlcmd.Parameters.AddWithValue("@age_emp", t_age_19.Text);
                    sqlcmd.Parameters.AddWithValue("@username", t_username_19.Text);
                    sqlcmd.Parameters.AddWithValue("@password", t_password_19.Text);
                    sqlcmd.Parameters.AddWithValue("@email_emp", t_email_emp_19.Text);
                    sqlcmd.Parameters.AddWithValue("@Start_date", dtp_start_date_19.Value);
                    sqlcmd.Parameters.AddWithValue("@emp_salary", float.Parse(t_salary_emp_19.Text));
                    sqlcmd.Parameters.AddWithValue("@emp_jop", cbox_type_emp_19.SelectedItem.ToString());
                    sqlcmd.Parameters.AddWithValue("@emp_jop_index", cbox_type_emp_19.SelectedIndex);

                    sqlconn.Open();
                    sqlcmd.ExecuteNonQuery();
                    MessageCollection.showNatification("تمت العملية بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddDataEmp()
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
                sqlcmd.CommandText = "EXEC InsertDataEmp @username = '" + t_username_19.Text + "', " +
                    "@password = '" + t_password_19.Text + "'," +
                    " @salary_emp = '" + float.Parse(t_salary_emp_19.Text) + "'," +
                    " @Emp_Jop_index = " + cbox_type_emp_19.SelectedIndex + "," +
                    " @type_emp_name = '" + cbox_type_emp_19.SelectedItem.ToString() + "'," +
                    " @emp_name = '" + t_emp_name_19.Text + "'," +
                    " @telephon_emp = " + t_telephone_emp_19.Text + "," +
                    " @sex_emp = '" + cbox_sex_19.SelectedItem.ToString() + "'," +
                    " @age_emp = '" + t_age_19.Text + "'," +
                    " @email_emp = '" + t_email_emp_19.Text + "'," +
                    "@start_date = '" + dtp_start_date_19.Text + "';";
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                MessageCollection.showNatification("تمت العملية بنجاح");
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
