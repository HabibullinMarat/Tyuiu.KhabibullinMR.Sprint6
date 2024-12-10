using Tyuiu.KhabibullinMR.Sprint6.Task2.V28.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        public void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KMR.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KMR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart_KMR.Titles.Add("График функции");

                this.chart_KMR.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_KMR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_KMR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart_KMR.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 2 выполнил студент группы ИИПб-24-2 Хабибуллин Марат Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KMR.BackColor = Color.Red;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KMR.BackColor = Color.Lime;
        }
        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KMR.BackColor = Color.Blue;
        }
    }
}
