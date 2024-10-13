using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_bai05 : Form
    {

        private Dictionary<string, List<string>> DuLieuPhim;
        private Dictionary<string, int> GiaVe;
        private Dictionary<string, List<float>> ThongTinThem;
        private List<string> VeDat = new List<string>();
        private int TienVeTam;
        
        public Lab02_bai05()
        {
            InitializeComponent();
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            checkedListBox5.ItemCheck += checkedListBox5_ItemCheck;
            checkedListBox4.ItemCheck += checkedListBox4_ItemCheck;
            checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ticket_uncheck(CheckedListBox a)
        {
            if (a.CheckedItems.Count == 0) return;
            for (int i = 0; i < a.Items.Count; i++)
            {
                
                a.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticket_uncheck(checkedListBox1);
            ticket_uncheck(checkedListBox2);
            ticket_uncheck(checkedListBox3);
            ticket_uncheck(checkedListBox4);
            ticket_uncheck(checkedListBox5);

            TienVeTam = 0;
            label15.Text = $"{TienVeTam}₫";

            comboBox2.Items.Clear();

            foreach (string phong_chieu in DuLieuPhim[comboBox1.SelectedItem.ToString()])
            {
                comboBox2.Items.Add(phong_chieu);
            }
        }

        private void Lab02_Bai05_Load(object sender, EventArgs e)
        {
            TienVeTam = 0;
            label15.Text = $"{TienVeTam}₫";
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim trước (-_-')");
                e.NewValue = CheckState.Unchecked;
                return;
            }

            if (e.NewValue == CheckState.Checked)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()] / 4;
                VeDat.Add(checkedListBox2.Items[e.Index].ToString());
            }
            else
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()] / 4;
                VeDat.Remove(checkedListBox2.Items[e.Index].ToString());
            }
            label15.Text = $"{TienVeTam}₫";
        }
        private void checkedListBox5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim trước (-_-')");
                e.NewValue = CheckState.Unchecked;
                return;
            }

            if (e.NewValue == CheckState.Checked)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()] / 4;
                VeDat.Add(checkedListBox5.Items[e.Index].ToString());
            }
            else
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()] / 4;
                VeDat.Remove(checkedListBox5.Items[e.Index].ToString());
            }
            label15.Text = $"{TienVeTam}₫";
        }
        private void checkedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim trước (-_-')");
                e.NewValue = CheckState.Unchecked;
                return;
            }

            if (e.NewValue == CheckState.Checked && e.Index != 1)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()];
                VeDat.Add(checkedListBox4.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked && e.Index != 1)
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()];
                VeDat.Remove(checkedListBox4.Items[e.Index].ToString());
            }

            if (e.NewValue == CheckState.Checked && e.Index == 1)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()] * 2;
                VeDat.Add("B2");
            }
            else if (e.NewValue == CheckState.Unchecked && e.Index == 1)
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()] * 2;
                VeDat.Remove("B2");
            }

            label15.Text = $"{TienVeTam}₫";
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim trước (-_-')");
                e.NewValue = CheckState.Unchecked;
                return;
            }

            if (e.NewValue == CheckState.Checked && e.Index != 1)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()];
                VeDat.Add(checkedListBox1.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked && e.Index != 1)
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()];
                VeDat.Remove(checkedListBox1.Items[e.Index].ToString());
            }

            if (e.NewValue == CheckState.Checked && e.Index == 1)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()] * 2;
                VeDat.Add("B3");
            }
            else if (e.NewValue == CheckState.Unchecked && e.Index == 1)
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()] * 2;
                VeDat.Remove("B3");
            }

            label15.Text = $"{TienVeTam}₫";
        }
        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim trước (-_-')");
                e.NewValue = CheckState.Unchecked;
                return;
            }

            if (e.NewValue == CheckState.Checked && e.Index != 1)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()];
                VeDat.Add(checkedListBox3.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked && e.Index != 1)
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()];
                VeDat.Remove(checkedListBox3.Items[e.Index].ToString());
            }

            if (e.NewValue == CheckState.Checked && e.Index == 1)
            {
                TienVeTam += GiaVe[comboBox1.SelectedItem.ToString()] * 2;
                VeDat.Add("B4");
            }
            else if (e.NewValue == CheckState.Unchecked && e.Index == 1)
            {
                TienVeTam -= GiaVe[comboBox1.SelectedItem.ToString()] * 2;
                VeDat.Remove("B4");
            }

            label15.Text = $"{TienVeTam}₫";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString()==""||comboBox1.SelectedItem == null|| comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin (-_-')");
                return;
            }
            
            if(TienVeTam==0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế (-_-')");
                return;
            }

            string Ve = string.Join(", ", VeDat);
            
            MessageBox.Show($"Đặt vé thành công!\r\n" +
                $"Họ và tên: {textBox1.Text.ToString()}\r\n" +
                $"Phim: {comboBox1.SelectedItem.ToString()}\r\n" +
                $"Vé: {Ve}   Phòng chiếu: {comboBox2.SelectedItem.ToString()}\r\n" +
                $"Thành tiền: {TienVeTam}₫");
            ThongTinThem[comboBox1.SelectedItem.ToString()][0] += VeDat.Count;
            ThongTinThem[comboBox1.SelectedItem.ToString()][1] -= VeDat.Count;
            ThongTinThem[comboBox1.SelectedItem.ToString()][2] += TienVeTam;




        }
        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DuLieuPhim = new Dictionary<string, List<string>>();
            GiaVe = new Dictionary<string, int>();
            ThongTinThem = new Dictionary<string, List<float>>();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.DefaultExt = "txt";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                string movieName = parts[0];
                List<string> phong_chieu = new List<string>();
                List<float> thong_tin_them = new List<float>();

                for (int i = 1; i < 4; i++)
                {
                    float tt_them = float.Parse(parts[i]); 
                    thong_tin_them.Add(tt_them);
                }

                for (int i = 4; i < parts.Length - 1; i++)
                {
                    phong_chieu.Add(parts[i]);
                }
                int price = int.Parse(parts[parts.Length - 1]);

                DuLieuPhim.Add(movieName, phong_chieu);
                GiaVe.Add(movieName, price);
                ThongTinThem.Add(movieName, thong_tin_them);
                comboBox1.Items.Add(movieName);
            }
           
            sr.Close();
            fs.Close();
        }

        private int rankRevenue(float doanh_thu)
        {
            int curr_rank = 1;
            foreach (var movie in ThongTinThem)
            {
                if (doanh_thu < movie.Value[2])
                {
                    curr_rank++;
                }
            }
            return curr_rank;    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string movieName = comboBox1.SelectedItem.ToString();
            if (movieName=="")
            {
                MessageBox.Show("Vui lòng chọn phim cần lưu (-_-')");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            
            sw.WriteLine("Số vé bán ra: "+ ThongTinThem[movieName][0]);
            sw.WriteLine("Số vé tồn: " + ThongTinThem[movieName][1]);
            sw.WriteLine("Tỉ lệ vé bán ra: " + ThongTinThem[movieName][0] / ThongTinThem[movieName][1]);
            sw.WriteLine("Doanh thu phim: " + ThongTinThem[movieName][2]);
            sw.WriteLine("Xếp hạng doanh thu phim: " + rankRevenue(ThongTinThem[movieName][2]+ '₫'));
            sw.WriteLine("VUI LÒNG CẬP NHẬT THÔNG TIN VÉ BÁN RA, VÉ TỒN, DOANH THU MỚI CỦA PHIM VÀO FILE LƯU DANH SÁCH PHIM");
                
            sw.Close();
            fs.Close();

        }
    }
}
