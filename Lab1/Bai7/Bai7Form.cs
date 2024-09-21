using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Bai7Form : Form
    {
        public Bai7Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day, month;
            try
            {
                day = Int32.Parse(textBox1.Text.Trim());
                month = Int32.Parse(textBox2.Text.Trim());
             switch(month)
                {
                    case 1:
                    {
                            if (day < 21 && day > 0) textBox3.Text = "Ma Kết";
                            else if (day > 20 && day < 32) textBox3.Text = "Bảo Bình";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 2:
                    {
                            if (day < 20 && day > 0) textBox3.Text = "Bảo Bình";
                            else if (day > 19 && day < 30) textBox3.Text = "Song Ngư";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 3:
                    {
                            if (day < 21 && day > 0) textBox3.Text = "Song Ngư";
                            else if (day > 20 && day < 32) textBox3.Text = "Bạch Dương";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 4:
                    {
                            if (day < 21 && day > 0) textBox3.Text = "Bạch Dương";
                            else if (day > 20 && day < 31) textBox3.Text = "Kim Ngư";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 5:
                    {
                            if (day < 22 && day > 0) textBox3.Text = "Kim Ngư";
                            else if (day > 21 && day < 32) textBox3.Text = "Song Tử";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 6:
                    {
                            if (day < 22 && day > 0) textBox3.Text = "Song Tử";
                            else if (day > 21 && day < 31) textBox3.Text = "Cự Giải";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 7:
                    {
                            if (day < 23 && day > 0) textBox3.Text = "Cự Giải";
                            else if (day > 22 && day < 32) textBox3.Text = "Sư Tử";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 8:
                    {
                            if (day < 23 && day > 0) textBox3.Text = "Sư Tử";
                            else if (day > 22 && day < 32) textBox3.Text = "Xử Nữ";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 9:
                    {
                            if (day < 24 && day > 0) textBox3.Text = "Xử Nữ";
                            else if (day > 23 && day < 31) textBox3.Text = "Thiên Bình";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 10:
                    {
                            if (day < 24 && day > 0) textBox3.Text = "Thiên Bình";
                            else if (day > 23 && day < 32) textBox3.Text = "Thần Nông";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 11:
                    {
                            if (day < 23 && day > 0) textBox3.Text = "Thần Nông";
                            else if (day > 22 && day < 31) textBox3.Text = "Nhân Mã";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    case 12:
                    {
                            if (day < 22 && day > 0) textBox3.Text = "Nhân Mã";
                            else if (day > 21 && day < 32) textBox3.Text = "Ma Kết";
                            else
                            {
                                MessageBox.Show("Ngày không hợp lệ (-_-')");
                                return;
                            }
                            break;
                    }
                    default:
                       { MessageBox.Show("Tháng không hợp lệ (-_-')");
                         return;
                       }
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
