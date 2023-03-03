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
    public partial class F_LOGO_1 : Form
    {
        //"انشاء متغير لعدد الثواني"
        private int _ticks;
       
        
        public F_LOGO_1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //"عند تحميل الفورم تبدا الثواني بالعد"
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //" تفعيل حدث الثواني من اجل الانتقال لفورم تسجيل الدخول بعد 5 ثواني من تحميل الفورم الاساسي"
            _ticks++;
            if (_ticks == 3)
            {
                timer1.Stop();
                F_LOGIN_SIGNUP_2 f_2 = new F_LOGIN_SIGNUP_2();
                f_2.ShowDialog();
                
            }
        }
    }
}
