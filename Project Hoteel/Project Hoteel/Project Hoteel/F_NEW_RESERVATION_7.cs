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
    public partial class F_NEW_RESERVATION_7 : Form
    {
        public double people_7 = 1;
        public double people_all = 1;

        public string WifeName;
        public string iNumber;
       



        public F_NEW_RESERVATION_7()
        {
            InitializeComponent();
        }

        

        private void b_next_7_Click(object sender, EventArgs e)
        {

            if (chb_there_is_awife_7.Checked == true)
            {
                WifeName = t_fore_name_7.Text + " " + t_last_name_7.Text;
                iNumber = t_identification_number_7.Text;
            }
            else
            {
                WifeName = "#####";
                iNumber  = "#####";
            }

            t_number_all_7.Text=people_all.ToString();

            /////
            
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            F_NEW_RESERVATION_8 f_8 = new F_NEW_RESERVATION_8();
            f_8.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_8);
            f_8.Show();
            f_8.BringToFront();
        }

        private void chb_there_is_awife_7_CheckedChanged(object sender, EventArgs e)
        {
           if(chb_there_is_awife_7.Checked == false)
            {
               
                t_fore_name_7.ReadOnly = true;
                t_last_name_7.ReadOnly = true;
                t_identification_number_7.ReadOnly = true;
                t_fore_name_7.FillColor = Color.Gainsboro;
                t_last_name_7.FillColor = Color.Gainsboro;
                t_identification_number_7.FillColor = Color.Gainsboro;
                t_fore_name_7.BorderThickness = 0;
                t_last_name_7.BorderThickness = 0;
                t_identification_number_7.BorderThickness = 0;
                t_fore_name_7.Text = "";
                t_last_name_7.Text = "";
                t_identification_number_7.Text = "";
                people_7 -= 1;
                people_all -= 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);

            }
           else
            {
                t_fore_name_7.ReadOnly = false;
                t_last_name_7.ReadOnly = false;
                t_identification_number_7.ReadOnly = false;
                t_fore_name_7.FillColor = panel1.BackColor;
                t_last_name_7.FillColor = panel1.BackColor;
                t_identification_number_7.FillColor = panel1.BackColor;
                t_fore_name_7.BorderThickness = 1;
                t_last_name_7.BorderThickness = 1;
                t_identification_number_7.BorderThickness = 1;
                people_7 += 1;
                people_all += 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void F_NEW_RESERVATION_7_Load(object sender, EventArgs e)
        {

            t_number_of_people_7.Text = Convert.ToString(people_7);
            t_number_all_7.Text = Convert.ToString(people_all);

        }

        private void radio_panel1_1_7_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_panel1_1_7.Checked == true)
            {
                people_7 += 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);

            }
            else
            {
                people_7 -= 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
        }

        private void radio_panel1_2_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel1_2_7.Checked == true)
            {
                people_7 += 2;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
            else
            {
                people_7 -= 2;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
        }

        private void radio_panel1_3_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel1_3_7.Checked == true)
            {
                people_7 += 3;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
            else
            {
                people_7 -= 3;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
        }

        private void radio_panel1_4_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel1_4_7.Checked == true)
            {
                people_7 += 4;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
            else
            {
                people_7 -= 4;
                t_number_of_people_7.Text = Convert.ToString(people_7);
            }
        }

        private void radio_panel2_1_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel2_1_7.Checked == true)
            {
                people_7 += 1;
                people_all += 0.5;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text= Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 1;
                people_all -= 0.5;
                t_number_of_people_7.Text = Convert.ToString(people_7); 
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel2_2_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel2_2_7.Checked == true)
            {
                people_7 += 2;
                people_all += 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 2;
                people_all -= 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel2_3_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel2_3_7.Checked == true)
            {
                people_7 += 3;
                people_all += 1.5;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 3;
                people_all -= 1.5;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel2_4_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel2_4_7.Checked == true)
            {
                people_7 += 4;
                people_all += 2;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 4;
                people_all -= 2;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel3_1_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel3_1_7.Checked == true)
            {
                people_7 += 1;
                people_all += 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 1;
                people_all -= 1;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel3_2_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel3_2_7.Checked == true)
            {
                people_7 += 2;
                people_all += 2;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 2;
                people_all -= 2;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel3_3_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel3_3_7.Checked == true)
            {
                people_7 += 3;
                people_all += 3;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 3;
                people_all -= 3;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void radio_panel3_4_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_panel3_4_7.Checked == true)
            {
                people_7 += 4;
                people_all += 4;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
            else
            {
                people_7 -= 4;
                people_all -= 4;
                t_number_of_people_7.Text = Convert.ToString(people_7);
                t_number_all_7.Text = Convert.ToString(people_all);
            }
        }

        private void b_back_7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void l_there_is_awife_7_Click(object sender, EventArgs e)
        {
            if (chb_there_is_awife_7.Checked == false)
            {
                chb_there_is_awife_7.Checked = true;
            }
            else
            {
                chb_there_is_awife_7.Checked = false;
            }
        }
    }
}
