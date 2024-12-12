using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhabibullinMR.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            int len = (stopValue -  startValue) + 1;
            int count = 0;
            double[] result = new double[len];
            for (int x = startValue; x < stopValue+1; x++)
            {
                if (x + 1.2 != 0)
                {
                    result[count] = Math.Round((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2, 2);
                    count++;
                }
                else
                {
                    result[count] = 0;
                }
            }
            return result;
        }
    }
}
