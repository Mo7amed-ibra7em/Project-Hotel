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
    public partial class F_DEBARTURES_11 : Form
    {
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        public F_DEBARTURES_11()
        {
            InitializeComponent();
        }
        private string[] ArrayData()
        {
            int Id = Convert.ToInt32(dgv_11.CurrentRow.Cells[0].Value);
            string Name = dgv_11.CurrentRow.Cells[1].Value.ToString();
            string RoomType = dgv_11.CurrentRow.Cells[9].Value.ToString();
            int RoomNumber = Convert.ToInt32(dgv_11.CurrentRow.Cells[10].Value);
            int PeopleNumber = Convert.ToInt32(dgv_11.CurrentRow.Cells[5].Value);
            DateTime StartDate = Convert.ToDateTime(dgv_11.CurrentRow.Cells[11].Value);
            DateTime EndDate = Convert.ToDateTime(dgv_11.CurrentRow.Cells[12].Value);
            int DayNumber = Convert.ToInt32(dgv_11.CurrentRow.Cells[13].Value);
            string Price = dgv_11.CurrentRow.Cells[14].Value.ToString();

            string[] Data = new string[] { Id.ToString(), Name, RoomType, RoomNumber.ToString(), PeopleNumber.ToString(), StartDate.ToString(), EndDate.ToString(), DayNumber.ToString(), Price };
            return Data;
        }
        private void F_DEBARTURES_11_Load(object sender, EventArgs e)
        {
            GetCustomerData();
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

                    sqlcmd.Parameters.AddWithValue("@Cus_type", 1);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgv_11.DataSource = dataTable;
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
        private void b_add_11_Click(object sender, EventArgs e)
        {
            string [] DataCus = ArrayData();
            F_ADD_CUS_23 f_23 = new F_ADD_CUS_23(DataCus);
            f_23.ShowDialog();
            GetCustomerData();
        }
        private void t_search_11_TextChanged(object sender, EventArgs e)
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

                    sqlcmd.Parameters.AddWithValue("@searchTerm", t_search_11.Text);
                    sqlcmd.Parameters.AddWithValue("@cus_type", 1);

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dgv_11.DataSource = resultTable;
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
