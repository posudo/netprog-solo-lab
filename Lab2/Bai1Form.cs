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

namespace Lab2
{
    public partial class Bai1Form : Form
    {
        public Bai1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            int[] myArray = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                myArray[i] = i;
                bw.Write(myArray[i]);
            }
            bw.Close();
        }
    }
}
