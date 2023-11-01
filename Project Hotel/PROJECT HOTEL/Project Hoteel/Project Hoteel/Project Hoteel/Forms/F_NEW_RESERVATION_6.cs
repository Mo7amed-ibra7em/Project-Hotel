using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            F_F_ADMIN_15 f_15 = new F_F_ADMIN_15();
            f_15.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_15);
            f_15.Show();
        }
        private void b_next_6_Click(object sender, EventArgs e)
        {
            NextForm();
        }
        private void NextForm()
        {
            F_ADMIN_5 f_5 = Application.OpenForms["F_ADMIN_5"] as F_ADMIN_5;
            F_NEW_RESERVATION_7 f_7 = new F_NEW_RESERVATION_7(ArrayData());
            f_7.TopLevel = false;
            f_5.pnl_load_form_5.Controls.Add(f_7);
            f_7.Show();
            f_7.BringToFront();
        }
        private string[] ArrayData()
        {
            //حساب عدد الايام
            DateTime startDate = d_date_of_entry_6.Value;
            DateTime endDate = d_exit_date_6.Value;

            int Day = (int)(endDate - startDate).TotalDays;
            ///
            string Name = t_fore_name_6.Text +" "+ t_last_name_6.Text;
            string[] array1 = new string[] {Name,t_nationality_6.Text,t_age_6.Text,t_identification_number_6.Text,t_telephone_number_6.Text,d_date_of_entry_6.Value.ToString(),d_exit_date_6.Value.ToString(),Day.ToString() };
            return array1;
        }

        private void t_last_name_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[\p{L}\p{M}\s]+$"))
            {
                e.Handled = true;
            }
        }

        private void t_telephone_number_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
