namespace Tyuiu.KhabibullinMR.Sprint6.Task6.V2
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
            buttonDone_KMR = new Button();
            buttonOpen_Click = new Button();
            panelMid_KMR = new Panel();
            groupBoxCondition_KMR = new GroupBox();
            labelOut_KMR = new Label();
            labelIn_KMR = new Label();
            textBoxCondition_KMR = new TextBox();
            textBoxOut_KMR = new TextBox();
            textBoxIn_KMR = new TextBox();
            openFileDialogTask_KMR = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panelTop_KMR.SuspendLayout();
            panelMid_KMR.SuspendLayout();
            groupBoxCondition_KMR.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_KMR
            // 
            panelTop_KMR.Controls.Add(buttonHelp_KMR);
            panelTop_KMR.Controls.Add(buttonDone_KMR);
            panelTop_KMR.Controls.Add(buttonOpen_Click);
            panelTop_KMR.Dock = DockStyle.Top;
            panelTop_KMR.Location = new Point(0, 0);
            panelTop_KMR.Name = "panelTop_KMR";
            panelTop_KMR.Size = new Size(784, 68);
            panelTop_KMR.TabIndex = 0;
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.BackColor = SystemColors.ActiveCaption;
            buttonHelp_KMR.FlatStyle = FlatStyle.Flat;
            buttonHelp_KMR.Location = new Point(706, 6);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(75, 59);
            buttonHelp_KMR.TabIndex = 1;
            buttonHelp_KMR.Text = "Справка";
            buttonHelp_KMR.UseVisualStyleBackColor = false;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.Enabled = false;
            buttonDone_KMR.Location = new Point(140, 3);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(90, 59);
            buttonDone_KMR.TabIndex = 0;
            buttonDone_KMR.Text = "Выполнить";
            toolTip1.SetToolTip(buttonDone_KMR, "Выполнить отработку");
            buttonDone_KMR.UseVisualStyleBackColor = true;
            buttonDone_KMR.Click += buttonDone_Click;
            // 
            // buttonOpen_Click
            // 
            buttonOpen_Click.Location = new Point(12, 3);
            buttonOpen_Click.Name = "buttonOpen_Click";
            buttonOpen_Click.Size = new Size(90, 59);
            buttonOpen_Click.TabIndex = 0;
            buttonOpen_Click.Text = "Выбрать файл";
            toolTip1.SetToolTip(buttonOpen_Click, "Открыть файл\r\nВыберите нужный файл для отработки");
            buttonOpen_Click.UseVisualStyleBackColor = true;
            buttonOpen_Click.Click += buttonOpenFile_Click;
            // 
            // panelMid_KMR
            // 
            panelMid_KMR.Controls.Add(groupBoxCondition_KMR);
            panelMid_KMR.Dock = DockStyle.Fill;
            panelMid_KMR.Location = new Point(0, 68);
            panelMid_KMR.Name = "panelMid_KMR";
            panelMid_KMR.Size = new Size(784, 343);
            panelMid_KMR.TabIndex = 1;
            // 
            // groupBoxCondition_KMR
            // 
            groupBoxCondition_KMR.Controls.Add(labelOut_KMR);
            groupBoxCondition_KMR.Controls.Add(labelIn_KMR);
            groupBoxCondition_KMR.Controls.Add(textBoxCondition_KMR);
            groupBoxCondition_KMR.Controls.Add(textBoxOut_KMR);
            groupBoxCondition_KMR.Controls.Add(textBoxIn_KMR);
            groupBoxCondition_KMR.Dock = DockStyle.Fill;
            groupBoxCondition_KMR.Location = new Point(0, 0);
            groupBoxCondition_KMR.Name = "groupBoxCondition_KMR";
            groupBoxCondition_KMR.Size = new Size(784, 343);
            groupBoxCondition_KMR.TabIndex = 0;
            groupBoxCondition_KMR.TabStop = false;
            groupBoxCondition_KMR.Text = "Условие";
            // 
            // labelOut_KMR
            // 
            labelOut_KMR.AutoSize = true;
            labelOut_KMR.Location = new Point(402, 67);
            labelOut_KMR.Name = "labelOut_KMR";
            labelOut_KMR.Size = new Size(42, 15);
            labelOut_KMR.TabIndex = 3;
            labelOut_KMR.Text = "Вывод";
            // 
            // labelIn_KMR
            // 
            labelIn_KMR.AutoSize = true;
            labelIn_KMR.Location = new Point(12, 66);
            labelIn_KMR.Name = "labelIn_KMR";
            labelIn_KMR.Size = new Size(33, 15);
            labelIn_KMR.TabIndex = 3;
            labelIn_KMR.Text = "Ввод";
            // 
            // textBoxCondition_KMR
            // 
            textBoxCondition_KMR.BorderStyle = BorderStyle.None;
            textBoxCondition_KMR.Location = new Point(6, 22);
            textBoxCondition_KMR.Multiline = true;
            textBoxCondition_KMR.Name = "textBoxCondition_KMR";
            textBoxCondition_KMR.ReadOnly = true;
            textBoxCondition_KMR.Size = new Size(778, 42);
            textBoxCondition_KMR.TabIndex = 2;
            textBoxCondition_KMR.Text = resources.GetString("textBoxCondition_KMR.Text");
            // 
            // textBoxOut_KMR
            // 
            textBoxOut_KMR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxOut_KMR.Location = new Point(402, 84);
            textBoxOut_KMR.Multiline = true;
            textBoxOut_KMR.Name = "textBoxOut_KMR";
            textBoxOut_KMR.ReadOnly = true;
            textBoxOut_KMR.ScrollBars = ScrollBars.Vertical;
            textBoxOut_KMR.Size = new Size(376, 259);
            textBoxOut_KMR.TabIndex = 1;
            // 
            // textBoxIn_KMR
            // 
            textBoxIn_KMR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_KMR.Location = new Point(12, 84);
            textBoxIn_KMR.Multiline = true;
            textBoxIn_KMR.Name = "textBoxIn_KMR";
            textBoxIn_KMR.ReadOnly = true;
            textBoxIn_KMR.ScrollBars = ScrollBars.Vertical;
            textBoxIn_KMR.Size = new Size(384, 256);
            textBoxIn_KMR.TabIndex = 0;
            // 
            // openFileDialogTask_KMR
            // 
            openFileDialogTask_KMR.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panelMid_KMR);
            Controls.Add(panelTop_KMR);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 2 | Хабибуллин М. Р.";
            panelTop_KMR.ResumeLayout(false);
            panelMid_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KMR;
        private Button buttonDone_KMR;
        private Button buttonOpen_Click;
        private ToolTip toolTip1;
        private Panel panelMid_KMR;
        private OpenFileDialog openFileDialogTask_KMR;
        private Button buttonHelp_KMR;
        private GroupBox groupBoxCondition_KMR;
        private TextBox textBoxCondition_KMR;
        private TextBox textBoxOut_KMR;
        private TextBox textBoxIn_KMR;
        private Label labelOut_KMR;
        private Label labelIn_KMR;
    }
}
