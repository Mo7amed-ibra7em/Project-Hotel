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
    public partial class F_USER_3 : Form
    {
        public F_USER_3()
        {
            InitializeComponent();
        }


        private void rb_3_Click(object sender, EventArgs e)
        {
            //"يتم تفعيل زر الراديو مجرد الضغط عليه"
            rb_3.Checked = true;
        }

        private void b_back_3_Click(object sender, EventArgs e)
        {
            //"اغلاق الفورم بالضغط على زر رجوع"
            Close();
        }

        private void b_next_3_Click(object sender, EventArgs e)
        {
            //"الانتقال للفورم 4 بشرط ان يكون زر الراديو مفعل"
            if (rb_3.Checked == true)
            {
                F_SIGN_UP_4 f_4 = new F_SIGN_UP_4();
                f_4.ShowDialog();
            }
        }

    }
}
