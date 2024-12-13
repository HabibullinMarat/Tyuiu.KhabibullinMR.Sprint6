namespace Tyuiu.KhabibullinMR.Sprint6.Task5.V30
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_KMR = new Panel();
            panelLeft_KMR = new Panel();
            panelMid_KMR = new Panel();
            groupBoxCondition_KMR = new GroupBox();
            textBoxCondition_KMR = new TextBox();
            dataGridViewNums_KMR = new DataGridView();
            chartDiag_KMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp_KMR = new Button();
            buttonOpen_KMR = new Button();
            buttonDone_KMR = new Button();
            panelTop_KMR.SuspendLayout();
            panelLeft_KMR.SuspendLayout();
            panelMid_KMR.SuspendLayout();
            groupBoxCondition_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KMR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KMR).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KMR
            // 
            panelTop_KMR.Controls.Add(buttonDone_KMR);
            panelTop_KMR.Controls.Add(buttonOpen_KMR);
            panelTop_KMR.Controls.Add(buttonHelp_KMR);
            panelTop_KMR.Controls.Add(groupBoxCondition_KMR);
            panelTop_KMR.Dock = DockStyle.Top;
            panelTop_KMR.Location = new Point(0, 0);
            panelTop_KMR.Name = "panelTop_KMR";
            panelTop_KMR.Size = new Size(800, 80);
            panelTop_KMR.TabIndex = 0;
            // 
            // panelLeft_KMR
            // 
            panelLeft_KMR.Controls.Add(dataGridViewNums_KMR);
            panelLeft_KMR.Dock = DockStyle.Left;
            panelLeft_KMR.Location = new Point(0, 80);
            panelLeft_KMR.Name = "panelLeft_KMR";
            panelLeft_KMR.Size = new Size(200, 370);
            panelLeft_KMR.TabIndex = 1;
            // 
            // panelMid_KMR
            // 
            panelMid_KMR.Controls.Add(chartDiag_KMR);
            panelMid_KMR.Dock = DockStyle.Fill;
            panelMid_KMR.Location = new Point(200, 80);
            panelMid_KMR.Name = "panelMid_KMR";
            panelMid_KMR.Size = new Size(600, 370);
            panelMid_KMR.TabIndex = 2;
            // 
            // groupBoxCondition_KMR
            // 
            groupBoxCondition_KMR.Controls.Add(textBoxCondition_KMR);
            groupBoxCondition_KMR.Dock = DockStyle.Left;
            groupBoxCondition_KMR.Location = new Point(0, 0);
            groupBoxCondition_KMR.Name = "groupBoxCondition_KMR";
            groupBoxCondition_KMR.Size = new Size(594, 80);
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
            textBoxCondition_KMR.Size = new Size(588, 58);
            textBoxCondition_KMR.TabIndex = 0;
            textBoxCondition_KMR.Text = "Прочитать данные из файла InPutFileTask5V30.txt. Вывести в dataGridView.Вывести все числа от 2 до 7. Построить диаграмму по этим значениям.";
            // 
            // dataGridViewNums_KMR
            // 
            dataGridViewNums_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KMR.Dock = DockStyle.Fill;
            dataGridViewNums_KMR.Location = new Point(0, 0);
            dataGridViewNums_KMR.Name = "dataGridViewNums_KMR";
            dataGridViewNums_KMR.ReadOnly = true;
            dataGridViewNums_KMR.Size = new Size(200, 370);
            dataGridViewNums_KMR.TabIndex = 0;
            // 
            // chartDiag_KMR
            // 
            chartArea3.Name = "ChartArea1";
            chartDiag_KMR.ChartAreas.Add(chartArea3);
            chartDiag_KMR.Dock = DockStyle.Fill;
            chartDiag_KMR.Location = new Point(0, 0);
            chartDiag_KMR.Name = "chartDiag_KMR";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            chartDiag_KMR.Series.Add(series3);
            chartDiag_KMR.Size = new Size(600, 370);
            chartDiag_KMR.TabIndex = 0;
            chartDiag_KMR.Text = "chart1";
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.Location = new Point(597, 12);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(60, 50);
            buttonHelp_KMR.TabIndex = 1;
            buttonHelp_KMR.Text = "Справка";
            buttonHelp_KMR.UseVisualStyleBackColor = true;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // buttonOpen_KMR
            // 
            buttonOpen_KMR.Location = new Point(666, 12);
            buttonOpen_KMR.Name = "buttonOpen_KMR";
            buttonOpen_KMR.Size = new Size(60, 50);
            buttonOpen_KMR.TabIndex = 1;
            buttonOpen_KMR.Text = "Открыть";
            buttonOpen_KMR.UseVisualStyleBackColor = true;
            buttonOpen_KMR.Click += buttonOpen_Click;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.Location = new Point(738, 12);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(60, 50);
            buttonDone_KMR.TabIndex = 1;
            buttonDone_KMR.Text = "Выполнить";
            buttonDone_KMR.UseVisualStyleBackColor = true;
            buttonDone_KMR.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMid_KMR);
            Controls.Add(panelLeft_KMR);
            Controls.Add(panelTop_KMR);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 30 | Хабибуллин М. Р.";
            panelTop_KMR.ResumeLayout(false);
            panelLeft_KMR.ResumeLayout(false);
            panelMid_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KMR).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KMR;
        private GroupBox groupBoxCondition_KMR;
        private Panel panelLeft_KMR;
        private Panel panelMid_KMR;
        private TextBox textBoxCondition_KMR;
        private DataGridView dataGridViewNums_KMR;
        private Button buttonDone_KMR;
        private Button buttonOpen_KMR;
        private Button buttonHelp_KMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KMR;
    }
}
