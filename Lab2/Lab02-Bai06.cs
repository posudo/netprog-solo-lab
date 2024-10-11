    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Lab02_Bai06 : Form
    {
        private List<string> Foods { get; set;}
        private string filePath;
        public Lab02_Bai06()
        {
            InitializeComponent();
            Foods = new List<string> { "Bún riêu cua", "Bún bò", "Bún", "Phở", "Cơm", "Tôm", "Lê", "Không ăn gì hết!" };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chon_mon = new Random().Next(0, Foods.Count);
            textBox2.Text = Foods[chon_mon];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập món ăn (-_-')");
                return;
            }
            Foods.Add(textBox1.Text);
            ((BindingSource)listBox1.DataSource).ResetBindings(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
              

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Foods.Remove(listBox1.SelectedItem.ToString());
            ((BindingSource)listBox1.DataSource).ResetBindings(false);
        }

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = new BindingSource(Foods, null);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Foods.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.DefaultExt = "txt";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Foods.Add(line);
            }
            filePath = ofd.FileName;
            listBox1.DataSource = new BindingSource(Foods, null);
            sr.Close();
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (string food in Foods)
            {
                sw.WriteLine(food);
            }
            sw.Close();
            fs.Close();
        }
    }
}
