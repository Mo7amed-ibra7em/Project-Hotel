using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Project_Hoteel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ProgressBar1.Value += ProgressBar1.Step;
            //label1.Text = ProgressBar1.Value.ToString() + " %";
            //if(ProgressBar1.Value == 100)
            //{
            //    timer1.Stop();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    ProgressBar1.Value = 4;
        //    timer1.Start();
        }
    }
}
