using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhabibullinMR.Sprint6.Task2.V28.Lib
{
    public class DataService : ISprint6Task2V28
    {
            public double[] GetMassFunction(int startValue, int stopValue)
            {
                double[] valueArray;
                int len = (stopValue - startValue) + 1;
                valueArray = new double[len];
                double y;
                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    if ((4 * x - 0.5) == 0)
                    {
                        valueArray[count] = 0;
                        count++;
                    }
                    else
                    {
                        y = Math.Round((Math.Sin(x) - 2*x)/(3*x - 1) + Math.Sin(x) - 3*x + 2, 2);
                        valueArray[count] = y;
                        count++;
                    }
                }
                return valueArray;
            }
    }
}
