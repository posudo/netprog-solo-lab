using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;


namespace Lab2
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }
        
        private void Lab02_Bai03_Load(object sender, EventArgs e)
        {

        }
        private List<string> results = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                NCalc.Expression express = new NCalc.Expression(line);
                object result = express.Evaluate();
                textBox1.AppendText(line + " = " + result.ToString() + Environment.NewLine);
                results.Add(line + " = " + result.ToString());
            }
            sr.Close();
            fs.Close();
        }
        
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach(string result in results)
            {
                sw.WriteLine(result);
            }
            sw.Close();
            fs.Close();

        }
    }
}
