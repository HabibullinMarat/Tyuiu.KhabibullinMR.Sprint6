namespace Tyuiu.KhabibullinMR.Sprint6.Task7.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_KMR = new Panel();
            buttonHelp_KMR = new Button();
            buttonSave_KMR = new Button();
            buttonDone_KMR = new Button();
            buttonOpen_KMR = new Button();
            panelMid_KMR = new Panel();
            groupBoxCondition_KMR = new GroupBox();
            textBoxCondition_KMR = new TextBox();
            panelLeft_KMR = new Panel();
            dataGridViewIn_KMR = new DataGridView();
            panelRight_KMR = new Panel();
            dataGridViewOut_KMR = new DataGridView();
            openFileDialogTask_KMR = new OpenFileDialog();
            saveFileDialogSave_KMR = new SaveFileDialog();
            toolTipButton_KMR = new ToolTip(components);
            panelTop_KMR.SuspendLayout();
            panelMid_KMR.SuspendLayout();
            groupBoxCondition_KMR.SuspendLayout();
            panelLeft_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KMR).BeginInit();
            panelRight_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KMR).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KMR
            // 
            panelTop_KMR.Controls.Add(buttonHelp_KMR);
            panelTop_KMR.Controls.Add(buttonSave_KMR);
            panelTop_KMR.Controls.Add(buttonDone_KMR);
            panelTop_KMR.Controls.Add(buttonOpen_KMR);
            panelTop_KMR.Dock = DockStyle.Top;
            panelTop_KMR.Location = new Point(0, 0);
            panelTop_KMR.Name = "panelTop_KMR";
            panelTop_KMR.Size = new Size(800, 58);
            panelTop_KMR.TabIndex = 0;
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.BackColor = SystemColors.Control;
            buttonHelp_KMR.FlatStyle = FlatStyle.Flat;
            buttonHelp_KMR.Image = (Image)resources.GetObject("buttonHelp_KMR.Image");
            buttonHelp_KMR.Location = new Point(722, 3);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(75, 52);
            buttonHelp_KMR.TabIndex = 0;
            buttonHelp_KMR.UseVisualStyleBackColor = false;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // buttonSave_KMR
            // 
            buttonSave_KMR.BackColor = SystemColors.Control;
            buttonSave_KMR.Enabled = false;
            buttonSave_KMR.FlatStyle = FlatStyle.Flat;
            buttonSave_KMR.Image = (Image)resources.GetObject("buttonSave_KMR.Image");
            buttonSave_KMR.Location = new Point(165, 3);
            buttonSave_KMR.Name = "buttonSave_KMR";
            buttonSave_KMR.Size = new Size(75, 52);
            buttonSave_KMR.TabIndex = 0;
            buttonSave_KMR.UseVisualStyleBackColor = false;
            buttonSave_KMR.Click += buttonSave_Click;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.BackColor = SystemColors.Control;
            buttonDone_KMR.Enabled = false;
            buttonDone_KMR.FlatStyle = FlatStyle.Flat;
            buttonDone_KMR.Image = (Image)resources.GetObject("buttonDone_KMR.Image");
            buttonDone_KMR.Location = new Point(84, 3);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(75, 52);
            buttonDone_KMR.TabIndex = 0;
            buttonDone_KMR.UseVisualStyleBackColor = false;
            buttonDone_KMR.Click += buttonDone_Click;
            // 
            // buttonOpen_KMR
            // 
            buttonOpen_KMR.BackColor = SystemColors.Control;
            buttonOpen_KMR.BackgroundImageLayout = ImageLayout.None;
            buttonOpen_KMR.FlatStyle = FlatStyle.Flat;
            buttonOpen_KMR.Image = (Image)resources.GetObject("buttonOpen_KMR.Image");
            buttonOpen_KMR.Location = new Point(3, 3);
            buttonOpen_KMR.Name = "buttonOpen_KMR";
            buttonOpen_KMR.Size = new Size(75, 52);
            buttonOpen_KMR.TabIndex = 0;
            buttonOpen_KMR.UseVisualStyleBackColor = false;
            buttonOpen_KMR.Click += buttonOpen_Click;
            // 
            // panelMid_KMR
            // 
            panelMid_KMR.Controls.Add(groupBoxCondition_KMR);
            panelMid_KMR.Dock = DockStyle.Top;
            panelMid_KMR.Location = new Point(0, 58);
            panelMid_KMR.Name = "panelMid_KMR";
            panelMid_KMR.Size = new Size(800, 71);
            panelMid_KMR.TabIndex = 1;
            // 
            // groupBoxCondition_KMR
            // 
            groupBoxCondition_KMR.Controls.Add(textBoxCondition_KMR);
            groupBoxCondition_KMR.Dock = DockStyle.Fill;
            groupBoxCondition_KMR.Location = new Point(0, 0);
            groupBoxCondition_KMR.Name = "groupBoxCondition_KMR";
            groupBoxCondition_KMR.Size = new Size(800, 71);
            groupBoxCondition_KMR.TabIndex = 0;
            groupBoxCondition_KMR.TabStop = false;
            groupBoxCondition_KMR.Text = "Условие";
            // 
            // textBoxCondition_KMR
            // 
            textBoxCondition_KMR.BorderStyle = BorderStyle.None;
            textBoxCondition_KMR.Dock = DockStyle.Fill;
            textBoxCondition_KMR.Location = new Point(3, 19);
            textBoxCondition_KMR.Multiline = true;
            textBoxCondition_KMR.Name = "textBoxCondition_KMR";
            textBoxCondition_KMR.ReadOnly = true;
            textBoxCondition_KMR.Size = new Size(794, 49);
            textBoxCondition_KMR.TabIndex = 0;
            textBoxCondition_KMR.Text = resources.GetString("textBoxCondition_KMR.Text");
            // 
            // panelLeft_KMR
            // 
            panelLeft_KMR.Controls.Add(dataGridViewIn_KMR);
            panelLeft_KMR.Dock = DockStyle.Left;
            panelLeft_KMR.Location = new Point(0, 129);
            panelLeft_KMR.Name = "panelLeft_KMR";
            panelLeft_KMR.Size = new Size(410, 321);
            panelLeft_KMR.TabIndex = 2;
            // 
            // dataGridViewIn_KMR
            // 
            dataGridViewIn_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KMR.Dock = DockStyle.Fill;
            dataGridViewIn_KMR.Location = new Point(0, 0);
            dataGridViewIn_KMR.Name = "dataGridViewIn_KMR";
            dataGridViewIn_KMR.ReadOnly = true;
            dataGridViewIn_KMR.RowHeadersVisible = false;
            dataGridViewIn_KMR.Size = new Size(410, 321);
            dataGridViewIn_KMR.TabIndex = 0;
            // 
            // panelRight_KMR
            // 
            panelRight_KMR.Controls.Add(dataGridViewOut_KMR);
            panelRight_KMR.Dock = DockStyle.Right;
            panelRight_KMR.Location = new Point(416, 129);
            panelRight_KMR.Name = "panelRight_KMR";
            panelRight_KMR.Size = new Size(384, 321);
            panelRight_KMR.TabIndex = 3;
            // 
            // dataGridViewOut_KMR
            // 
            dataGridViewOut_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KMR.Dock = DockStyle.Fill;
            dataGridViewOut_KMR.Location = new Point(0, 0);
            dataGridViewOut_KMR.Name = "dataGridViewOut_KMR";
            dataGridViewOut_KMR.ReadOnly = true;
            dataGridViewOut_KMR.RowHeadersVisible = false;
            dataGridViewOut_KMR.Size = new Size(384, 321);
            dataGridViewOut_KMR.TabIndex = 0;
            // 
            // openFileDialogTask_KMR
            // 
            openFileDialogTask_KMR.FileName = "openFileDialogTask_KMR";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRight_KMR);
            Controls.Add(panelLeft_KMR);
            Controls.Add(panelMid_KMR);
            Controls.Add(panelTop_KMR);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Хабибуллин М. Р.";
            panelTop_KMR.ResumeLayout(false);
            panelMid_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.PerformLayout();
            panelLeft_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KMR).EndInit();
            panelRight_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KMR;
        private Button buttonOpen_KMR;
        private Panel panelMid_KMR;
        private Panel panelLeft_KMR;
        private Panel panelRight_KMR;
        private Button buttonHelp_KMR;
        private Button buttonSave_KMR;
        private Button buttonDone_KMR;
        private GroupBox groupBoxCondition_KMR;
        private TextBox textBoxCondition_KMR;
        private DataGridView dataGridViewIn_KMR;
        private DataGridView dataGridViewOut_KMR;
        private OpenFileDialog openFileDialogTask_KMR;
        private SaveFileDialog saveFileDialogSave_KMR;
        private ToolTip toolTipButton_KMR;
    }
}
