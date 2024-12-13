using System.IO;
using Tyuiu.KhabibullinMR.Sprint6.Task7.V28.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        static int rows;
        static int columns;

        public static int[,] LoadFromFileData(string efilePath)
        {
            string fileData = File.ReadAllText(efilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r,c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;

        }

        public void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        public void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] valueArray = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_KMR.Rows[i].Cells[j].Value = valueArray[i,j];
                }
            }
            buttonSave_KMR.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogSave_KMR.FileName = "OutPutFileTask7.csv";
            saveFileDialogSave_KMR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogSave_KMR.ShowDialog();

            string path = saveFileDialogSave_KMR.FileName;

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KMR.RowCount;
            int columns = dataGridViewOut_KMR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KMR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KMR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KMR.ShowDialog();
            openFilePath = openFileDialogTask_KMR.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KMR.ColumnCount = columns;
            dataGridViewIn_KMR.RowCount = rows;
            dataGridViewOut_KMR.ColumnCount = columns;
            dataGridViewOut_KMR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KMR.Columns[i].Width = 25;
                dataGridViewOut_KMR.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_KMR.Rows[i].Cells[j].Value = arrayValues[i,j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KMR.Enabled = true;
        }

        private void buttonOpen_MouseEnter(object sender, MouseEventArgs e)
        {
            toolTipButton_KMR.ToolTipTitle = "Открыть файл";

        }
        private void buttonDone_MouseEnter(object sender, MouseEventArgs e)
        {
            toolTipButton_KMR.ToolTipTitle = "Выполнить";

        }
        private void buttonSaveFile_MouseEnter(object sender, MouseEventArgs e)
        {
            toolTipButton_KMR.ToolTipTitle = "Сохранить в файл";

        }
        private void buttonHelp_MouseEnter(object sender, MouseEventArgs e)
        {
            toolTipButton_KMR.ToolTipTitle = "Справка";

        }
    }
}
