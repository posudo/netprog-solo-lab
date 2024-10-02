using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai1;
using Bai2;
using Bai3;
using Bai6;
using Bai7;
using Bai9;
using Bai8;
using Bai5;

namespace Lab1
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1Form newBai1Form = new Bai1Form();
            newBai1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2Form newBai2Form = new Bai2Form();
            newBai2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3Form newBai3Form = new Bai3Form();
            newBai3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai6Form newBai6Form = new Bai6Form();
            newBai6Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai7Form newBai7Form = new Bai7Form();
            newBai7Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai9Form newBai9Form = new Bai9Form();
            newBai9Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai8Form newBai8Form = new Bai8Form();
            newBai8Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai5Form newBai5Form = new Bai5Form();
            newBai5Form.Show();
        }
    }
}
