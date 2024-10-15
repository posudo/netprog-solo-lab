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
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
            LoadDirectoryTree();
            treeView1.BeforeExpand += treeView1_BeforeExpand;
        }

        private void Lab02_Bai07_Load(object sender, EventArgs e)
        {

        }

        private void LoadDirectoryTree()
        {
            TreeNode rootNode;

            foreach (string drive in Directory.GetLogicalDrives())
            {
                rootNode = new TreeNode(drive);
                rootNode.Text = drive; 
                rootNode.Tag = drive;
                rootNode.Nodes.Add("...");
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes.Count == 1)
            {
                e.Node.Nodes.Clear();

                try
                {
                    string path = e.Node.Tag.ToString();
                    if (Directory.Exists(path))
                    {
                        string[] dirs = Directory.GetDirectories(path);
                        foreach (string dir in dirs)
                        {
                            TreeNode dirNode = new TreeNode(Path.GetFileName(dir));
                            dirNode.Tag = dir;
                            dirNode.Nodes.Add("...");
                            e.Node.Nodes.Add(dirNode);
                        }

                        string[] files = Directory.GetFiles(path);
                        foreach (string file in files)
                        {
                            TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                            fileNode.Tag = file;
                            e.Node.Nodes.Add(fileNode);
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Bạn không có quyền truy cập file này (-_-') ");
                }

                e.Node.Expand();
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string path = selectedNode.Tag.ToString();
            try
            {
                if (File.Exists(path))
                {
                    string extension = Path.GetExtension(path).ToLower();

                    if (extension == ".txt")
                    {
                        FileStream fs = new FileStream(path, FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        textBox1.Text = sr.ReadToEnd();
                        pictureBox1.Visible = false;
                        sr.Close();
                        fs.Close();
                    }
                    else if (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
                    {
                        pictureBox1.Image = Image.FromFile(path);
                        textBox1.Clear();
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        textBox1.Text = "Không xem được file này (-_-')";
                        pictureBox1.Visible = false;
                    }

                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập file này (-_-') ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
