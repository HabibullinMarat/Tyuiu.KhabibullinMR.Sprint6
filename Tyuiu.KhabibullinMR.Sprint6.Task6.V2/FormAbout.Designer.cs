namespace Tyuiu.KhabibullinMR.Sprint6.Task6.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout_KMR = new PictureBox();
            textBoxAbout_KMR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KMR).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_KMR
            // 
            pictureBoxAbout_KMR.Image = (Image)resources.GetObject("pictureBoxAbout_KMR.Image");
            pictureBoxAbout_KMR.Location = new Point(12, 12);
            pictureBoxAbout_KMR.Name = "pictureBoxAbout_KMR";
            pictureBoxAbout_KMR.Size = new Size(100, 126);
            pictureBoxAbout_KMR.TabIndex = 0;
            pictureBoxAbout_KMR.TabStop = false;
            // 
            // textBoxAbout_KMR
            // 
            textBoxAbout_KMR.BorderStyle = BorderStyle.None;
            textBoxAbout_KMR.Location = new Point(129, 12);
            textBoxAbout_KMR.Multiline = true;
            textBoxAbout_KMR.Name = "textBoxAbout_KMR";
            textBoxAbout_KMR.ReadOnly = true;
            textBoxAbout_KMR.ScrollBars = ScrollBars.Vertical;
            textBoxAbout_KMR.Size = new Size(243, 126);
            textBoxAbout_KMR.TabIndex = 1;
            textBoxAbout_KMR.Text = resources.GetString("textBoxAbout_KMR.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(textBoxAbout_KMR);
            Controls.Add(pictureBoxAbout_KMR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KMR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_KMR;
        private TextBox textBoxAbout_KMR;
    }
}