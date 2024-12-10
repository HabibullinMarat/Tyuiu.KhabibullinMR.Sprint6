namespace Tyuiu.KhabibullinMR.Sprint6.Task1.V13
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
            groupBoxCondition_KMR = new GroupBox();
            textBoxCondition_KMR = new TextBox();
            groupBoxInput_KMR = new GroupBox();
            labelStop_KMR = new Label();
            textBoxStopStep_KMR = new TextBox();
            labelStart_KMR = new Label();
            textBoxStartStep_KMR = new TextBox();
            groupBoxRes_KMR = new GroupBox();
            textBoxRes_KMR = new TextBox();
            labelRes_KMR = new Label();
            buttonHelp_KMR = new Button();
            buttonDone_Click_KMR = new Button();
            groupBoxCondition_KMR.SuspendLayout();
            groupBoxInput_KMR.SuspendLayout();
            groupBoxRes_KMR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_KMR
            // 
            groupBoxCondition_KMR.Controls.Add(textBoxCondition_KMR);
            groupBoxCondition_KMR.Location = new Point(22, 26);
            groupBoxCondition_KMR.Name = "groupBoxCondition_KMR";
            groupBoxCondition_KMR.Size = new Size(420, 283);
            groupBoxCondition_KMR.TabIndex = 0;
            groupBoxCondition_KMR.TabStop = false;
            groupBoxCondition_KMR.Text = "Условие";
            // 
            // textBoxCondition_KMR
            // 
            textBoxCondition_KMR.BorderStyle = BorderStyle.None;
            textBoxCondition_KMR.ForeColor = SystemColors.WindowText;
            textBoxCondition_KMR.Location = new Point(12, 27);
            textBoxCondition_KMR.Multiline = true;
            textBoxCondition_KMR.Name = "textBoxCondition_KMR";
            textBoxCondition_KMR.ReadOnly = true;
            textBoxCondition_KMR.Size = new Size(334, 43);
            textBoxCondition_KMR.TabIndex = 0;
            textBoxCondition_KMR.Text = "Протабулировать заданную функцию.\r\nРезультат вывести в виде табдицы";
            // 
            // groupBoxInput_KMR
            // 
            groupBoxInput_KMR.Controls.Add(labelStop_KMR);
            groupBoxInput_KMR.Controls.Add(textBoxStopStep_KMR);
            groupBoxInput_KMR.Controls.Add(labelStart_KMR);
            groupBoxInput_KMR.Controls.Add(textBoxStartStep_KMR);
            groupBoxInput_KMR.Location = new Point(22, 315);
            groupBoxInput_KMR.Name = "groupBoxInput_KMR";
            groupBoxInput_KMR.Size = new Size(237, 77);
            groupBoxInput_KMR.TabIndex = 1;
            groupBoxInput_KMR.TabStop = false;
            groupBoxInput_KMR.Text = "Ввод данных";
            // 
            // labelStop_KMR
            // 
            labelStop_KMR.AutoSize = true;
            labelStop_KMR.Location = new Point(119, 19);
            labelStop_KMR.Name = "labelStop_KMR";
            labelStop_KMR.Size = new Size(72, 15);
            labelStop_KMR.TabIndex = 3;
            labelStop_KMR.Text = "Старт шага:";
            // 
            // textBoxStopStep_KMR
            // 
            textBoxStopStep_KMR.Location = new Point(119, 40);
            textBoxStopStep_KMR.Name = "textBoxStopStep_KMR";
            textBoxStopStep_KMR.Size = new Size(100, 23);
            textBoxStopStep_KMR.TabIndex = 2;
            // 
            // labelStart_KMR
            // 
            labelStart_KMR.AutoSize = true;
            labelStart_KMR.Location = new Point(12, 22);
            labelStart_KMR.Name = "labelStart_KMR";
            labelStart_KMR.Size = new Size(72, 15);
            labelStart_KMR.TabIndex = 1;
            labelStart_KMR.Text = "Старт шага:";
            // 
            // textBoxStartStep_KMR
            // 
            textBoxStartStep_KMR.Location = new Point(13, 40);
            textBoxStartStep_KMR.Name = "textBoxStartStep_KMR";
            textBoxStartStep_KMR.Size = new Size(100, 23);
            textBoxStartStep_KMR.TabIndex = 0;
            // 
            // groupBoxRes_KMR
            // 
            groupBoxRes_KMR.Controls.Add(textBoxRes_KMR);
            groupBoxRes_KMR.Controls.Add(labelRes_KMR);
            groupBoxRes_KMR.Location = new Point(461, 26);
            groupBoxRes_KMR.Name = "groupBoxRes_KMR";
            groupBoxRes_KMR.Size = new Size(211, 366);
            groupBoxRes_KMR.TabIndex = 2;
            groupBoxRes_KMR.TabStop = false;
            groupBoxRes_KMR.Text = "Вывод данных:";
            // 
            // textBoxRes_KMR
            // 
            textBoxRes_KMR.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_KMR.Location = new Point(11, 42);
            textBoxRes_KMR.Multiline = true;
            textBoxRes_KMR.Name = "textBoxRes_KMR";
            textBoxRes_KMR.ReadOnly = true;
            textBoxRes_KMR.ScrollBars = ScrollBars.Vertical;
            textBoxRes_KMR.Size = new Size(194, 310);
            textBoxRes_KMR.TabIndex = 1;
            // 
            // labelRes_KMR
            // 
            labelRes_KMR.AutoSize = true;
            labelRes_KMR.Location = new Point(6, 19);
            labelRes_KMR.Name = "labelRes_KMR";
            labelRes_KMR.Size = new Size(63, 15);
            labelRes_KMR.TabIndex = 0;
            labelRes_KMR.Text = "Результат:";
            // 
            // buttonHelp_KMR
            // 
            buttonHelp_KMR.BackColor = Color.DodgerBlue;
            buttonHelp_KMR.Location = new Point(265, 326);
            buttonHelp_KMR.Name = "buttonHelp_KMR";
            buttonHelp_KMR.Size = new Size(75, 66);
            buttonHelp_KMR.TabIndex = 3;
            buttonHelp_KMR.Text = "Справка";
            buttonHelp_KMR.UseVisualStyleBackColor = false;
            buttonHelp_KMR.Click += buttonHelp_Click;
            // 
            // buttonDone_Click_KMR
            // 
            buttonDone_Click_KMR.BackColor = Color.Lime;
            buttonDone_Click_KMR.Location = new Point(346, 326);
            buttonDone_Click_KMR.Name = "buttonDone_Click_KMR";
            buttonDone_Click_KMR.Size = new Size(96, 66);
            buttonDone_Click_KMR.TabIndex = 4;
            buttonDone_Click_KMR.Text = "Выполнить";
            buttonDone_Click_KMR.UseVisualStyleBackColor = false;
            buttonDone_Click_KMR.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 401);
            Controls.Add(buttonDone_Click_KMR);
            Controls.Add(buttonHelp_KMR);
            Controls.Add(groupBoxRes_KMR);
            Controls.Add(groupBoxInput_KMR);
            Controls.Add(groupBoxCondition_KMR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 13 | Хабибуллин М. Р.";
            groupBoxCondition_KMR.ResumeLayout(false);
            groupBoxCondition_KMR.PerformLayout();
            groupBoxInput_KMR.ResumeLayout(false);
            groupBoxInput_KMR.PerformLayout();
            groupBoxRes_KMR.ResumeLayout(false);
            groupBoxRes_KMR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KMR;
        private TextBox textBoxCondition_KMR;
        private GroupBox groupBoxInput_KMR;
        private TextBox textBoxStartStep_KMR;
        private Label labelStop_KMR;
        private TextBox textBoxStopStep_KMR;
        private Label labelStart_KMR;
        private GroupBox groupBoxRes_KMR;
        private Label labelRes_KMR;
        private TextBox textBoxRes_KMR;
        private Button buttonHelp_KMR;
        private Button buttonDone_Click_KMR;
    }
}
