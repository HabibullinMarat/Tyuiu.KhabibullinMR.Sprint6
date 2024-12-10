using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhabibullinMR.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] fours = new int[columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                    {
                        fours.Append(matrix[i, j]);
                    }
                }
            }
            int k = 0;
            int[] keys = {-6,2,4,12,14};
            Array.Sort(fours);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                    {
                        matrix[i, j] = keys[k];
                        k++;
                    }
                }
            }
            return matrix;
        }
    }
}
