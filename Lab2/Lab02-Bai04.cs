using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{

    
    public partial class Lab02_Bai04 : Form
    {
        public int page;
        private List<Student> students = new List<Student>();
        
        [Serializable]
        public class Student
        {
            public string FullName { get; set; }
            public int MSSV { get; set; }
            public string PhoneNumber { get; set; }
            public float Mark1 { get; set; }
            public float Mark2 { get; set; }
            public float Mark3 { get; set; }
            public float AverageMark { get; set; }
        }
        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private void Lab02_Bai04_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()==""|| textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" ||
                textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin sinh viên (-_-')");
                return;
            }

            try
            {
                float mark1 = float.Parse(textBox4.Text);
                float mark2 = float.Parse(textBox5.Text);
                float mark3 = float.Parse(textBox6.Text);
                string phone_num = textBox3.Text.Trim();

                if (!Int32.TryParse(textBox2.Text, out int mssv) || textBox2.Text.Length != 8)
                {
                    MessageBox.Show("Sai định dạng MSSV (-_-')");
                    return;
                }

                if (phone_num[0] != '0' || phone_num.Length != 10)
                {
                    MessageBox.Show("Sai định dạng SĐT (-_-')");
                    return;
                }

                if (mark1 > 10 || mark1 < 0 || mark2 > 10 || mark2 < 0 || mark3 > 10 || mark3 < 0)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0-10 (-_-')");
                    return;
                }


                Student student = new Student
                {
                    FullName = textBox1.Text.Trim(),
                    MSSV = mssv,
                    PhoneNumber = phone_num,
                    Mark1 = mark1,
                    Mark2 = mark2,
                    Mark3 = mark3,
                };
                students.Add(student);
                MessageBox.Show("Thêm sinh viên thành công (^_^)");
            }
            catch (Exception)
            {
                MessageBox.Show("Điểm phải là số thực (-_-')");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, students);
           
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            page = -1;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.DefaultExt = "txt";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            students = (List<Student>)bf.Deserialize(fs);
            
            foreach(Student student in students)
            {
                student.AverageMark = (student.Mark1 + student.Mark2 + student.Mark3) / 3;
                richTextBox1.AppendText($"{student.FullName}\n");
                richTextBox1.AppendText($"{student.MSSV}\n");
                richTextBox1.AppendText($"{student.PhoneNumber}\n");
                richTextBox1.AppendText($"{student.Mark1}\n");
                richTextBox1.AppendText($"{student.Mark2}\n");
                richTextBox1.AppendText($"{student.Mark3}\n");
                richTextBox1.AppendText($"{student.AverageMark}\n");
                richTextBox1.AppendText("\n");
            }    

            fs.Close();
          
            StreamWriter sw = new StreamWriter("output4.txt");
            foreach (Student student in students)
            {
                sw.WriteLine($"{student.FullName}");
                sw.WriteLine($"{student.MSSV}");
                sw.WriteLine($"{student.PhoneNumber}");
                sw.WriteLine($"{student.Mark1}");
                sw.WriteLine($"{student.Mark2}");
                sw.WriteLine($"{student.Mark3}");
                sw.WriteLine($"{student.AverageMark}");
                sw.WriteLine();
            }
            sw.Close();
            button5.PerformClick();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (page == students.Count-1)
            {
                return;
            }
            page++;
            label15.Text = (page + 1).ToString();

            textBox13.Text = students[page].FullName;
            textBox12.Text = students[page].MSSV.ToString();
            textBox11.Text = students[page].PhoneNumber;
            textBox10.Text = students[page].Mark1.ToString();
            textBox9.Text = students[page].Mark2.ToString();
            textBox8.Text = students[page].Mark3.ToString();
            textBox7.Text = students[page].AverageMark.ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                return;
            }
            page--;
            label15.Text = (page + 1).ToString();

            textBox13.Text = students[page].FullName;
            textBox12.Text = students[page].MSSV.ToString();
            textBox11.Text = students[page].PhoneNumber;
            textBox10.Text = students[page].Mark1.ToString();
            textBox9.Text = students[page].Mark2.ToString();
            textBox8.Text = students[page].Mark3.ToString();
            textBox7.Text = students[page].AverageMark.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
