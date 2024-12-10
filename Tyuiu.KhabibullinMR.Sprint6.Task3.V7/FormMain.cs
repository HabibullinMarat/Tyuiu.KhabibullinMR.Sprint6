using System.Drawing.Drawing2D;
using Tyuiu.KhabibullinMR.Sprint6.Task3.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {{31 , 25 ,-18 , 12  , 9 },

                                       { 6 , 34 , -2 ,  2 ,-18 },

                                       {-5  , 4 , 27 ,  4 , -1 },

                                       { 4 , 15 , 34 , -6 ,-10 },

                                       { 0  , 8 ,  5 , 14 ,-17 }};
        
        public void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0)+1;
            int columns = matrix.Length/rows;

            dataGridViewInput_KMR.ColumnCount = columns;
            dataGridViewInput_KMR.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_KMR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i,j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] fours = ds.Calculate(matrix);

            int rows = fours.GetUpperBound(0) + 1;
            int columns = fours.Length / rows;

            dataGridViewOutput_KMR.ColumnCount = columns;
            dataGridViewOutput_KMR.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_KMR.Rows[i].Cells[j].Value = Convert.ToString(fours[i, j]);
                }
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 3 выполнил студент группы ИИПб-24-2 Хабибуллин Марат Рамильевич", "Сообщение", MessageBoxButtons.OK);
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
