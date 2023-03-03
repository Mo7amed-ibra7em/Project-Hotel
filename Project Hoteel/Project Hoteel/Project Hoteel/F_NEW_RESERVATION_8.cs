using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_NEW_RESERVATION_8 : Form
    {
        double price_8_10 = 10, price_8_20 = 20, price_8_30 = 30, price_8_40 = 40, price_room = 0;
        double price_bb_2 = 2,  price_hb_4 = 4,  price_fb_6 = 6,  price_meals = 0;
        
        

        public F_NEW_RESERVATION_8()
        {
            InitializeComponent();
        }

        private void b_back_8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radio_panel1_1_8_CheckedChanged(object sender, EventArgs e)
        {

            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            if(f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room=price_8_10*Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text= "$ " + Convert.ToString(price_room+price_meals);
            }
            if (f_7.radio_panel2_1_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_2_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if(f_7.radio_panel2_3_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if(f_7.radio_panel2_4_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if(f_7.radio_panel3_1_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if(f_7.radio_panel3_2_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if(f_7.radio_panel3_3_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if(f_7.radio_panel3_4_7.Checked)
            {
                price_room = price_8_10 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }

        }


        private void radio_panel1_2_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            if (f_7.radio_panel2_1_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_2_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_3_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_4_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_1_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_2_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_3_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_4_7.Checked)
            {
                price_room = price_8_20 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
        }


        private void radio_panel1_3_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            if (f_7.radio_panel2_1_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_2_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_3_7.Checked)
            {
price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);            }
            else if (f_7.radio_panel2_4_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_1_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_2_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_3_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_4_7.Checked)
            {
                price_room = price_8_30 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
        }

        private void radio_panel1_4_8_CheckedChanged(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            if (f_7.t_number_all_7.Text != Convert.ToString(0))
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            if (f_7.radio_panel2_1_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_2_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_3_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel2_4_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_1_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_2_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_3_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
            else if (f_7.radio_panel3_4_7.Checked)
            {
                price_room = price_8_40 * Convert.ToDouble(f_7.t_number_all_7.Text);
                t_price_8.Text = "$ " + Convert.ToString(price_room + price_meals);
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            t_meal_type_8.Text = "وجبة الافطار فقط .";
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            price_meals = price_bb_2 * Convert.ToDouble(f_7.t_number_all_7.Text);
            t_price_8.Text = "$ " + Convert.ToString(price_meals+price_room);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t_meal_type_8.Text = "وجبتي طعام ( الإفطار والعشاء ) .";
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            price_meals = price_hb_4 * Convert.ToDouble(f_7.t_number_all_7.Text);
            t_price_8.Text = "$ " + Convert.ToString(price_meals + price_room);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            t_meal_type_8.Text = "ثلاث وجبات .";
            F_NEW_RESERVATION_7 f_7 = Application.OpenForms["F_NEW_RESERVATION_7"] as F_NEW_RESERVATION_7;
            price_meals = price_fb_6 * Convert.ToDouble(f_7.t_number_all_7.Text);
            t_price_8.Text = "$ " + Convert.ToString(price_meals + price_room);
        }


        private void F_NEW_RESERVATION_8_Load(object sender, EventArgs e)
        {
            radio_panel1_1_8.Checked = true;
        }

        private void b_reserve_8_Click(object sender, EventArgs e)
        {
            F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();
            f_10.ShowDialog();
        }



    }
}
