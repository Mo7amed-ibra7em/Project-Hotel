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
    public partial class F_ADMIN_5 : Form
    {
        public F_ADMIN_5()
        {
            InitializeComponent();
        }

        private void b_new_reservation_5_Click(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_6 f_6 = new F_NEW_RESERVATION_6();
            f_6.ShowDialog();
        }



        private void l_change_password_5_MouseHover_1(object sender, EventArgs e)
        {
            l_change_password_5.ForeColor = Color.Red;
        }

        private void l_change_password_5_MouseLeave(object sender, EventArgs e)
        {
            l_change_password_5.ForeColor = Color.White;
        }

        private void l_sign_out_5_MouseHover(object sender, EventArgs e)
        {
            l_sign_out_5.ForeColor = Color.Red;
        }

        private void l_sign_out_5_MouseLeave(object sender, EventArgs e)
        {
            l_sign_out_5.ForeColor = Color.White;
        }

        private void l_sign_out_5_Click(object sender, EventArgs e)
        {
            F_LOGO_1 f_1 = Application.OpenForms["F_LOGO_1"] as F_LOGO_1;
            f_1.Close();
        }

        private void l_change_password_5_Click(object sender, EventArgs e)
        {
            F_CHANGE_PASSWORD_9 f_9 = new F_CHANGE_PASSWORD_9();
            f_9.ShowDialog();
        }

        private void b_residents_5_Click(object sender, EventArgs e)
        {
            F_RESIDENTS_10 f_10 = new F_RESIDENTS_10();
            f_10.ShowDialog();
        }

        private void b_debartures_5_Click(object sender, EventArgs e)
        {
            F_DEBARTURES_11 f_11 = new F_DEBARTURES_11();
            f_11.ShowDialog();
        }
    }
}
