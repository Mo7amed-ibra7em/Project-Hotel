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
    public partial class F_NEW_RESERVATION_6 : Form
    {
        public F_NEW_RESERVATION_6()
        {
            InitializeComponent();
        }

        private void F_NEW_RESERVATION_6_Load(object sender, EventArgs e)
        {
            t_fore_name_6.Select();
        }

        private void b_cancel_reservation_6_Click(object sender, EventArgs e)
        {
            Close();

            /////
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            f_5.pnl_load_form_5.Controls.Clear();
            F_F_ADMIN_15 f_15 = Application.OpenForms["F_F_ADMIN_15"] as F_F_ADMIN_15;
            f_15.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_15);
            f_15.Show();
        }

        private void b_next_6_Click(object sender, EventArgs e)
        {
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            F_NEW_RESERVATION_7 f_7 = new F_NEW_RESERVATION_7();
            f_7.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_7);
            f_7.Show();
            f_7.BringToFront();
        }

        private void l_8_6_Click(object sender, EventArgs e)
        {

        }

        private void l_7_6_Click(object sender, EventArgs e)
        {

        }

        private void l_6_6_Click(object sender, EventArgs e)
        {

        }

        private void l_5_6_Click(object sender, EventArgs e)
        {

        }

        private void l_4_6_Click(object sender, EventArgs e)
        {

        }

        private void l_3_6_Click(object sender, EventArgs e)
        {

        }

        private void l_2_6_Click(object sender, EventArgs e)
        {

        }

        private void l_1_6_Click(object sender, EventArgs e)
        {

        }

        private void t_telephone_number_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_identification_number_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_age_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_nationality_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_last_name_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_fore_name_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void d_exit_date_6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void d_date_of_entry_6_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
