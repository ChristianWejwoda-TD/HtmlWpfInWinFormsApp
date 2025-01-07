using HtmlWpfInWinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlWpfInWinForms
{
    public partial class MDIMaster : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMaster));


        public MDIMaster()
        {
            InitializeComponent();
        }

        private void MDIMaster_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();

        }

        private void MDIMaster_ClientSizeChanged(object sender, EventArgs e)
        {
            if (resources != null)
            {
                BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
                if (ClientSize.Height < BackgroundImage.Height || ClientSize.Width < BackgroundImage.Width)
                {
                    BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    BackgroundImageLayout = ImageLayout.Center;
                }
            }


        }

        private void MDIMaster_Activated(object sender, EventArgs e)
        {
            if(!MdiChildren.Any(x => x is Form1))
            {
                Form1 f = new Form1();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
