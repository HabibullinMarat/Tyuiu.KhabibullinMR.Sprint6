using Tyuiu.KhabibullinMR.Sprint6.Task4.V1.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task4.V1
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
                int startStep = Convert.ToInt32(textBoxStart_KMR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KMR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KMR.Titles.Add("������ �������");

                this.chartFunction_KMR.ChartAreas[0].AxisX.Title = "��� �";
                this.chartFunction_KMR.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_KMR.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
                for (int i = 0; i < len; i++)
                {
                    textBoxResult_KMR.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 4 �������� ������� ������ ����-24-2 ���������� ����� ����������", "���������", MessageBoxButtons.OK);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Path.GetTempPath()}OutPutFileTask4V1.txt";
                File.WriteAllText(path, textBoxResult_KMR.Text);

                DialogResult dialogresult = MessageBox.Show("����" + path + "������� ��������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("������ ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
