using Tyuiu.KhabibullinMR.Sprint6.Task5.V30.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task5.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"{Path.GetTempPath()}InPutDataFileTask5V30.txt";
        public void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KMR.ColumnCount = 2;
            dataGridViewNums_KMR.Columns[0].Width = 20;
            dataGridViewNums_KMR.Columns[1].Width = 50;

            this.chartDiag_KMR.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiag_KMR.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KMR.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KMR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KMR.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        public void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 5 выполнил студент группы ИИПб-24-2 Хабибуллин Марат Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
