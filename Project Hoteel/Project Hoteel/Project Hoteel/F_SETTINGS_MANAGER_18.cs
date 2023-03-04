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
        bool privac_18 = false;
        bool acc_emp_18 = false;
        bool customize_18 = false;
        bool about_18 = false;
        int fresh = 0;

        public F_SETTINGS_MANAGER_18()
        {
            InitializeComponent();
        }
        private void b_privac_18_Click(object sender, EventArgs e)
        {
            privac_18 = true;
            timer_checked_18.Enabled = true;
            ////
            b_privac_18.FillColor = this.BackColor;
            b_privac_18.BorderColor = Color.Thistle;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = Color.CornflowerBlue;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = Color.CornflowerBlue;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = Color.CornflowerBlue;
            ////
            pnl_load_form_18.Controls.Clear();
            F_PRIVACY_MANAGER_20 f_20 = new F_PRIVACY_MANAGER_20();
            f_20.TopLevel = false;
            pnl_load_form_18.Controls.Add(f_20);
            f_20.Show();
        }

        private void b_acc_emp_18_Click(object sender, EventArgs e)
        {
            acc_emp_18 = true;
            timer_checked_18.Enabled = true;

            b_privac_18.FillColor = pnl_manager_18.BackColor;
            b_privac_18.BorderColor = Color.CornflowerBlue;
            b_acc_emp_18.FillColor = this.BackColor;
            b_acc_emp_18.BorderColor = Color.Thistle;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = Color.CornflowerBlue;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = Color.CornflowerBlue;
            //
            pnl_load_form_18.Controls.Clear();
            F_ACC_EMP_19 f_19 = new F_ACC_EMP_19();
            f_19.TopLevel = false;
            pnl_load_form_18.Controls.Add(f_19);
            f_19.Show();
        }

        private void b_customize_18_Click(object sender, EventArgs e)
        {
            customize_18 = true;
            timer_checked_18.Enabled = true;

            b_privac_18.FillColor = pnl_manager_18.BackColor;
            b_privac_18.BorderColor = Color.CornflowerBlue;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = Color.CornflowerBlue;
            b_customize_18.FillColor = this.BackColor;
            b_customize_18.BorderColor = Color.Thistle;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = Color.CornflowerBlue;
            //
            pnl_load_form_18.Controls.Clear();
            F_CUSTOMIZE_MANAGER_21 f_21 = new F_CUSTOMIZE_MANAGER_21();
            f_21.TopLevel = false;
            pnl_load_form_18.Controls.Add(f_21);
            f_21.Show();
        }

        private void b_about_18_Click(object sender, EventArgs e)
        {
            about_18 = true;
            timer_checked_18.Enabled = true;

            b_privac_18.FillColor = pnl_manager_18.BackColor;
            b_privac_18.BorderColor = Color.CornflowerBlue;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = Color.CornflowerBlue;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = Color.CornflowerBlue;
            b_about_18.FillColor = this.BackColor;
            b_about_18.BorderColor = Color.Thistle;
        }

        private void F_SETTINGS_MANAGER_18_Load(object sender, EventArgs e)
        {
            b_privac_18.HoverState.FillColor = b_privac_18.FillColor;
            b_privac_18.PressedColor = b_privac_18.FillColor;
            b_shape_1.HoverState.FillColor = b_shape_1.FillColor;
            b_shape_1.PressedColor = b_shape_1.FillColor;
            b_acc_emp_18.HoverState.FillColor = b_acc_emp_18.FillColor;
            b_acc_emp_18.PressedColor = b_acc_emp_18.FillColor;
            b_customize_18.HoverState.FillColor = b_customize_18.FillColor;
            b_customize_18.PressedColor = b_customize_18.FillColor;
            b_about_18.HoverState.FillColor = b_about_18.FillColor;
            b_about_18.PressedColor = b_about_18.FillColor;
            /////
            b_privac_18.FillColor = this.BackColor;
            b_privac_18.BorderColor = Color.Thistle;
            b_acc_emp_18.FillColor = pnl_manager_18.BackColor;
            b_acc_emp_18.BorderColor = Color.CornflowerBlue;
            b_customize_18.FillColor = pnl_manager_18.BackColor;
            b_customize_18.BorderColor = Color.CornflowerBlue;
            b_about_18.FillColor = pnl_manager_18.BackColor;
            b_about_18.BorderColor = Color.CornflowerBlue;
            ////
            pnl_load_form_18.Controls.Clear();
            F_PRIVACY_MANAGER_20 f_20 = new F_PRIVACY_MANAGER_20();
            f_20.TopLevel = false;
            pnl_load_form_18.Controls.Add(f_20);
            f_20.Show();
            ////
            fresh = 1;
        }
        private void timer_checked_18_Tick(object sender, EventArgs e)
        {
            if (privac_18 == true)
            {
                pnl_checked_18.MinimumSize = b_privac_18.MaximumSize;
                pnl_checked_18.Height -= 40;
                if (pnl_checked_18.Height == b_privac_18.MaximumSize.Height)
                {
                    timer_checked_18.Stop();
                    privac_18 = false;
                    if (fresh == 2)
                    {
                        b_acc_emp_18.UseTransparentBackground = true;
                    }
                    if (fresh == 3)
                    {
                        b_customize_18.UseTransparentBackground = true;
                    }
                    if (fresh == 4)
                    {
                        b_about_18.UseTransparentBackground = true;
                    }
                    fresh = 1;
                }
            }
            ////
            if (acc_emp_18 == true)
            {
                if (pnl_checked_18.Height > b_acc_emp_18.MaximumSize.Height)
                {
                    pnl_checked_18.MinimumSize = b_acc_emp_18.MinimumSize;
                    pnl_checked_18.Height -= 40;
                    if (pnl_checked_18.Height == b_acc_emp_18.MaximumSize.Height)
                    {
                        pnl_checked_18.Height = b_acc_emp_18.MinimumSize.Height;
                        timer_checked_18.Stop();
                        acc_emp_18 = false;
                        if (fresh == 1)
                        {
                            b_privac_18.UseTransparentBackground = true;
                        }
                        if (fresh == 3)
                        {
                            b_customize_18.UseTransparentBackground = true;
                        }
                        if (fresh == 4)
                        {
                            b_about_18.UseTransparentBackground = true;
                        }
                        fresh = 2;
                    }
                }
                if (pnl_checked_18.Height < b_acc_emp_18.MaximumSize.Height)
                {
                    pnl_checked_18.MaximumSize = b_acc_emp_18.MaximumSize;
                    pnl_checked_18.Height += 40;
                    if (pnl_checked_18.Height == b_acc_emp_18.MaximumSize.Height)
                    {
                        timer_checked_18.Stop();
                        acc_emp_18 = false;
                        if (fresh == 1)
                        {
                            b_privac_18.UseTransparentBackground = true;
                        }
                        if (fresh == 3)
                        {
                            b_customize_18.UseTransparentBackground = true;
                        }
                        if (fresh == 4)
                        {
                            b_about_18.UseTransparentBackground = true;
                        }
                        fresh = 2;
                    }
                }
            }
            ////
            if (customize_18 == true)
            {
                if (pnl_checked_18.Height > b_customize_18.MaximumSize.Height)
                {
                    pnl_checked_18.MinimumSize = b_customize_18.MinimumSize;
                    pnl_checked_18.Height -= 40;
                    if (pnl_checked_18.Height == b_customize_18.MaximumSize.Height)
                    {
                        pnl_checked_18.Height = b_customize_18.MinimumSize.Height;
                        timer_checked_18.Stop();
                        customize_18 = false;
                        if (fresh == 1)
                        {
                            b_privac_18.UseTransparentBackground = true;
                        }
                        if (fresh == 2)
                        {
                            b_acc_emp_18.UseTransparentBackground = true;
                        }
                        if (fresh == 4)
                        {
                            b_about_18.UseTransparentBackground = true;
                        }
                        fresh = 3;
                    }
                }
                if (pnl_checked_18.Height < b_customize_18.MaximumSize.Height)
                {
                    pnl_checked_18.MaximumSize = b_customize_18.MaximumSize;
                    pnl_checked_18.Height += 40;
                    if (pnl_checked_18.Height == b_customize_18.MaximumSize.Height)
                    {
                        timer_checked_18.Stop();
                        customize_18 = false;
                        if (fresh == 1)
                        {
                            b_privac_18.UseTransparentBackground = true;
                        }
                        if (fresh == 2)
                        {
                            b_acc_emp_18.UseTransparentBackground = true;
                        }
                        if (fresh == 4)
                        {
                            b_about_18.UseTransparentBackground = true;
                        }
                        fresh = 3;
                    }
                }
            }
            ////
            if (about_18 == true)
            {
                pnl_checked_18.MaximumSize = b_about_18.MaximumSize;
                pnl_checked_18.Height += 40;
                if (pnl_checked_18.Height == b_about_18.MaximumSize.Height)
                {
                    timer_checked_18.Stop();
                    about_18 = false;
                    if (fresh == 1)
                    {
                        b_privac_18.UseTransparentBackground = true;
                    }
                    if (fresh == 2)
                    {
                        b_acc_emp_18.UseTransparentBackground =     true;
                    }
                    if (fresh == 3)
                    {
                        b_customize_18.UseTransparentBackground = true;
                    }
                    fresh = 4;
                }
            }

        }

        private void b_cover_2_Click(object sender, EventArgs e)
        {

        }

        private void pnl_manager_18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_shape_1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_checked_18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_cover_1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
