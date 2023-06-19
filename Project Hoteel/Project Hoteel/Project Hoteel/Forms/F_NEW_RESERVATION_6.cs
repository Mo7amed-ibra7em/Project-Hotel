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
    }
}
