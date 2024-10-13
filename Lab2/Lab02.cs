using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 bai3 = new Lab02_Bai03();
            bai3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 bai4 = new Lab02_Bai04();
            bai4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_bai05 bai5 = new Lab02_bai05();
            bai5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 bai6 = new Lab02_Bai06();
            bai6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 bai7 = new Lab02_Bai07();
            bai7.ShowDialog();
        }

        private void Lab02_Load(object sender, EventArgs e)
        {

        }
    }
}
