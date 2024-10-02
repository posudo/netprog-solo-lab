using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai3
{
    public partial class Bai3Form : Form
    {
        public Bai3Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            try
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                if (num1 < 0 || num1 > 9)
                { 
                    MessageBox.Show("Vui lòng nhập số từ 0 đến 9 (-_-')");
                    return;
                }

                string[] numArray = new string[10] { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
                textBox2.Text = numArray[num1];
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên (-_-')");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
