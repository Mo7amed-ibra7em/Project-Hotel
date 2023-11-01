using Project_Hoteel.Class_Forms.Login_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_RESIDENTS_10 : Form
    {
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";


        public F_RESIDENTS_10()
        {
            InitializeComponent();
        }
        private void UpdateDataCus()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "UpdateDataCustomer";

                    sqlcmd.Parameters.AddWithValue("@room_number", dgv_10.CurrentRow.Cells[9].Value);
                    sqlcmd.Parameters.AddWithValue("@name", dgv_10.CurrentRow.Cells[0].Value.ToString());
                    sqlcmd.Parameters.AddWithValue("@telephone_number", dgv_10.CurrentRow.Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@nationality", dgv_10.CurrentRow.Cells[2].Value);
                    sqlcmd.Parameters.AddWithValue("@age", dgv_10.CurrentRow.Cells[3].Value);
                    sqlcmd.Parameters.AddWithValue("@identification_number", dgv_10.CurrentRow.Cells[5].Value);
                    sqlcmd.Parameters.AddWithValue("@wife_name", dgv_10.CurrentRow.Cells[6].Value);
                    sqlcmd.Parameters.AddWithValue("@wife_identity_number", dgv_10.CurrentRow.Cells[7].Value);

                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GetCustomerData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("GetCustomerData", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@Cus_type", 0);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgv_10.DataSource = dataTable;
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
        private void deleteDataCus()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "DeleteDataCus";

                    sqlcmd.Parameters.AddWithValue("@id", dgv_10.CurrentRow.Cells[0].Value);

                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void F_RESIDENTS_10_Load(object sender, EventArgs e)
        {
           GetCustomerData();
        }
        private void b_edit_10_Click(object sender, EventArgs e)
        {
            if (b_edit_10.FillColor == b_diparting_10.FillColor)
            {
                dgv_10.ReadOnly = false;
                b_edit_10.FillColor = Color.LightSteelBlue;
                b_edit_10.ForeColor = Color.RoyalBlue;
                b_edit_10.BorderColor = Color.Plum;
            }
            else if (b_edit_10.FillColor == Color.LightSteelBlue)
            {
                dgv_10.ReadOnly = true;
                b_edit_10.FillColor = b_diparting_10.FillColor;
                b_edit_10.ForeColor = b_diparting_10.ForeColor;
                b_edit_10.BorderColor = b_diparting_10.BorderColor;
                /////
                UpdateDataCus();
                GetCustomerData();
            }
        }
        private void b_diparting_10_Click(object sender, EventArgs e)
        {
            deleteDataCus();
            GetCustomerData();
        }
        private void t_search_10_TextChanged(object sender, EventArgs e)
        {
            SearchDataCustomer();
        }
        private void SearchDataCustomer()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("SearchCustomerData", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@searchTerm", t_search_10.Text);
                    sqlcmd.Parameters.AddWithValue("@cus_type", 0);

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dgv_10.DataSource = resultTable;
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
}
