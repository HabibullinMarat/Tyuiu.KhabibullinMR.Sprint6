namespace Tyuiu.KhabibullinMR.Sprint6.Task2.V28
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
            groupBoxCondition_KMR = new GroupBox();
            textBoxCondition_KMR = new TextBox();
            groupBoxInput_KMR = new GroupBox();
            textBoxStopStep_KMR = new TextBox();
            textBoxStartStep_KMR = new TextBox();
            labelStop_KMR = new Label();
            labelStart_KMR = new Label();
            groupBoxOutput = new GroupBox();
            chart_KMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_KMR = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            ColumnF = new DataGridViewTextBoxColumn();
            labelOutput_KMR = new Label();
            buttonHelp_KMR = new Button();
            buttonDone_KMR = new Button();
            groupBoxCondition_KMR.SuspendLayout();
            groupBoxInput_KMR.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_KMR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KMR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KMR
            // 
            groupBoxCondition_KMR.Controls.Add(textBoxCondition_KMR);
            groupBoxCondition_KMR.Location = new Point(21, 17);
            groupBoxCondition_KMR.Name = "groupBoxCondition_KMR";
            groupBoxCondition_KMR.Size = new Size(372, 282);
            groupBoxCondition_KMR.TabIndex = 0;
            groupBoxCondition_KMR.TabStop = false;
            groupBoxCondition_KMR.Text = "Условие";
            // 
            // textBoxCondition_KMR
            // 
            textBoxCondition_KMR.BorderStyle = BorderStyle.None;
            textBoxCondition_KMR.Location = new Point(26, 27);
            textBoxCondition_KMR.Multiline = true;
            textBoxCondition_KMR.Name = "textBoxCondition_KMR";
            textBoxCondition_KMR.ReadOnly = true;
            textBoxCondition_KMR.Size = new Size(279, 76);
            textBoxCondition_KMR.TabIndex = 0;
            textBoxCondition_KMR.Text = "Протабултровать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_KMR
            // 
            groupBoxInput_KMR.Controls.Add(textBoxStopStep_KMR);
            groupBoxInput_KMR.Controls.Add(textBoxStartStep_KMR);
            groupBoxInput_KMR.Controls.Add(labelStop_KMR);
            groupBoxInput_KMR.Controls.Add(labelStart_KMR);
            groupBoxInput_KMR.Location = new Point(21, 305);
            groupBoxInput_KMR.Name = "groupBoxInput_KMR";
            groupBoxInput_KMR.Size = new Size(213, 100);
            groupBoxInput_KMR.TabIndex = 1;
            groupBoxInput_KMR.TabStop = false;
            groupBoxInput_KMR.Text = "Ввод данных";
            // 
            // textBoxStopStep_KMR
            // 
            textBoxStopStep_KMR.Location = new Point(108, 48);
            textBoxStopStep_KMR.Name = "textBoxStopStep_KMR";
            textBoxStopStep_KMR.Size = new Size(81, 23);
            textBoxStopStep_KMR.TabIndex = 3;
            // 
            // textBoxStartStep_KMR
            // 
            textBoxStartStep_KMR.Location = new Point(6, 48);
            textBoxStartStep_KMR.Name = "textBoxStartStep_KMR";
            textBoxStartStep_KMR.Size = new Size(81, 23);
            textBoxStartStep_KMR.TabIndex = 2;
            // 
            // labelStop_KMR
            // 
            labelStop_KMR.AutoSize = true;
            labelStop_KMR.Location = new Point(108, 19);
            labelStop_KMR.Name = "labelStop_KMR";
            labelStop_KMR.Size = new Size(75, 15);
            labelStop_KMR.TabIndex = 1;
            labelStop_KMR.Text = "Конец шага:";
            // 
            // labelStart_KMR
            // 
            labelStart_KMR.AutoSize = true;
            labelStart_KMR.Location = new Point(6, 19);
            labelStart_KMR.Name = "labelStart_KMR";
            labelStart_KMR.Size = new Size(72, 15);
            labelStart_KMR.TabIndex = 0;
            labelStart_KMR.Text = "Старт шага:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(chart_KMR);
            groupBoxOutput.Controls.Add(dataGridViewFunction_KMR);
            groupBoxOutput.Controls.Add(labelOutput_KMR);
            groupBoxOutput.Location = new Point(399, 17);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(573, 388);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // chart_KMR
            // 
            chartArea1.Name = "ChartArea1";
            chart_KMR.ChartAreas.Add(chartArea1);
            chart_KMR.Location = new Point(245, 37);
            chart_KMR.Name = "chart_KMR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart_KMR.Series.Add(series1);
            chart_KMR.Size = new Size(306, 300);
            chart_KMR.TabIndex = 2;
            // 
            // dataGridViewFunction_KMR
            // 
            dataGridViewFunction_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KMR.Columns.AddRange(new DataGridViewColumn[] { X, ColumnF });
            dataGridViewFunction_KMR.Location = new Point(6, 37);
            dataGridViewFunction_KMR.Name = "dataGridViewFunction_KMR";
            dataGridViewFunction_KMR.RowHeadersVisible = false;
            dataGridViewFunction_KMR.Size = new Size(204, 345);
            dataGridViewFunction_KMR.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Resizable = DataGridViewTriState.False;
            // 
            // ColumnF
            // 
            ColumnF.HeaderText = "F(X)";
            ColumnF.Name = "ColumnF";
            // 
            // labelOutput_KMR
            // 
            labelOutput_KMR.AutoSize = true;
            labelOutput_KMR.Location = new Point(6, 19);
            labelOutput_KMR.Name = "labelOutput_KMR";
            labelOutput_KMR.Size = new Size(63, 15);
            labelOutput_KMR.TabIndex = 0;
            labelOutput_KMR.Text = "Результат:";
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.BackColor = Color.Blue;
            buttonHelp_KMR.Location = new Point(240, 316);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(75, 60);
            buttonHelp_KMR.TabIndex = 3;
            buttonHelp_KMR.Text = "Справка";
            buttonHelp_KMR.UseVisualStyleBackColor = false;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // buttonDone_KMR
            // 
            buttonDone_KMR.BackColor = Color.Lime;
            buttonDone_KMR.Location = new Point(321, 316);
            buttonDone_KMR.Name = "buttonDone_KMR";
            buttonDone_KMR.Size = new Size(75, 60);
            buttonDone_KMR.TabIndex = 4;
            buttonDone_KMR.Text = "Выполнить";
            buttonDone_KMR.UseVisualStyleBackColor = false;
            buttonDone_KMR.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(buttonDone_KMR);
            Controls.Add(buttonHelp_KMR);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput_KMR);
            Controls.Add(groupBoxCondition_KMR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxCondition_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.PerformLayout();
            groupBoxInput_KMR.ResumeLayout(false);
            groupBoxInput_KMR.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_KMR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KMR;
        private TextBox textBoxCondition_KMR;
        private GroupBox groupBoxInput_KMR;
        private TextBox textBoxStopStep_KMR;
        private TextBox textBoxStartStep_KMR;
        private Label labelStop_KMR;
        private Label labelStart_KMR;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewFunction_KMR;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn ColumnF;
        private Label labelOutput_KMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KMR;
        private Button buttonHelp_KMR;
        private Button buttonDone_KMR;
    }
}
