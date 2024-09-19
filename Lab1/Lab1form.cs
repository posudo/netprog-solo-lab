using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai1;

namespace Lab1
{
    public partial class Lab1form : Form
    {
        public Lab1form()
        {
            InitializeComponent();
        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1Form newBai1Form = new Bai1Form();
            newBai1Form.Show();
        }
    }
}
