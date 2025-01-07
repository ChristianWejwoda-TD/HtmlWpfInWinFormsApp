using Microsoft.Win32;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices.ComTypes;

namespace WpfControlsLibrary
{
    /// <summary>
    /// Interaction logic for HtmlEditor.xaml
    /// </summary>
    public partial class HtmlEditor : UserControl
    {
        public HtmlEditor()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWX5ecnRcRmRcVkV2WkA=");

            InitializeComponent();

            
        }
        public void LoadFile(string fileName)
        {
            // Loads the file into RichTextBoxAdv.
            string dateiInhalt = System.IO.File.ReadAllText(fileName);
            if (!dateiInhalt.StartsWith("<html>"))
            {
                dateiInhalt = $"<html><title></title><body>{dateiInhalt}</body></html>";
            }
            richTextBoxAdv.HtmlText = dateiInhalt;

            //richTextBoxAdv.Load(fileName);
            // Sets the File name as Document Title.
            richTextBoxAdv.DocumentTitle = System.IO.Path.GetFileNameWithoutExtension(fileName);

        }

        public void SaveFile(string fileName)
        {
            //if (!File.Exists(fileName))
            //{
            //    File.Create(fileName);
            //}
            StreamWriter objReader = new StreamWriter(fileName, false, Encoding.Default);
            objReader.Write(richTextBoxAdv.HtmlText);
            objReader.Close();

           //var f = System.IO.File.OpenWrite(v);
           // f.Write(richTextBoxAdv.HtmlText,0, richTextBoxAdv.HtmlText.Length);
        }
    }
}
