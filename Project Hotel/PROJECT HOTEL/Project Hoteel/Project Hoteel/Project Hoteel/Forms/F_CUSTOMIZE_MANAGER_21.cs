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
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_CUSTOMIZE_MANAGER_21 : Form
    {
        string connstr11 = "Data Source="+C_LOGIN_2.SERVER1+"; Initial Catalog=Hoteel Reservation;Integrated Security = True";
        string connstr = "Data Source=" + C_LOGIN_2.SERVER1 + "; Initial Catalog=HOTEL RESERVATION;Integrated Security = True";

        public F_CUSTOMIZE_MANAGER_21()
        {
            InitializeComponent();
        }

        private void F_CUSTOMIZE_MANAGER_21_Load(object sender, EventArgs e)
        {
            try
            {
                string[] roomTypes = { "مفردة", "مزدوجة", "ثلاثية", "سويت" }; // أنواع الغرف التي تريد الاستعلام عن أسعارها

                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();

                    for (int i = 0; i < roomTypes.Length; i++)
                    {
                        using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[GetRoomPriceByType] @RoomType = @RoomType", sqlconn))
                        {
                            sqlcmd.Parameters.AddWithValue("@RoomType", roomTypes[i]);

                            object roomPrice = sqlcmd.ExecuteScalar();
                            if (roomPrice != null)
                            {
                                // قم بتحويل القيمة إلى النوع المناسب (مثلاً decimal أو double)
                                decimal roomPriceValue = Convert.ToDecimal(roomPrice);
                                // عرض السعر في TextBox المناسب
                                if (i == 0)
                                    t_singular_12.Text = roomPriceValue.ToString();
                                else if (i == 1)
                                    t_dualism_12.Text = roomPriceValue.ToString();
                                else if (i == 2)
                                    t_trilogy_12.Text = roomPriceValue.ToString();
                                else if (i == 3)
                                    t_sweet_12.Text = roomPriceValue.ToString();
                            }
                            else
                            {
                                MessageBox.Show("لم يتم العثور على سعر الغرفة المحددة.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void b_save_21_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connstr))
                {
                    sqlconn.Open();
                    string[] roomTextBoxes = { t_singular_12.Text, t_dualism_12.Text, t_trilogy_12.Text, t_sweet_12.Text };
                    string[] roomTypes = { "مفردة", "مزدوجة", "ثلاثية", "سويت" };

                    for (int i = 0; i < roomTypes.Length; i++)
                    {
                        float newRoomPriceValue = Convert.ToSingle(roomTextBoxes[i]);
                        string roomType = roomTypes[i];

                        using (SqlCommand sqlcmd = new SqlCommand("EXEC [dbo].[UpdateAllRoomPrices] @NewPrice = @NewPrice, @Room_Type = @Room_Type", sqlconn))
                        {
                            sqlcmd.Parameters.AddWithValue("@NewPrice", newRoomPriceValue);
                            sqlcmd.Parameters.AddWithValue("@Room_Type", roomType);
                            sqlcmd.ExecuteNonQuery();
                        }
                    }
                }
                Notification.MessageCollection.showNatification("تم التحديــث بنجــاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
