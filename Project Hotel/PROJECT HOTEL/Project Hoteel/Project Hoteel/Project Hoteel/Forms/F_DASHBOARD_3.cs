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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Hoteel
{
    public partial class F_DASHBOARD_3 : Form
    {
        static string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        public F_DASHBOARD_3()
        {
            InitializeComponent();
        }

        private void F_DASHBOARD_3_Load(object sender, EventArgs e)
        {
            GetDataDashBoard();
        }
        private void GetDataDashBoard()
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("DSH_GetRoom", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);

                    dgv_DataRoom.DataSource = resultTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }
                /////////////
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "DSH_GetNumberRoomEmpCus";

                    SqlParameter EmployeeCountParam = new SqlParameter("@EmployeeCount", SqlDbType.Int);
                    EmployeeCountParam.Direction = ParameterDirection.Output;
                    SqlParameter TotalRoomsParam = new SqlParameter("@TotalRooms", SqlDbType.Int);
                    TotalRoomsParam.Direction = ParameterDirection.Output;
                    SqlParameter ResidentsCountParam = new SqlParameter("@ResidentsCount", SqlDbType.Int);
                    ResidentsCountParam.Direction = ParameterDirection.Output;
                    SqlParameter DeparturesCountParam = new SqlParameter("@DeparturesCount", SqlDbType.Int);
                    DeparturesCountParam.Direction = ParameterDirection.Output;
                    SqlParameter PendingReservationsCountParam = new SqlParameter("@PendingReservationsCount", SqlDbType.Int);
                    PendingReservationsCountParam.Direction = ParameterDirection.Output;

                    sqlcmd.Parameters.Add(EmployeeCountParam);
                    sqlcmd.Parameters.Add(TotalRoomsParam);
                    sqlcmd.Parameters.Add(ResidentsCountParam);
                    sqlcmd.Parameters.Add(DeparturesCountParam);
                    sqlcmd.Parameters.Add(PendingReservationsCountParam);

                    sqlcmd.ExecuteNonQuery();

                    int EmployeeCount = Convert.ToInt32(EmployeeCountParam.Value);
                    int TotalRooms = Convert.ToInt32(TotalRoomsParam.Value);
                    int ResidentsCount = Convert.ToInt32(ResidentsCountParam.Value);
                    int DeparturesCount = Convert.ToInt32(DeparturesCountParam.Value);
                    int PendingReservationsCount = Convert.ToInt32(PendingReservationsCountParam.Value);

                    EmpNumber.Text = EmployeeCount.ToString();
                    RoomNumber.Text = TotalRooms.ToString();
                    CusTupe0.Text = ResidentsCount.ToString();
                    CusTupe1.Text = DeparturesCount.ToString();
                    CusTupe2.Text = PendingReservationsCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }

                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("DSH_GetResidentsCountByRoomTypes", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.Add(new SqlParameter("@Sweet", SqlDbType.Int));
                    sqlcmd.Parameters["@Sweet"].Direction = ParameterDirection.Output;

                    sqlcmd.Parameters.Add(new SqlParameter("@Third", SqlDbType.Int));
                    sqlcmd.Parameters["@Third"].Direction = ParameterDirection.Output;

                    sqlcmd.Parameters.Add(new SqlParameter("@Double", SqlDbType.Int));
                    sqlcmd.Parameters["@Double"].Direction = ParameterDirection.Output;

                    sqlcmd.Parameters.Add(new SqlParameter("@Single", SqlDbType.Int));
                    sqlcmd.Parameters["@Single"].Direction = ParameterDirection.Output;

                    sqlcmd.ExecuteNonQuery();

                    int sweetCount = Convert.ToInt32(sqlcmd.Parameters["@Sweet"].Value);
                    int thirdCount = Convert.ToInt32(sqlcmd.Parameters["@Third"].Value);
                    int doubleCount = Convert.ToInt32(sqlcmd.Parameters["@Double"].Value);
                    int singleCount = Convert.ToInt32(sqlcmd.Parameters["@Single"].Value);

                    chart2.Series["Residents"].Points.Clear();
                    chart2.Series["Residents"].Points.AddXY("سويت", sweetCount);
                    chart2.Series["Residents"].Points.AddXY("ثلاثية", thirdCount);
                    chart2.Series["Residents"].Points.AddXY("مزدوجة", doubleCount);
                    chart2.Series["Residents"].Points.AddXY("مفردة", singleCount);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }
                /////////////
                try
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("DSH_GetFinancialData", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter totalRevenueParam = new SqlParameter("@TotalRevenue", SqlDbType.Decimal);
                    totalRevenueParam.Direction = ParameterDirection.Output;
                    totalRevenueParam.Precision = 18;
                    totalRevenueParam.Scale = 2;
                    sqlcmd.Parameters.Add(totalRevenueParam);

                    SqlParameter totalExpensesParam = new SqlParameter("@TotalExpenses", SqlDbType.Decimal);
                    totalExpensesParam.Direction = ParameterDirection.Output;
                    totalExpensesParam.Precision = 18;
                    totalExpensesParam.Scale = 2;
                    sqlcmd.Parameters.Add(totalExpensesParam);

                    sqlcmd.ExecuteNonQuery();

                    decimal totalRevenue = (decimal)sqlcmd.Parameters["@TotalRevenue"].Value;
                    decimal totalExpenses = (decimal)sqlcmd.Parameters["@TotalExpenses"].Value;

                    lblRevenue.Text = totalRevenue.ToString() + "  $";
                    lblExpenses.Text = totalExpenses.ToString() + "  $";

                    chart1.Series["Series1"].Points.AddXY("الإيرادات", totalRevenue);
                    chart1.Series["Series1"].Points.AddXY("المصروفات", totalExpenses);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
