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

        private void button1_Click(object sender, EventArgs e)
        {
            F_NEW_RESERVATION_7 f_7 = new F_NEW_RESERVATION_7();
            f_7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_NEW_RESERVATION_6_Load(object sender, EventArgs e)
        {
            t_fore_name_6.Select();
        }

    }
}
