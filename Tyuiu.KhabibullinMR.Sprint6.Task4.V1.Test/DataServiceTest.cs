﻿using Tyuiu.KhabibullinMR.Sprint6.Task4.V1.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -12.18;
            valueWaitArray[1] = 16.03;
            valueWaitArray[2] = 18.87;
            valueWaitArray[3] = 4.96;
            valueWaitArray[4] = -9.99;
            valueWaitArray[5] = -2;
            valueWaitArray[6] = 2.16;
            valueWaitArray[7] = -7.54;
            valueWaitArray[8] = -22.76;
            valueWaitArray[9] = -20.45;
            valueWaitArray[10] = 7.77;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
