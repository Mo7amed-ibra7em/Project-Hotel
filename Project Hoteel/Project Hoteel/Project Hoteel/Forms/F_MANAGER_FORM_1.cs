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
        #region متغيرات
        bool but1 = false;
        bool but2 = false;
        bool but3 = false;
        bool but4 = false;
        bool but5 = false;

        int animated = 0;
        #endregion
        public F_MANAGER_FORM_1()
        {
            InitializeComponent();
        }

        private void b_emp_account_1_Click(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l2.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height == l1.MaximumSize.Height || pnl_scroll_2.Height == l3.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_1.Start();
            }
            else if (pnl_scroll_2.Height >= l4.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_1.Start();
            }
            ///
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_emp_account_1.BackColor = f_1.BackColor;
            b_control_board_1.BackColor = pnl_manager_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            ////
            pnl_load_form_1.Controls.Clear();
            F_EMP_ACCOUNT_4 f_4 = new F_EMP_ACCOUNT_4();
            f_4.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_4);
            f_4.Show();
        }
        private void b_custom_account_1_Click(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l3.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height <= l2.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_1.Start();
            }
            else if (pnl_scroll_2.Height >= l4.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_1.Start();
            }
            ////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_custom_account_1.BackColor = f_1.BackColor;
            b_control_board_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            ////
            pnl_load_form_1.Controls.Clear();
            F_CUSTOM_ACCOUNT_14 f_14 = new F_CUSTOM_ACCOUNT_14();
            f_14.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_14);
            f_14.Show();
        }
        private void b_control_board_1_Click_1(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l1.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height <= l3.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_1.Start();
            }
            else if (pnl_scroll_2.Height >= l4.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_1.Start();
            }
            ////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_control_board_1.BackColor = f_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            ////
            pnl_load_form_1.Controls.Clear();
            F_DASHBOARD_3 f_3 = new F_DASHBOARD_3();
            f_3.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_3);
            f_3.Show();
        }
        private void b_settings_1_Click(object sender, EventArgs e)
        {
            but5 = true;
            b_scroll.ShadowDecoration.Enabled = false;
            animated = pnl_scroll_2.MaximumSize.Height / 2;
            timer_liner_1.Start();
            ////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_settings_1.BackColor = f_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_control_board_1.BackColor = pnl_manager_1.BackColor;
            ////
            pnl_load_form_1.Controls.Clear();
            F_SETTINGS_MANAGER_18 f_18 = new F_SETTINGS_MANAGER_18();
            f_18.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_18);
            f_18.Show();
        }
        private void F_MANAGER_FORM_1_Load(object sender, EventArgs e)
        {
            Class_Forms.Login_2.C_LOGIN_2 c_2 = new Class_Forms.Login_2.C_LOGIN_2();
            l_user_name_1.Text = Class_Forms.Login_2.C_LOGIN_2.l_user.ToString();
            /////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_control_board_1.BackColor = f_1.BackColor;
            b_custom_account_1.BackColor = pnl_manager_1.BackColor;
            b_emp_account_1.BackColor = pnl_manager_1.BackColor;
            b_settings_1.BackColor = pnl_manager_1.BackColor;
            //////
            pnl_load_form_1.Controls.Clear();
            F_DASHBOARD_3 f_3 = new F_DASHBOARD_3();
            f_3.TopLevel = false;
            pnl_load_form_1.Controls.Add(f_3);
            f_3.Show();
        }
        private void b_close_1_Click(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l4.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height == l5.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_1.Start();
            }
            else if (pnl_scroll_2.Height <= l3.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_1.Start();
            }
            
        }
        private void timer_liner_1_Tick(object sender, EventArgs e)
        {
            if (but1 == true)
            {
                pnl_scroll_2.MinimumSize = l1.MaximumSize;
                if (animated == 0)
                {
                    pnl_scroll_2.MaximumSize = l1.MaximumSize;
                    //b_scroll.Height -= 10;
                    pnl_scroll_2.Height += 3;
                    ///
                    if (pnl_scroll_2.Height == l1.MaximumSize.Height)
                    {
                        timer_liner_1.Stop();
                        but1 = false;
                        b_scroll.ShadowDecoration.Enabled = true;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll_2.MinimumSize = l1.MaximumSize;
                    if (pnl_scroll_2.Height >= animated)
                    {
                        b_scroll.Height += 1;
                        pnl_scroll_2.Height -= 20;
                    }
                    else
                    {
                        b_scroll.Height -= 20;
                        pnl_scroll_2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll_2.Height == l1.MaximumSize.Height)
                    {
                        timer_liner_1.Stop();
                        but1 = false;
                        b_scroll.ShadowDecoration.Enabled = true;
                    }
                }
            }
            ////
            if (but2 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll_2.MaximumSize = l2.MaximumSize;
                    pnl_scroll_2.Height += 3;
                    ///
                    if (pnl_scroll_2.Height == l2.MaximumSize.Height)
                    {
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_liner_1.Stop();
                        but2 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll_2.MinimumSize = l2.MaximumSize;
                    if (pnl_scroll_2.Size.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll_2.Height -= 20;
                    }
                    else
                    {
                        b_scroll.Height -= 20;
                        pnl_scroll_2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll_2.Height == l2.MaximumSize.Height)
                    {
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_liner_1.Stop();
                        but2 = false;
                    }
                }
            }
            ////
            if (but3 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll_2.MaximumSize = l3.MaximumSize;
                    //b_scroll.Height -= 10;
                    pnl_scroll_2.Height += 3;
                    ///
                    if (pnl_scroll_2.Height == l3.MaximumSize.Height)
                    {
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_liner_1.Stop();
                        but3 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll_2.MinimumSize = l3.MaximumSize;
                    if (pnl_scroll_2.Height >= animated)
                    {
                        b_scroll.Height += 1;
                        pnl_scroll_2.Height -= 20;
                    }
                    else
                    {
                        b_scroll.Height -= 20;
                        pnl_scroll_2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll_2.Height == l3.MaximumSize.Height)
                    {
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_liner_1.Stop();
                        but3 = false;
                    }
                }
            }
            ////
            if (but4 == true)
            {
                if (pnl_scroll_2.Height > l4.MaximumSize.Height)
                {
                    pnl_scroll_2.MinimumSize = l4.MaximumSize;
                    if (pnl_scroll_2.Height >= animated)
                    {
                        //b_scroll.Height += 1;
                        pnl_scroll_2.Height -= 7;
                    }
                    else
                    {
                        //b_scroll.Height -= 10;
                        pnl_scroll_2.Height -= 7;
                    }
                    ///
                    if (pnl_scroll_2.Height == l4.MaximumSize.Height)
                    {
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_liner_1.Stop();
                        but4 = false;
                        Application.Exit();
                    }
                }
                if (pnl_scroll_2.Height < l4.MaximumSize.Height)
                {
                    pnl_scroll_2.MaximumSize = l4.MaximumSize;
                    if (pnl_scroll_2.Size.Height >= animated)
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll_2.Height += 20;
                    }
                    else
                    {
                        b_scroll.Height += 20;
                        pnl_scroll_2.Height += 10;
                    }
                    ///
                    if (pnl_scroll_2.Height == l4.MaximumSize.Height)
                    {
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_liner_1.Stop();
                        but4 = false;
                        Application.Exit();
                    }
                }
            }
            ////
            if (but5 == true)
            {
                pnl_scroll_2.MaximumSize = l5.MaximumSize;
                if (pnl_scroll_2.Size.Height >= animated)
                {
                    b_scroll.Height -= 10;
                    pnl_scroll_2.Height += 20;
                }
                else
                {
                    b_scroll.Height += 20;
                    pnl_scroll_2.Height += 10;
                }

                if (pnl_scroll_2.Size == pnl_scroll_2.MaximumSize)
                {
                    timer_liner_1.Stop();
                    but5 = false;
                    b_scroll.ShadowDecoration.Enabled = true;
                }
            }
        }
    }
}
