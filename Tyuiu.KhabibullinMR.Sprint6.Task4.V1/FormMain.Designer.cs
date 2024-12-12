namespace Tyuiu.KhabibullinMR.Sprint6.Task4.V1
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
            panelTop_KMR = new Panel();
            buttonSave_KMR = new Button();
            buttonDone_KMR = new Button();
            buttonHelp_KMR = new Button();
            groupBoxIn_KMR = new GroupBox();
            labelStop_KMR = new Label();
            labelStart_KMR = new Label();
            textBoxStop_KMR = new TextBox();
            textBoxStart_KMR = new TextBox();
            groupBox_Con_KMR = new GroupBox();
            textBox1 = new TextBox();
            panelLeft_KMR = new Panel();
            groupBoxOut_KMR = new GroupBox();
            textBoxResult_KMR = new TextBox();
            panelCenter_KMR = new Panel();
            chartFunction_KMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_KMR.SuspendLayout();
            groupBoxIn_KMR.SuspendLayout();
            groupBox_Con_KMR.SuspendLayout();
            panelLeft_KMR.SuspendLayout();
            groupBoxOut_KMR.SuspendLayout();
            panelCenter_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMR).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KMR
            // 
            panelTop_KMR.Controls.Add(buttonSave_KMR);
            panelTop_KMR.Controls.Add(buttonDone_KMR);
            panelTop_KMR.Controls.Add(buttonHelp_KMR);
            panelTop_KMR.Controls.Add(groupBoxIn_KMR);
            panelTop_KMR.Controls.Add(groupBox_Con_KMR);
            panelTop_KMR.Dock = DockStyle.Top;
            panelTop_KMR.Location = new Point(0, 0);
            panelTop_KMR.Name = "panelTop_KMR";
            panelTop_KMR.Size = new Size(784, 100);
            panelTop_KMR.TabIndex = 0;
            // 
            // buttonSave_KMR
            // 
            buttonSave_KMR.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_KMR.Location = new Point(656, 18);
            buttonSave_KMR.Name = "buttonSave_KMR";
            buttonSave_KMR.Size = new Size(59, 55);
            buttonSave_KMR.TabIndex = 2;
            buttonSave_KMR.Text = "Сохранить";
            buttonSave_KMR.UseVisualStyleBackColor = false;
            buttonSave_KMR.Click += buttonSave_Click;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.BackColor = Color.Lime;
            buttonDone_KMR.Location = new Point(721, 18);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(59, 55);
            buttonDone_KMR.TabIndex = 2;
            buttonDone_KMR.Text = "Выполнть";
            buttonDone_KMR.UseVisualStyleBackColor = false;
            buttonDone_KMR.Click += buttonDone_Click;
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.BackColor = SystemColors.ActiveCaption;
            buttonHelp_KMR.Location = new Point(591, 18);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(59, 55);
            buttonHelp_KMR.TabIndex = 2;
            buttonHelp_KMR.Text = "Справка";
            buttonHelp_KMR.UseVisualStyleBackColor = false;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // groupBoxIn_KMR
            // 
            groupBoxIn_KMR.Controls.Add(labelStop_KMR);
            groupBoxIn_KMR.Controls.Add(labelStart_KMR);
            groupBoxIn_KMR.Controls.Add(textBoxStop_KMR);
            groupBoxIn_KMR.Controls.Add(textBoxStart_KMR);
            groupBoxIn_KMR.Location = new Point(358, 0);
            groupBoxIn_KMR.Name = "groupBoxIn_KMR";
            groupBoxIn_KMR.Size = new Size(227, 100);
            groupBoxIn_KMR.TabIndex = 1;
            groupBoxIn_KMR.TabStop = false;
            groupBoxIn_KMR.Text = "Ввод данных";
            // 
            // labelStop_KMR
            // 
            labelStop_KMR.AutoSize = true;
            labelStop_KMR.Location = new Point(112, 38);
            labelStop_KMR.Name = "labelStop_KMR";
            labelStop_KMR.Size = new Size(75, 15);
            labelStop_KMR.TabIndex = 2;
            labelStop_KMR.Text = "Конец шага:";
            // 
            // labelStart_KMR
            // 
            labelStart_KMR.AutoSize = true;
            labelStart_KMR.Location = new Point(6, 38);
            labelStart_KMR.Name = "labelStart_KMR";
            labelStart_KMR.Size = new Size(83, 15);
            labelStart_KMR.TabIndex = 2;
            labelStart_KMR.Text = "Начало шага:";
            // 
            // textBoxStop_KMR
            // 
            textBoxStop_KMR.Location = new Point(112, 56);
            textBoxStop_KMR.Name = "textBoxStop_KMR";
            textBoxStop_KMR.Size = new Size(100, 23);
            textBoxStop_KMR.TabIndex = 1;
            // 
            // textBoxStart_KMR
            // 
            textBoxStart_KMR.Location = new Point(6, 56);
            textBoxStart_KMR.Name = "textBoxStart_KMR";
            textBoxStart_KMR.Size = new Size(100, 23);
            textBoxStart_KMR.TabIndex = 0;
            // 
            // groupBox_Con_KMR
            // 
            groupBox_Con_KMR.Controls.Add(textBox1);
            groupBox_Con_KMR.Dock = DockStyle.Left;
            groupBox_Con_KMR.Location = new Point(0, 0);
            groupBox_Con_KMR.Name = "groupBox_Con_KMR";
            groupBox_Con_KMR.Size = new Size(352, 100);
            groupBox_Con_KMR.TabIndex = 0;
            groupBox_Con_KMR.TabStop = false;
            groupBox_Con_KMR.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(384, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне [-5;5]\r\nРезультат вывести в TextBox, построить график функции и \r\nсохранить в файл OutPutFileTask.txt по нажатию кнопки.";
            // 
            // panelLeft_KMR
            // 
            panelLeft_KMR.Controls.Add(groupBoxOut_KMR);
            panelLeft_KMR.Dock = DockStyle.Left;
            panelLeft_KMR.Location = new Point(0, 100);
            panelLeft_KMR.Name = "panelLeft_KMR";
            panelLeft_KMR.Size = new Size(227, 311);
            panelLeft_KMR.TabIndex = 1;
            // 
            // groupBoxOut_KMR
            // 
            groupBoxOut_KMR.Controls.Add(textBoxResult_KMR);
            groupBoxOut_KMR.Dock = DockStyle.Fill;
            groupBoxOut_KMR.Location = new Point(0, 0);
            groupBoxOut_KMR.Name = "groupBoxOut_KMR";
            groupBoxOut_KMR.Size = new Size(227, 311);
            groupBoxOut_KMR.TabIndex = 0;
            groupBoxOut_KMR.TabStop = false;
            groupBoxOut_KMR.Text = "Вывод данных";
            // 
            // textBoxResult_KMR
            // 
            textBoxResult_KMR.Dock = DockStyle.Fill;
            textBoxResult_KMR.Location = new Point(3, 19);
            textBoxResult_KMR.Multiline = true;
            textBoxResult_KMR.Name = "textBoxResult_KMR";
            textBoxResult_KMR.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KMR.Size = new Size(221, 289);
            textBoxResult_KMR.TabIndex = 0;
            // 
            // panelCenter_KMR
            // 
            panelCenter_KMR.Controls.Add(chartFunction_KMR);
            panelCenter_KMR.Dock = DockStyle.Fill;
            panelCenter_KMR.Location = new Point(227, 100);
            panelCenter_KMR.Name = "panelCenter_KMR";
            panelCenter_KMR.Size = new Size(557, 311);
            panelCenter_KMR.TabIndex = 2;
            // 
            // chartFunction_KMR
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KMR.ChartAreas.Add(chartArea1);
            chartFunction_KMR.Dock = DockStyle.Fill;
            chartFunction_KMR.Location = new Point(0, 0);
            chartFunction_KMR.Name = "chartFunction_KMR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction_KMR.Series.Add(series1);
            chartFunction_KMR.Size = new Size(557, 311);
            chartFunction_KMR.TabIndex = 0;
            chartFunction_KMR.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panelCenter_KMR);
            Controls.Add(panelLeft_KMR);
            Controls.Add(panelTop_KMR);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Хабибуллин М. Р.";
            panelTop_KMR.ResumeLayout(false);
            groupBoxIn_KMR.ResumeLayout(false);
            groupBoxIn_KMR.PerformLayout();
            groupBox_Con_KMR.ResumeLayout(false);
            groupBox_Con_KMR.PerformLayout();
            panelLeft_KMR.ResumeLayout(false);
            groupBoxOut_KMR.ResumeLayout(false);
            groupBoxOut_KMR.PerformLayout();
            panelCenter_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KMR;
        private Panel panelLeft_KMR;
        private GroupBox groupBox_Con_KMR;
        private TextBox textBox1;
        private Panel panelCenter_KMR;
        private GroupBox groupBoxIn_KMR;
        private Label labelStop_KMR;
        private Label labelStart_KMR;
        private TextBox textBoxStop_KMR;
        private TextBox textBoxStart_KMR;
        private GroupBox groupBoxOut_KMR;
        private TextBox textBoxResult_KMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMR;
        private Button buttonSave_KMR;
        private Button buttonDone_KMR;
        private Button buttonHelp_KMR;
    }
}
