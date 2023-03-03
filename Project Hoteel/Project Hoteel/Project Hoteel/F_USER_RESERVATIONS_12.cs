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
    public partial class F_USER_RESERVATIONS_12 : Form
    {
        public F_USER_RESERVATIONS_12()
        {
            InitializeComponent();
        }

        private void F_user_reservation_12_Load(object sender, EventArgs e)
        {

        }

        private void b_u_reservation_12_Click(object sender, EventArgs e)
        {
            F_LOGO_1 f_1 = Application.OpenForms["F_LOGO_1"] as F_LOGO_1;
            f_1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_CHANGE_PASSWORD_9 f_9 = new F_CHANGE_PASSWORD_9();
            f_9.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_6 f_6 = new F_NEW_RESERVATION_6();
            f_6.ShowDialog();
        }

    }
}
