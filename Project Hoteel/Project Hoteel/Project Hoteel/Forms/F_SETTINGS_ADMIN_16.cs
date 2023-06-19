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
        #region متغيرات
        bool but1 = false;
        public bool but2 = false;
        bool but3 = false;
        bool but4 = false;
        int animated = 0;
        #endregion

        public F_SETTINGS_ADMIN_16()
        {
            InitializeComponent();
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
        }
        private void b_privacy_16_Click(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l1.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height <= l3.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_16.Start();
            }
            else if (pnl_scroll_2.Height == l4.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_16.Start();
            }
            ////
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
        }
        private void b_rooms_16_Click(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l2.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height == l1.MaximumSize.Height || pnl_scroll_2.Height == l3.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_16.Start();
            }
            else if (pnl_scroll_2.Height == l4.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_16.Start();
            }
            ////
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
        }
        private void b_customize_16_Click(object sender, EventArgs e)
        {
            if (pnl_scroll_2.Height == l3.MaximumSize.Height)
            {

            }
            else if (pnl_scroll_2.Height <= l2.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_liner_16.Start();
            }
            else if (pnl_scroll_2.Height == l4.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll_2.MaximumSize.Height / 2;
                timer_liner_16.Start();
            }
            ////
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
        }
        private void b_about_16_Click(object sender, EventArgs e)
        {
            but4 = true;
            b_scroll.ShadowDecoration.Enabled = false;
            animated = pnl_scroll_2.MaximumSize.Height / 2;
            timer_liner_16.Start();
            ////
            F_MANAGER_FORM_1 f_1 = new F_MANAGER_FORM_1();
            b_privac_16.BackColor = pnl_admin_1.BackColor;
            b_rooms_16.BackColor = pnl_admin_1.BackColor;
            b_customize_16.BackColor = pnl_admin_1.BackColor;
            b_about_16.BackColor = f_1.BackColor;
        }

        private void timer_liner_16_Tick(object sender, EventArgs e)
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
                        timer_liner_16.Stop();
                        but1 = false;
                        b_scroll.ShadowDecoration.Enabled = true;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll_2.MinimumSize = l1.MaximumSize;
                    if (pnl_scroll_2.Height >= animated)
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
                    if (pnl_scroll_2.Height == l1.MaximumSize.Height)
                    {
                        timer_liner_16.Stop();
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
                        timer_liner_16.Stop();
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
                        timer_liner_16.Stop();
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
                        timer_liner_16.Stop();
                        but3 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll_2.MinimumSize = l3.MaximumSize;
                    if (pnl_scroll_2.Height >= animated)
                    {
                        b_scroll.Height += 5;
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
                        timer_liner_16.Stop();
                        but3 = false;
                    }
                }
            }
            ////
            if (but4 == true)
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

                if (pnl_scroll_2.Size == pnl_scroll_2.MaximumSize)
                {
                    timer_liner_16.Stop();
                    but4 = false;
                    b_scroll.ShadowDecoration.Enabled = true;
                }
            }
        }
    }
}
