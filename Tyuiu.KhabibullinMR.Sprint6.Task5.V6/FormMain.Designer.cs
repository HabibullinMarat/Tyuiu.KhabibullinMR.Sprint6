namespace Tyuiu.KhabibullinMR.Sprint6.Task5.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelUp_KMR = new Panel();
            groupBoxButton_KMR = new GroupBox();
            buttonDone_KMR = new Button();
            buttonOpen_KMR = new Button();
            buttonHelp_KMR = new Button();
            groupBox_Condition_KMR = new GroupBox();
            textBoxCondition_KMR = new TextBox();
            panelLeft_KMR = new Panel();
            groupBoxOut_KMR = new GroupBox();
            dataGridViewNums_KMR = new DataGridView();
            panelMid_KMR = new Panel();
            chartDiag_KMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_KMR.SuspendLayout();
            groupBoxButton_KMR.SuspendLayout();
            groupBox_Condition_KMR.SuspendLayout();
            panelLeft_KMR.SuspendLayout();
            groupBoxOut_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KMR).BeginInit();
            panelMid_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KMR).BeginInit();
            SuspendLayout();
            // 
            // panelUp_KMR
            // 
            panelUp_KMR.Controls.Add(groupBoxButton_KMR);
            panelUp_KMR.Controls.Add(groupBox_Condition_KMR);
            panelUp_KMR.Dock = DockStyle.Top;
            panelUp_KMR.Location = new Point(0, 0);
            panelUp_KMR.Name = "panelUp_KMR";
            panelUp_KMR.Size = new Size(800, 87);
            panelUp_KMR.TabIndex = 0;
            // 
            // groupBoxButton_KMR
            // 
            groupBoxButton_KMR.Controls.Add(buttonDone_KMR);
            groupBoxButton_KMR.Controls.Add(buttonOpen_KMR);
            groupBoxButton_KMR.Controls.Add(buttonHelp_KMR);
            groupBoxButton_KMR.Dock = DockStyle.Fill;
            groupBoxButton_KMR.Location = new Point(570, 0);
            groupBoxButton_KMR.Name = "groupBoxButton_KMR";
            groupBoxButton_KMR.Size = new Size(230, 87);
            groupBoxButton_KMR.TabIndex = 1;
            groupBoxButton_KMR.TabStop = false;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.BackColor = Color.Lime;
            buttonDone_KMR.Location = new Point(149, 19);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(69, 52);
            buttonDone_KMR.TabIndex = 0;
            buttonDone_KMR.Text = "Выполнить";
            buttonDone_KMR.UseVisualStyleBackColor = false;
            buttonDone_KMR.Click += buttonDone_Click;
            // 
            // buttonOpen_KMR
            // 
            buttonOpen_KMR.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpen_KMR.Location = new Point(72, 19);
            buttonOpen_KMR.Name = "buttonOpen_KMR";
            buttonOpen_KMR.Size = new Size(71, 52);
            buttonOpen_KMR.TabIndex = 0;
            buttonOpen_KMR.Text = "Открыть файл";
            buttonOpen_KMR.UseVisualStyleBackColor = false;
            buttonOpen_KMR.Click += buttonOpen_Click;
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.BackColor = SystemColors.ActiveCaption;
            buttonHelp_KMR.Location = new Point(0, 19);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(66, 52);
            buttonHelp_KMR.TabIndex = 0;
            buttonHelp_KMR.Text = "Справка";
            buttonHelp_KMR.UseVisualStyleBackColor = false;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // groupBox_Condition_KMR
            // 
            groupBox_Condition_KMR.Controls.Add(textBoxCondition_KMR);
            groupBox_Condition_KMR.Dock = DockStyle.Left;
            groupBox_Condition_KMR.Location = new Point(0, 0);
            groupBox_Condition_KMR.Name = "groupBox_Condition_KMR";
            groupBox_Condition_KMR.Size = new Size(570, 87);
            groupBox_Condition_KMR.TabIndex = 0;
            groupBox_Condition_KMR.TabStop = false;
            groupBox_Condition_KMR.Text = "Условие";
            // 
            // textBoxCondition_KMR
            // 
            textBoxCondition_KMR.BorderStyle = BorderStyle.None;
            textBoxCondition_KMR.Dock = DockStyle.Fill;
            textBoxCondition_KMR.Location = new Point(3, 19);
            textBoxCondition_KMR.Multiline = true;
            textBoxCondition_KMR.Name = "textBoxCondition_KMR";
            textBoxCondition_KMR.ReadOnly = true;
            textBoxCondition_KMR.Size = new Size(564, 65);
            textBoxCondition_KMR.TabIndex = 0;
            textBoxCondition_KMR.Text = "Прочитать данные из файла InPutFileTask5V6.txt. Вывести в dataGridView. Дан список из 20 чисел. Вывести все числа, кратные 3. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_KMR
            // 
            panelLeft_KMR.Controls.Add(groupBoxOut_KMR);
            panelLeft_KMR.Dock = DockStyle.Left;
            panelLeft_KMR.Location = new Point(0, 87);
            panelLeft_KMR.Name = "panelLeft_KMR";
            panelLeft_KMR.Size = new Size(191, 363);
            panelLeft_KMR.TabIndex = 1;
            // 
            // groupBoxOut_KMR
            // 
            groupBoxOut_KMR.Controls.Add(dataGridViewNums_KMR);
            groupBoxOut_KMR.Dock = DockStyle.Fill;
            groupBoxOut_KMR.Location = new Point(0, 0);
            groupBoxOut_KMR.Name = "groupBoxOut_KMR";
            groupBoxOut_KMR.Size = new Size(191, 363);
            groupBoxOut_KMR.TabIndex = 0;
            groupBoxOut_KMR.TabStop = false;
            groupBoxOut_KMR.Text = "Вывод данных";
            // 
            // dataGridViewNums_KMR
            // 
            dataGridViewNums_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KMR.Dock = DockStyle.Fill;
            dataGridViewNums_KMR.Location = new Point(3, 19);
            dataGridViewNums_KMR.Name = "dataGridViewNums_KMR";
            dataGridViewNums_KMR.ReadOnly = true;
            dataGridViewNums_KMR.Size = new Size(185, 341);
            dataGridViewNums_KMR.TabIndex = 0;
            // 
            // panelMid_KMR
            // 
            panelMid_KMR.Controls.Add(chartDiag_KMR);
            panelMid_KMR.Dock = DockStyle.Fill;
            panelMid_KMR.Location = new Point(191, 87);
            panelMid_KMR.Name = "panelMid_KMR";
            panelMid_KMR.Size = new Size(609, 363);
            panelMid_KMR.TabIndex = 2;
            // 
            // chartDiag_KMR
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_KMR.ChartAreas.Add(chartArea1);
            chartDiag_KMR.Dock = DockStyle.Fill;
            chartDiag_KMR.Location = new Point(0, 0);
            chartDiag_KMR.Name = "chartDiag_KMR";
            chartDiag_KMR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chartDiag_KMR.Series.Add(series1);
            chartDiag_KMR.Size = new Size(609, 363);
            chartDiag_KMR.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMid_KMR);
            Controls.Add(panelLeft_KMR);
            Controls.Add(panelUp_KMR);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 6 | Хабибуллин М. Р.";
            panelUp_KMR.ResumeLayout(false);
            groupBoxButton_KMR.ResumeLayout(false);
            groupBox_Condition_KMR.ResumeLayout(false);
            groupBox_Condition_KMR.PerformLayout();
            panelLeft_KMR.ResumeLayout(false);
            groupBoxOut_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KMR).EndInit();
            panelMid_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_KMR;
        private GroupBox groupBox_Condition_KMR;
        private Panel panelLeft_KMR;
        private Panel panelMid_KMR;
        private GroupBox groupBoxButton_KMR;
        private TextBox textBoxCondition_KMR;
        private GroupBox groupBoxOut_KMR;
        private DataGridView dataGridViewNums_KMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KMR;
        private Button buttonDone_KMR;
        private Button buttonOpen_KMR;
        private Button buttonHelp_KMR;
    }
}
