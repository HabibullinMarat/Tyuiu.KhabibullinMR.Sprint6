using Tyuiu.KhabibullinMR.Sprint6.Task1.V13.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task1.V13
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_KMR.Text = "";
                textBoxRes_KMR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_KMR.AppendText("|     X    +   f(x)   +" + Environment.NewLine);
                textBoxRes_KMR.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1,5:f2}    | ", startStep, valueArray[i]);
                    textBoxRes_KMR.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_KMR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 1 выполнил студент группы ИИПб-24-2 Хабибуллин Марат Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }

    }
}
