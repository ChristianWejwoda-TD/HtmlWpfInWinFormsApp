using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System.IO;
using System.Text;
using System.Windows;

namespace WpfControlsLibrary
{
    /// <summary>
    /// Represents the extension class for SfRichTextBoxAdv.
    /// </summary>
    public class SfRichTextBoxAdvExtension : SfRichTextBoxAdv
    {
        #region Fields
        bool skipUpdating = false;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the instance of SfRichTextBoxAdvExtension class.
        /// </summary>
        public SfRichTextBoxAdvExtension()
        {

            // Wires the ContentChanged event.
            this.ContentChanged += RTE_ContentChanged;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets the html text.
        /// </summary>
        public string HtmlText
        {
            get
            {
                return (string)GetValue(HtmlTextProperty);
            }
            set
            {
                SetValue(HtmlTextProperty, value);
            }
        }
        #endregion


        #region Static Dependency Properties
        /// <summary>
        /// Using as a backing store for HtmlText dependency property to enable styling, animation etc.
        /// </summary>
        public static readonly DependencyProperty HtmlTextProperty = DependencyProperty.Register("HtmlText", typeof(string), typeof(SfRichTextBoxAdvExtension), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnHtmlTextChanged)));
        #endregion

        #region Static Events
        /// <summary>
        /// Called when html text changed.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void OnHtmlTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SfRichTextBoxAdvExtension richTextBox = (SfRichTextBoxAdvExtension)obj;
            //Update the document with the HTML.
            richTextBox.UpdateDocument((string)e.NewValue);
        }
        #endregion

        #region Events
        /// <summary>
        /// Called when content changes in SfRichTextBoxAdv.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        void RTE_ContentChanged(object obj, ContentChangedEventArgs args)
        {
            if (this.Document != null)
            {
                // To skip internal updation of document on setting HtmlText property.
                skipUpdating = true;
                Stream stream = new MemoryStream();
                // Saves the document as Html Stream.
                this.Save(stream, FormatType.Html);
                stream.Position = 0;
                // Reads the stream and assigned the string to HtmlText property
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.HtmlText = reader.ReadToEnd();
                }
                skipUpdating = false;
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Updates the document.
        /// </summary>
        /// <param name="htmlText"></param>
        private void UpdateDocument(string htmlText)
        {
            // If Html text property is set internally means, skip updating the document.
            if (!skipUpdating && !string.IsNullOrEmpty(htmlText))
            {
                Stream stream = new MemoryStream();
                // Convert the Html string to byte array.
                byte[] bytes = Encoding.UTF8.GetBytes(htmlText);
                // Writes the byte array to stream.
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                //Load the Html stream.
                Load(stream, FormatType.Html);
            }
        }
        /// <summary>
        /// Disposes the instance.
        /// </summary>
        public void Dispose()
        {
            this.ContentChanged -= RTE_ContentChanged;
            ClearValue(HtmlTextProperty);
            base.Dispose();
        }
        #endregion
    }

}
