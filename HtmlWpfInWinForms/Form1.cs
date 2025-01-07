using System;
using System.Windows.Forms;

namespace HtmlWpfInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    treeView1.Nodes.Add($"Entry {i}");
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 u = new UserControl1() { Dock = DockStyle.Fill };
            panel1.Controls.Add(u);
        }
    }
}
