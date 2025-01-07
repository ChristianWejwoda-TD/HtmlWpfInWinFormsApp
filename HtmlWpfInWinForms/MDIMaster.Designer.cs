namespace HtmlWpfInWinForms
{
    partial class MDIMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMaster));
            this.SuspendLayout();
            // 
            // MDIMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2011, 1100);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "MDIMaster";
            this.Text = "MDIMaster";
            this.Activated += new System.EventHandler(this.MDIMaster_Activated);
            this.Load += new System.EventHandler(this.MDIMaster_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MDIMaster_ClientSizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}