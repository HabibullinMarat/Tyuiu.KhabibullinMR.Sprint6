namespace Tyuiu.KhabibullinMR.Sprint6.Task0.V4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBoxX = new TextBox();
            textBoxTask = new TextBox();
            pictureBoxFormula = new PictureBox();
            labelIn = new Label();
            label2 = new Label();
            textBoxVarX = new Label();
            labelOut = new Label();
            textBoxResult = new TextBox();
            labelResult = new Label();
            buttonGo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(574, 365);
            button1.Name = "button1";
            button1.Size = new Size(35, 30);
            button1.TabIndex = 0;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonHelp_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(40, 316);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 1;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 43);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(470, 200);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(488, 43);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(302, 33);
            pictureBoxFormula.TabIndex = 3;
            pictureBoxFormula.TabStop = false;
            // 
            // labelIn
            // 
            labelIn.AutoSize = true;
            labelIn.Location = new Point(12, 256);
            labelIn.Name = "labelIn";
            labelIn.Size = new Size(77, 15);
            labelIn.TabIndex = 4;
            labelIn.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Условие";
            // 
            // textBoxVarX
            // 
            textBoxVarX.AutoSize = true;
            textBoxVarX.Location = new Point(40, 298);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(89, 15);
            textBoxVarX.TabIndex = 6;
            textBoxVarX.Text = "Переменная Х:";
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Location = new Point(509, 256);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(86, 15);
            labelOut.TabIndex = 7;
            labelOut.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(509, 316);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 8;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(509, 298);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 9;
            labelResult.Text = "Результат:";
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(629, 365);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(146, 30);
            buttonGo.TabIndex = 10;
            buttonGo.Text = "Выполнить";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGo);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
            Controls.Add(labelOut);
            Controls.Add(textBoxVarX);
            Controls.Add(label2);
            Controls.Add(labelIn);
            Controls.Add(pictureBoxFormula);
            Controls.Add(textBoxTask);
            Controls.Add(textBoxX);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Хабибуллин М. Р.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxX;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private Label labelIn;
        private Label label2;
        private Label textBoxVarX;
        private Label labelOut;
        private TextBox textBoxResult;
        private Label labelResult;
        private Button buttonGo;
    }
}
