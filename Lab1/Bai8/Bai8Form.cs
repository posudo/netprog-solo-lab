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
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức năng (-_-')");
                return;
            }

            string ThongTin = "";
            string userSelected = comboBox1.Text.ToString();
            string[] DuLieuSV = textBox1.Text.Split(',');
            int SoMon = DuLieuSV.Length - 1;
            float[] DiemSV = new float[SoMon];
            
            if (float.TryParse(DuLieuSV[0].Trim(), out _))
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
                int index_diem = 1;
                ThongTin += $"Họ và tên: {DuLieuSV[0]}\r\n";

                foreach(float diem_mon in DiemSV)
                {
                    ThongTin += $"Môn {index_diem}: {diem_mon}  ";
                    index_diem++;
                }
            }

            if (userSelected.Equals("Tính điểm trung bình"))
            {
                ThongTin += $"Điểm trung bình: {DiemSV.Average()}";
            }
            if (userSelected.Equals("Tìm môn điểm cao nhất, thấp nhất"))
            {
                ThongTin += $"Môn điểm cao nhất: {DiemSV.Max()}\r\nMôn điểm thấp nhất: {DiemSV.Min()}";
            }
            if (userSelected.Equals("Tìm số môn đậu, không đậu"))
            {
                int SoMonDau = 0;
                foreach(float diem_mon in DiemSV)
                {
                    if (diem_mon >= 5) SoMonDau++;
                }
                ThongTin += $"Số môn đậu: {SoMonDau}\r\nSố môn không đậu: {SoMon - SoMonDau}";
            }
            if (userSelected.Equals("Xếp loại sinh viên"))
            {
                float DTB = DiemSV.Average();
                if (DTB >= 8 && DiemSV.All(diem_mon => diem_mon >= 6.5))
                {
                    ThongTin += "Giỏi";
                }
                else if (DTB >= 6.5 && DiemSV.All(diem_mon => diem_mon >= 5))
                {
                    ThongTin += "Khá";
                }
                else if (DTB >= 5 && DiemSV.All(diem_mon => diem_mon >= 3.5))
                {
                    ThongTin += "Trung bình";
                }
                else if (DTB >= 3.5 && DiemSV.All(diem_mon => diem_mon >= 2))
                {
                    ThongTin += "Yếu";
                }
                else ThongTin += "Kém";
            }
            textBox2.Text = ThongTin;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
