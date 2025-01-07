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

namespace HtmlWpfInWinForms
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateiname = Path.Combine(Path.GetDirectoryName( Application.ExecutablePath), "test.html");
            if (File.Exists(dateiname))
            {
                htmlEditor1.LoadFile(dateiname);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            htmlEditor1.SaveFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "test.html"));
        }
    }
}
