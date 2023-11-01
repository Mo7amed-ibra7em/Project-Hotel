using Project_Hoteel.Class_Forms.Login_2;
using Project_Hoteel.Forms;
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
    public partial class F_HANGING_RESERVATION_13 : Form
    {
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";
        string[] InstallData;
    public F_HANGING_RESERVATION_13()
        {
            InitializeComponent();
        }

        private void F_HANGING_RESERVATION_13_Load(object sender, EventArgs e)
        {
            GetDataWep();
            GetCustomerData();
        }
        public void GetDataWep()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("GetDataWebCus", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
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
        private void GetCustomerData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("GetCustomerData", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@Cus_type", 2);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgv_13.DataSource = dataTable;
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
        private void SearchDataCustomer()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("SearchCustomerData", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@searchTerm", t_search_13.Text);
                    sqlcmd.Parameters.AddWithValue("@cus_type", 2);

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dgv_13.DataSource = resultTable;
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
        private void t_search_13_TextChanged(object sender, EventArgs e)
        {
            SearchDataCustomer();
        }
        private string[] DataInstall()
        {
            InstallData = new string[] { dgv_13.CurrentRow.Cells[0].Value.ToString(), dgv_13.CurrentRow.Cells[1].Value.ToString(), dgv_13.CurrentRow.Cells[10].Value.ToString(), dgv_13.CurrentRow.Cells[14].Value.ToString() };
            return InstallData;
        }
        private void b_secure_reservation_13_Click(object sender, EventArgs e)
        {
            F_INSTALL_RESERVATION_22 f_INSTALL_RESERVATION_22 = new F_INSTALL_RESERVATION_22(DataInstall());
            f_INSTALL_RESERVATION_22.ShowDialog();
            GetCustomerData();
        }
    }
}
