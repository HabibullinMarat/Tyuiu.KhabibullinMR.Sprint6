namespace Tyuiu.KhabibullinMR.Sprint6.Task3.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_KMR = new GroupBox();
            dataGridViewInput_KMR = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            groupBoxOutput_KMR = new GroupBox();
            dataGridViewOutput_KMR = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            labelOutput_KMR = new Label();
            buttonHelp = new Button();
            buttonDone_KMR = new Button();
            groupBoxCondition_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_KMR).BeginInit();
            groupBoxOutput_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KMR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KMR
            // 
            groupBoxCondition_KMR.Controls.Add(dataGridViewInput_KMR);
            groupBoxCondition_KMR.Controls.Add(textBox1);
            groupBoxCondition_KMR.Location = new Point(15, 17);
            groupBoxCondition_KMR.Name = "groupBoxCondition_KMR";
            groupBoxCondition_KMR.Size = new Size(517, 332);
            groupBoxCondition_KMR.TabIndex = 0;
            groupBoxCondition_KMR.TabStop = false;
            groupBoxCondition_KMR.Text = "Условие";
            // 
            // dataGridViewInput_KMR
            // 
            dataGridViewInput_KMR.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewInput_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_KMR.ColumnHeadersVisible = false;
            dataGridViewInput_KMR.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewInput_KMR.Location = new Point(253, 22);
            dataGridViewInput_KMR.Name = "dataGridViewInput_KMR";
            dataGridViewInput_KMR.ReadOnly = true;
            dataGridViewInput_KMR.RowHeadersVisible = false;
            dataGridViewInput_KMR.ScrollBars = ScrollBars.Vertical;
            dataGridViewInput_KMR.Size = new Size(254, 310);
            dataGridViewInput_KMR.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 50;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(241, 310);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxOutput_KMR
            // 
            groupBoxOutput_KMR.Controls.Add(dataGridViewOutput_KMR);
            groupBoxOutput_KMR.Controls.Add(labelOutput_KMR);
            groupBoxOutput_KMR.Location = new Point(538, 17);
            groupBoxOutput_KMR.Name = "groupBoxOutput_KMR";
            groupBoxOutput_KMR.Size = new Size(262, 332);
            groupBoxOutput_KMR.TabIndex = 1;
            groupBoxOutput_KMR.TabStop = false;
            groupBoxOutput_KMR.Text = "Вывод данных:";
            // 
            // dataGridViewOutput_KMR
            // 
            dataGridViewOutput_KMR.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewOutput_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KMR.ColumnHeadersVisible = false;
            dataGridViewOutput_KMR.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewOutput_KMR.Location = new Point(2, 40);
            dataGridViewOutput_KMR.Name = "dataGridViewOutput_KMR";
            dataGridViewOutput_KMR.ReadOnly = true;
            dataGridViewOutput_KMR.RowHeadersVisible = false;
            dataGridViewOutput_KMR.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutput_KMR.Size = new Size(254, 286);
            dataGridViewOutput_KMR.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Column1";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Column2";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Column3";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Column4";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Column5";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 50;
            // 
            // labelOutput_KMR
            // 
            labelOutput_KMR.AutoSize = true;
            labelOutput_KMR.Location = new Point(13, 22);
            labelOutput_KMR.Name = "labelOutput_KMR";
            labelOutput_KMR.Size = new Size(63, 15);
            labelOutput_KMR.TabIndex = 0;
            labelOutput_KMR.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(540, 365);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 55);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.BackColor = SystemColors.ActiveBorder;
            buttonDone_KMR.Location = new Point(630, 365);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(164, 55);
            buttonDone_KMR.TabIndex = 3;
            buttonDone_KMR.Text = "Выполнить";
            buttonDone_KMR.UseVisualStyleBackColor = false;
            buttonDone_KMR.Click += buttonDone_Click;
            buttonDone_KMR.MouseDown += buttonDone_MouseDown;
            buttonDone_KMR.MouseEnter += buttonDone_MouseEnter;
            buttonDone_KMR.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_KMR);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput_KMR);
            Controls.Add(groupBoxCondition_KMR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 7 | Хабибуллин М. Р.";
            Load += FormMain_Load;
            groupBoxCondition_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_KMR).EndInit();
            groupBoxOutput_KMR.ResumeLayout(false);
            groupBoxOutput_KMR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KMR;
        private GroupBox groupBoxOutput_KMR;
        private DataGridView dataGridViewInput_KMR;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dataGridViewOutput_KMR;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label labelOutput_KMR;
        private Button buttonHelp;
        private Button buttonDone_KMR;
    }
}
