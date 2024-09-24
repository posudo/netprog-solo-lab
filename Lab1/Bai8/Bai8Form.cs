using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_8
{
    public partial class Bai8Form : Form
    {
        public Bai8Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userSelected = comboBox1.Text.ToString();
            string[] DuLieuSV = textBox1.Text.Split(',');
            int SoMon = DuLieuSV.Length - 1;
            float[] DiemSV = new float[SoMon];
            if (!float.TryParse(DuLieuSV[0].Trim(), out _))
            {
                MessageBox.Show("Tên sinh viên không được là số (-_-')");
                return;
            }

            for (int i = 0; i < SoMon; i++)
            {
                float Diem;
                if (!float.TryParse(DuLieuSV[i + 1], out Diem) || Diem < 0)
                {
                    MessageBox.Show("Vui lòng nhập số thực không âm cho điểm (-_-')");
                    return;
                }
                else DiemSV[i] = Diem;
            }
            if (userSelected.Equals("Xem thông tin sinh viên"))
            {
                
                string ThongTin = "";
                int index_diem = 1;
                ThongTin += $"Họ và tên: {DuLieuSV[0]}\n";

                foreach(int diem_mon in DiemSV)
                {
                    ThongTin += $"Môn {index_diem}: {diem_mon}  ";
                }
                

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
