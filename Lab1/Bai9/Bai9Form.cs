using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Bai9Form : Form
    {
        List<string> Foods = new List<string> { "Bún riêu cua","Bún bò","Bún","Phở","Cơm","Tôm","Lê","Không ăn gì hết!" };
        public Bai9Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foods.Add(textBox1.Text);
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
        }

        private void Bai9Form_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = new BindingSource(Foods, null);
        }
    }
}
