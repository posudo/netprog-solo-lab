using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Bai5Form : Form
    {
        private Dictionary<string, List<string>> DuLieuPhim = new Dictionary<string, List<string>>();
        private Dictionary<string, int> GiaVe = new Dictionary<string, int>();
        private List<string> VeDat = new List<string>();
        private int TienVeTam;
        
        public Bai5Form()
        {
            InitializeComponent();
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            checkedListBox5.ItemCheck += checkedListBox5_ItemCheck;
            checkedListBox4.ItemCheck += checkedListBox4_ItemCheck;
            checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            TienVeTam = 0;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            foreach (string phong_chieu in DuLieuPhim[comboBox1.SelectedItem.ToString()])
            {
                comboBox2.Items.Add(phong_chieu);
            }
        }

        private void Bai5Form_Load(object sender, EventArgs e)
        {
            DuLieuPhim.Add("Đào, phở và piano", new List<string> { "1", "2", "3" });
            DuLieuPhim.Add("Mai", new List<string> { "2", "3" });
            DuLieuPhim.Add("Gặp lại chị bầu", new List<string> { "1" });
            DuLieuPhim.Add("Tarot", new List<string> { "3" });
            GiaVe.Add("Đào, phở và piano", 45000);
            GiaVe.Add("Mai", 100000);
            GiaVe.Add("Gặp lại chị bầu", 70000);
            GiaVe.Add("Tarot", 90000);
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
                VeDat.Add(checkedListBox5.Items[e.Index].ToString());
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
            
            string Ve = string.Join(", ", VeDat);
            
            MessageBox.Show($"Đặt vé thành công!\r\n" +
                $"Họ và tên: {textBox1.Text.ToString()}\r\n" +
                $"Phim: {comboBox1.SelectedItem.ToString()}\r\n" +
                $"Vé: {Ve}   Phòng chiếu: {comboBox2.SelectedItem.ToString()}\r\n" +
                $"Thành tiền: {TienVeTam}₫");
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
    }
}
