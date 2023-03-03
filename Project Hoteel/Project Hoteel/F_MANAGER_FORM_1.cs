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
    public partial class F_MANAGER_FORM_1 : Form
    {
        public F_MANAGER_FORM_1()
        {
            InitializeComponent();
        }


        private void b_emp_account_1_Click(object sender, EventArgs e)
        {
            pnl_load_form_1.Controls.Clear();
            F_EMP_ACCOUNT_4 f_4 = new F_EMP_ACCOUNT_4();
            f_4.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_4);
            f_4.Show();
            /////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_emp_account_1.BackColor = f_1.BackColor;
            b_control_board_1.BackColor = pnl_manager_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            pnl_line1_1.Visible = false;
            pnl_line2_1.Visible = true;
            pnl_line3_1.Visible = false;
            pnl_line4_1.Visible = false;
        }
        private void b_custom_account_1_Click(object sender, EventArgs e)
        {
            pnl_load_form_1.Controls.Clear();
            F_CUSTOM_ACCOUNT_14 f_14 = new F_CUSTOM_ACCOUNT_14();
            f_14.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_14);
            f_14.Show();
            /////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_custom_account_1.BackColor = f_1.BackColor;
            b_control_board_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            pnl_line1_1.Visible = false;
            pnl_line2_1.Visible = false;
            pnl_line3_1.Visible = true;
            pnl_line4_1.Visible = false;
        }

        private void b_control_board_1_Click_1(object sender, EventArgs e)
        {
            pnl_load_form_1.Controls.Clear();
            F_DASHBOARD_3 f_3 = new F_DASHBOARD_3();
            f_3.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_3);
            f_3.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_control_board_1.BackColor = f_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            pnl_line1_1.Visible = true;
            pnl_line2_1.Visible = false;
            pnl_line3_1.Visible = false;
            pnl_line4_1.Visible = false;
        }

        private void b_settings_1_Click(object sender, EventArgs e)
        {
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_settings_1.BackColor = f_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_control_board_1.BackColor = pnl_manager_1.BackColor;
            pnl_line1_1.Visible = false;
            pnl_line2_1.Visible = false;
            pnl_line3_1.Visible = false;
            pnl_line4_1.Visible = true;
        }

        private void F_MANAGER_FORM_1_Load(object sender, EventArgs e)
        {
            //////
            pnl_load_form_1.Controls.Clear();
            F_DASHBOARD_3 f_3 = new F_DASHBOARD_3();
            f_3.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_3);
            f_3.Show();
            //
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_control_board_1.BackColor = f_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            pnl_line1_1.Visible = true;
            pnl_line2_1.Visible = false;
            pnl_line3_1.Visible = false;
            pnl_line4_1.Visible = false;
        }
    }
}
