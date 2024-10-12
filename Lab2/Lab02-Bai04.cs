using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai04 : Form
    {
        private List<Student> students = new List<Student>();
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
            





        }
    }
}
