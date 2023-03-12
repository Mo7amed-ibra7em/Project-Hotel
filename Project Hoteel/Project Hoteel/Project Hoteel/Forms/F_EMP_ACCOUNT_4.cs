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
    public partial class F_EMP_ACCOUNT_4 : Form
    {

        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";
        //public bool btn_4 = false;
        public F_EMP_ACCOUNT_4()
        {
            InitializeComponent();
        }

        private void F_EMP_ACCOUNT_4_Load(object sender, EventArgs e)
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
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select id as 'الرقم الافتراضي', emp_name as 'اسم الموظف',telephon_emp 'رقم الهاتف',sex_emp as 'الجنس',age_emp as 'العمر',username 'اسم المستخدم',password 'كلمة المرور',salary_emp 'الراتب',type_emp_name 'العمل',start_date 'تاريخ البدء',email_emp 'البريد الالكتروني' from SECURITY_LOGIN where type_emp_index != 3 ";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_4.DataSource = mylist;
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

        private void b_edit_4_Click(object sender, EventArgs e)
        {
            if (b_edit_4.FillColor == b_delete_4.FillColor)
            {
                dgv_4.ReadOnly = false;
                b_edit_4.FillColor = Color.LightSteelBlue;
                b_edit_4.ForeColor = Color.RoyalBlue;
                b_edit_4.BorderColor = Color.Plum;
            }
            else if (b_edit_4.FillColor == Color.LightSteelBlue)
            {
                dgv_4.ReadOnly = true;
                b_edit_4.FillColor = b_delete_4.FillColor;
                b_edit_4.ForeColor = b_delete_4.ForeColor;
                b_edit_4.BorderColor = b_delete_4.BorderColor;
                int ID = Convert.ToInt32(dgv_4.CurrentRow.Cells[0].Value);

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
                    sqlcmd.CommandText = "update SECURITY_LOGIN set emp_name ='" + dgv_4.CurrentRow.Cells[1].Value.ToString() + "', telephon_emp =" + dgv_4.CurrentRow.Cells[2].Value + ", sex_emp ='" + dgv_4.CurrentRow.Cells[3].Value.ToString() + "', age_emp =" + dgv_4.CurrentRow.Cells[4].Value + ", username ='" + dgv_4.CurrentRow.Cells[5].Value.ToString() + "', password ='" + dgv_4.CurrentRow.Cells[6].Value.ToString() + "', salary_emp ='" + dgv_4.CurrentRow.Cells[7].Value.ToString() +"', type_emp_name ='" + dgv_4.CurrentRow.Cells[8].Value.ToString() +"', start_date ='" + dgv_4.CurrentRow.Cells[9].Value.ToString() +"', email_emp ='" + dgv_4.CurrentRow.Cells[10].Value.ToString() +"' where id = " + ID + ";";
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
                ///
                //Refresh
                ///
                try
                {
                    sqlconn.ConnectionString = connstr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.Connection = sqlconn;
                sqlcmd1.CommandText = "select id as 'الرقم الافتراضي', emp_name as 'اسم الموظف',telephon_emp 'رقم الهاتف',sex_emp as 'الجنس',age_emp as 'العمر',username 'اسم المستخدم',password 'كلمة المرور',salary_emp 'الراتب',type_emp_name 'العمل',start_date 'تاريخ البدء',email_emp 'البريد الالكتروني' from SECURITY_LOGIN where type_emp_index != 3 ";
                SqlDataAdapter sqladap = new SqlDataAdapter();
                sqladap.SelectCommand = sqlcmd1;
                DataTable mylist = new DataTable();
                try
                {
                    sqlconn.Open();
                    sqladap.Fill(mylist);
                    dgv_4.DataSource = mylist;
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

        private void t_search_4_TextChanged(object sender, EventArgs e)
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
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select id as 'الرقم الافتراضي', emp_name as 'اسم الموظف',telephon_emp 'رقم الهاتف',sex_emp as 'الجنس',age_emp as 'العمر',username 'اسم المستخدم',password 'كلمة المرور',salary_emp 'الراتب',type_emp_name 'العمل',start_date 'تاريخ البدء',email_emp 'البريد الالكتروني' from SECURITY_LOGIN where type_emp_index != 3 and (id like '%"+t_search_4.Text+"%' or username like '%"+t_search_4.Text+"%' or password like '%"+t_search_4.Text+"%' or emp_name like '%"+t_search_4.Text+"%' or type_emp_name like '%"+t_search_4.Text+"%' or telephon_emp like '%"+t_search_4.Text+"%' or salary_emp like '%"+t_search_4.Text+"%' or email_emp like '%"+t_search_4.Text+"%' or start_date like '%"+t_search_4.Text+"%' or age_emp like '%"+t_search_4.Text+"%' or sex_emp like '%"+t_search_4.Text+"%' or id like '%"+t_search_4.Text+"%'); ";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_4.DataSource = mylist;
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
        private void b_add_emp_4_Click(object sender, EventArgs e)
        {
            F_MANAGER_FORM_1 f_1 = Application.OpenForms["F_MANAGER_FORM_1"] as F_MANAGER_FORM_1;
            /////
            f_1.pnl_load_form_1.Controls.Clear();
            F_SETTINGS_MANAGER_18 f_18 = new F_SETTINGS_MANAGER_18();
            f_18.TopLevel = false;
            f_1.pnl_load_form_1.Controls.Add(f_18);
            f_18.Show();
            f_18.BringToFront();

            f_1.b_settings_1.BackColor = f_1.BackColor;
            f_1.b_custom_account_1.BackColor = f_1.pnl_manager_1.BackColor;
            f_1.b_emp_account_1.BackColor = f_1.pnl_manager_1.BackColor;
            f_1.b_control_board_1.BackColor = f_1.pnl_manager_1.BackColor;
            f_1.pnl_line1_1.Visible = false;
            f_1.pnl_line2_1.Visible = false;
            f_1.pnl_line3_1.Visible = false;
            f_1.pnl_line4_1.Visible = true;
            ////
            f_18.acc_emp_18 = true;
            f_18.timer_checked_18.Enabled = true;

            f_18.b_privac_18.FillColor = f_18.pnl_manager_18.BackColor;
            f_18.b_privac_18.BorderColor = Color.CornflowerBlue;
            f_18.b_acc_emp_18.BackColor = this.BackColor;
            f_18.b_acc_emp_18.BorderColor = Color.Thistle;
            f_18.b_customize_18.FillColor = f_18.pnl_manager_18.BackColor;
            f_18.b_customize_18.BorderColor = Color.CornflowerBlue;
            f_18.b_about_18.FillColor = f_18.pnl_manager_18.BackColor;
            f_18.b_about_18.BorderColor = Color.CornflowerBlue;
            ////
            f_18.pnl_load_form_18.Controls.Clear();
            F_ACC_EMP_19 f_19 = new F_ACC_EMP_19();
            f_19.TopLevel = false;
            f_18.pnl_load_form_18.Controls.Add(f_19);
            f_19.Show();
            ////
            f_18.b_acc_emp_18.BackColor = f_1.pnl_manager_1.BackColor;
            f_18.b_acc_emp_18.FillColor = f_1.pnl_manager_1.BackColor;
            f_18.b_acc_emp_18.UseTransparentBackground = false;
        }

        private void b_delete_4_Click(object sender, EventArgs e)
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
                sqlcmd.CommandText = "delete from SECURITY_LOGIN where id = " + dgv_4.CurrentRow.Cells[0].Value + ";";
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
            ////Refresh
            try
            {
                sqlconn.ConnectionString = connstr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select id as 'الرقم الافتراضي', emp_name as 'اسم الموظف',telephon_emp 'رقم الهاتف',sex_emp as 'الجنس',age_emp as 'العمر',username 'اسم المستخدم',password 'كلمة المرور',salary_emp 'الراتب',type_emp_name 'العمل',start_date 'تاريخ البدء',email_emp 'البريد الالكتروني' from SECURITY_LOGIN where type_emp_index != 3 ";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_4.DataSource = mylist;
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
