using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
        private 
        private void Lab02_Bai03_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] tokens = line.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                int result = EvaluateExpression(tokens);
                textBox1.AppendText(result.ToString() + Environment.NewLine);

            }
        }
        private int EvaluateExpression(string[] tokens)
        {
            int result = 0;
            int index = 0;
            char operation = '+';

            foreach (string token in tokens)
            {
                if (token == "+")
                {
                    operation = '+';
                }
                else if (token == "-")
                {
                    operation = '-';
                }
                else if (token == "*")
                {
                    operation = '*';
                }
                else if (token == "/")
                {
                    operation = '/';
                }
                else
                {
                    int value = Int32.Parse(token);
                    
                        switch (operation)
                        {
                            case '+':
                                result += value;
                                break;
                            case '-':
                                result -= value;
                                break;
                            case '*':
                                result *= value;
                                break;
                            case '/':
                                result /= value;
                                break;
                        }
                    
                }
                index++;
            }
            return result;
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
