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

namespace Bai9
{
    public partial class Bai9Form : Form
    {
        private List<string> Foods { get; set;}
        public Bai9Form()
        {
            InitializeComponent();
            LoadFoodsList();
        }
        private void LoadFoodsList()
        {
            if(File.Exists("foods.txt"))
            {
                Foods = File.ReadAllLines("foods.txt").ToList();
            }    
            else
            {
                Foods = new List<string> { "Bún riêu cua", "Bún bò", "Bún", "Phở", "Cơm", "Tôm", "Lê", "Không ăn gì hết!"};
                SaveFoodsList();
            }
            listBox1.DataSource = new BindingSource(Foods, null);
        }
        private void SaveFoodsList()
        {
            File.WriteAllLines("foods.txt", Foods);
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
            SaveFoodsList();
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
            SaveFoodsList();
            ((BindingSource)listBox1.DataSource).ResetBindings(false);
        }

        private void Bai9Form_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
