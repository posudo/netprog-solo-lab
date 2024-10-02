using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Bai6Form : Form
    {
        public Bai6Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int num1, num2;
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn chức năng (-_-')");
                    return;
                }
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                string userSelected = comboBox1.SelectedItem.ToString();
                if (num1 < num2)
                {
                    MessageBox.Show("Số A phải lớn hơn số B (-_-')");
                    return;
                }
                if (num1 < 1 || num2 < 1)
                {
                    MessageBox.Show("Số A và số B phải lớn 0 (-_-')");
                    return;
                }
                if (userSelected.Equals("Bảng cửu chương"))
                {
                    if(num1>10||num2>10)
                    {
                        MessageBox.Show("Không có bảng cửu chương số lớn hơn 10 (-_-')");
                        return;
                    }
                    for (int i = num2; i <= num1; i++)
                    {
                        string table = "";
                        for (int j = 1; j <= 10; j++)
                        {
                            table += $"{i} x {j} = {i * j},  ";
                        }
                        table += "\r\n";
                        textBox3.Text += table;
                    }
                }
                if (userSelected.Equals("Tính toán giá trị"))
                {
                    string table = "";
                    long kq1 = 1;
                    double kq2 = 0;
                    
                    for(int i=1;i<=num1-num2;i++)
                    {
                        kq1 *= i;
                    }
                    table += $"(A-B)! = {kq1}\r\n";
                
                    for(int i=1;i<=num2;i++)
                    {
                      kq2 += Math.Pow(num1, i);
                    }
                    table += $"S = {kq2}";
                    
                    textBox3.Text = table;
                }    
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên (-_-')");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
