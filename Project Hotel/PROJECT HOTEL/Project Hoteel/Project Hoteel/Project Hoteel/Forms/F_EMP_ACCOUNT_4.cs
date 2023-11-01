using Project_Hoteel.Class_Forms.Login_2;
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
        string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";
        bool BtnSave = false;
        string[] Data;
        public F_EMP_ACCOUNT_4()
        {
            InitializeComponent();
        }

        private void F_EMP_ACCOUNT_4_Load(object sender, EventArgs e)
        {
            GetDataEmp();
        }
        private void GetDataEmp()
        {
            try
            {
                DataTable mylist = new DataTable();

                using (SqlConnection sqlconn = new SqlConnection(connstr))
                using (SqlCommand sqlcmd1 = new SqlCommand("exec GetAllDataEmp", sqlconn))
                using (SqlDataAdapter sqladap = new SqlDataAdapter(sqlcmd1))
                {
                    sqlconn.Open();
                    sqladap.Fill(mylist);
                }

                dgv_4.DataSource = mylist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string[] UpdateEmp()
        {
            int ID = Convert.ToInt32(dgv_4.CurrentRow.Cells[0].Value);
            string empName = dgv_4.CurrentRow.Cells[1].Value.ToString();
            string telephone = dgv_4.CurrentRow.Cells[2].Value.ToString();
            string sex = dgv_4.CurrentRow.Cells[3].Value.ToString();
            string age = dgv_4.CurrentRow.Cells[4].Value.ToString();
            string username = dgv_4.CurrentRow.Cells[5].Value.ToString();
            string password = dgv_4.CurrentRow.Cells[6].Value.ToString();
            string salary = dgv_4.CurrentRow.Cells[7].Value.ToString();
            string jop = dgv_4.CurrentRow.Cells[8].Value.ToString();
            string Startdate = dgv_4.CurrentRow.Cells[9].Value.ToString();
            string email = dgv_4.CurrentRow.Cells[10].Value.ToString();

            string[] EmpData = { ID.ToString(), empName, telephone, sex, age, username, password, salary,jop,Startdate, email , BtnSave.ToString()};

            return EmpData;
        }
        private void b_edit_4_Click(object sender, EventArgs e)
        {
            if (dgv_4.DataSource == null || ((DataTable)dgv_4.DataSource).Rows.Count == 0)
            {
                Notification.MessageCollection.showNatification("لم يتم تحديد أي صف");
            }
            else
            {
                BtnSave = true;
                Data = UpdateEmp();
                OpenAddEmp();
            }
        }
        private void t_search_4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                using (SqlCommand sqlcmd1 = new SqlCommand("EXEC [dbo].[SearchEmpData] @searchText = @SearchText", sqlconn))
                {
                    sqlcmd1.Parameters.AddWithValue("@SearchText", t_search_4.Text);

                    using (SqlDataAdapter sqladap = new SqlDataAdapter(sqlcmd1))
                    {
                        DataTable mylist = new DataTable();

                        sqlconn.Open();
                        sqladap.Fill(mylist);

                        dgv_4.DataSource = mylist;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b_add_emp_4_Click(object sender, EventArgs e)
        {
            BtnSave = false;
            Data = UpdateEmp();
            OpenAddEmp();
        }
        private void OpenAddEmp()
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
            f_1.b_emp_account_1.BackColor = f_1.pnl_manager_1.BackColor;
            f_1.b_control_board_1.BackColor = f_1.pnl_manager_1.BackColor;
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
            F_ADD_EMP_19 f_19 = new F_ADD_EMP_19(Data);
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
            try
            {
                int ID = Convert.ToInt32(dgv_4.CurrentRow.Cells[0].Value);

                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();

                    using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[DeleteDataEmp] @ID = @EmpId, @emp_id = @EmpId", sqlconn))
                    {
                        sqlcmd.Parameters.AddWithValue("@EmpId", ID);
                        sqlcmd.ExecuteNonQuery();
                    }
                }
                // Refresh
                DataTable mylist = new DataTable();
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                using (SqlCommand sqlcmd1 = new SqlCommand("exec GetAllDataEmp", sqlconn))
                using (SqlDataAdapter sqladap = new SqlDataAdapter(sqlcmd1))
                {
                    sqlconn.Open();
                    sqladap.Fill(mylist);
                }
                dgv_4.DataSource = mylist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
