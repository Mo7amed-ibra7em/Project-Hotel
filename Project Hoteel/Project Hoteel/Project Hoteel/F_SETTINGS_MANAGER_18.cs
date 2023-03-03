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
    public partial class F_SETTINGS_MANAGER_18 : Form
    {
        public F_SETTINGS_MANAGER_18()
        {
            InitializeComponent();
        }
        private void b_privac_18_Click(object sender, EventArgs e)
        {
            b_privac_18.FillColor = this.BackColor;
            b_privac_18.BorderColor = Color.Thistle;
            b_cover_1.Visible = true;
            b_cover_2.Visible = true;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_3.Visible = false;
            b_cover_4.Visible = false;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_5.Visible = false;
            b_cover_6.Visible = false;
            b_about_18.FillColor= pnl_manager_18.BackColor;
            b_about_18.BorderColor= pnl_manager_18.BackColor;
            b_cover_7.Visible= false;
            b_cover_8.Visible= false;
        }

        private void b_acc_emp_18_Click(object sender, EventArgs e)
        {
            b_privac_18.FillColor = pnl_manager_18.BackColor;
            b_privac_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_1.Visible = false;
            b_cover_2.Visible = false;
            b_acc_emp_18.FillColor = this.BackColor;
            b_acc_emp_18.BorderColor = Color.Thistle;
            b_cover_3.Visible = true;
            b_cover_4.Visible = true;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_5.Visible = false;
            b_cover_6.Visible = false;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_7.Visible = false;
            b_cover_8.Visible = false;
            //
            pnl_load_form_18.Controls.Clear();
            F_ACC_EMP_19 f_19 = new F_ACC_EMP_19();
            f_19.TopLevel = false;
            pnl_load_form_18.Controls.Add(f_19);
            f_19.Show();
        }

        private void b_customize_18_Click(object sender, EventArgs e)
        {
            b_privac_18.FillColor = pnl_manager_18.BackColor;
            b_privac_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_1.Visible = false;
            b_cover_2.Visible = false;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_3.Visible = false;
            b_cover_4.Visible = false;
            b_customize_18.FillColor = this.BackColor;
            b_customize_18.BorderColor = Color.Thistle;
            b_cover_5.Visible = true;
            b_cover_6.Visible = true;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_8.Visible = false;
            b_cover_7.Visible = false;
        }

        private void b_about_18_Click(object sender, EventArgs e)
        {
            b_privac_18.FillColor = pnl_manager_18.BackColor;
            b_privac_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_1.Visible = false;
            b_cover_2.Visible = false;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_3.Visible = false;
            b_cover_4.Visible = false;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_5.Visible = false;
            b_cover_6.Visible = false;
            b_about_18.FillColor = this.BackColor;
            b_about_18.BorderColor = Color.Thistle;
            b_cover_7.Visible = true;
            b_cover_8.Visible = true;
        }

        private void F_SETTINGS_MANAGER_18_Load(object sender, EventArgs e)
        {
            b_privac_18.HoverState.FillColor = b_privac_18.FillColor;
            b_privac_18.PressedColor = b_privac_18.FillColor;
            b_acc_emp_18.HoverState.FillColor = b_acc_emp_18.FillColor;
            b_acc_emp_18.PressedColor = b_acc_emp_18.FillColor;
            b_customize_18.HoverState.FillColor = b_customize_18.FillColor;
            b_customize_18.PressedColor = b_customize_18.FillColor;
            b_about_18.HoverState.FillColor = b_about_18.FillColor;
            b_about_18.PressedColor = b_about_18.FillColor;
            /////
            b_privac_18.FillColor = this.BackColor;
            b_privac_18.BorderColor = Color.Thistle;
            b_cover_1.Visible = true;
            b_cover_2.Visible = true;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_3.Visible = false;
            b_cover_4.Visible = false;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_5.Visible = false;
            b_cover_6.Visible = false;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = pnl_manager_18.BackColor;
            b_cover_7.Visible = false;
            b_cover_8.Visible = false;
        }
    }
}
