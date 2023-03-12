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
    public partial class F_SETTINGS_ADMIN_16 : Form
    {
        public F_SETTINGS_ADMIN_16()
        {
            InitializeComponent();
        }

        private void b_privacy_16_Click(object sender, EventArgs e)
        {
            pnl_load_form_16.Controls.Clear();
            F_PRIVACY_9 f_9 = new F_PRIVACY_9();
            f_9.TopLevel = false;
            pnl_load_form_16.Controls.Add(f_9);
            f_9.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_privac_16.BackColor = f_1.BackColor;
            b_rooms_16.BackColor = pnl_admin_1.BackColor;
            b_customize_16.BackColor = pnl_admin_1.BackColor;
            b_about_16.BackColor = pnl_admin_1.BackColor;
            pnl_line1_16.Visible = true;
            pnl_line2_16.Visible = false;
            pnl_line3_16.Visible = false;
            pnl_line4_16.Visible = false;
        }

        private void b_rooms_16_Click(object sender, EventArgs e)
        {
            pnl_load_form_16.Controls.Clear();
            F_ROOMS_12 f_12 = new F_ROOMS_12();
            f_12.TopLevel = false;
            pnl_load_form_16.Controls.Add(f_12);
            f_12.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_privac_16.BackColor = pnl_admin_1.BackColor;
            b_rooms_16.BackColor = f_1.BackColor;
            b_customize_16.BackColor = pnl_admin_1.BackColor;
            b_about_16.BackColor = pnl_admin_1.BackColor;
            pnl_line1_16.Visible = false;
            pnl_line2_16.Visible = true;
            pnl_line3_16.Visible = false;
            pnl_line4_16.Visible = false;
        }

        private void b_customize_16_Click(object sender, EventArgs e)
        {
            pnl_load_form_16.Controls.Clear();
            F_CUSTOMIZE_17 f_17 = new F_CUSTOMIZE_17();
            f_17.TopLevel = false;
            pnl_load_form_16.Controls.Add(f_17);
            f_17.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_privac_16.BackColor = pnl_admin_1.BackColor;
            b_rooms_16.BackColor = pnl_admin_1.BackColor;
            b_customize_16.BackColor = f_1.BackColor;
            b_about_16.BackColor = pnl_admin_1.BackColor;
            pnl_line1_16.Visible = false;
            pnl_line2_16.Visible = false;
            pnl_line3_16.Visible = true;
            pnl_line4_16.Visible = false;
        }

        private void b_about_16_Click(object sender, EventArgs e)
        {
            //pnl_load_form_16.Controls.Clear();
            //F_PRIVACY_9 f_9 = new F_PRIVACY_9();
            //f_9.TopLevel = false;
            //pnl_load_form_16.Controls.Add(f_9);
            //f_9.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_privac_16.BackColor = pnl_admin_1.BackColor;
            b_rooms_16.BackColor = pnl_admin_1.BackColor;
            b_customize_16.BackColor = pnl_admin_1.BackColor;
            b_about_16.BackColor = f_1.BackColor;
            pnl_line1_16.Visible = false;
            pnl_line2_16.Visible = false;
            pnl_line3_16.Visible = false;
            pnl_line4_16.Visible = true;
        }

        private void F_SETTINGS_ADMIN_16_Load(object sender, EventArgs e)
        {
            pnl_load_form_16.Controls.Clear();
            F_PRIVACY_9 f_9 = new F_PRIVACY_9();
            f_9.TopLevel = false;
            pnl_load_form_16.Controls.Add(f_9);
            f_9.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_privac_16.BackColor = f_1.BackColor;
            b_rooms_16.BackColor = pnl_admin_1.BackColor;
            b_customize_16.BackColor = pnl_admin_1.BackColor;
            b_about_16.BackColor = pnl_admin_1.BackColor;
            pnl_line1_16.Visible = true;
            pnl_line2_16.Visible = false;
            pnl_line3_16.Visible = false;
            pnl_line4_16.Visible = false;
        }
    }
}
