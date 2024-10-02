using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2Form : Form
    {
        public Bai2Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bai2Form_Load(object sender, EventArgs e)
        {

        }

        private void Tim_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, max_num, min_num;
            try
            {
                num1 = float.Parse(textBox1.Text.Trim());
                num2 = float.Parse(textBox2.Text.Trim());
                num3 = float.Parse(textBox3.Text.Trim());
                max_num = num1;
                min_num = num1;
                if (num2 > max_num) max_num = num2;
                if (num3 > max_num) max_num = num3;
                if (num2 < min_num) min_num = num2;
                if (num3 < min_num) min_num = num3;
                textBox4.Text = max_num.ToString();
                textBox5.Text = min_num.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số (-_-')");
            }
        }

        private void Num1_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num3_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinNum_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxNum_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
