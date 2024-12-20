﻿using Tyuiu.KhabibullinMR.Sprint6.Task1.V13.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task1.V13.Test
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

            valueWaitArray[0] = 23.92;
            valueWaitArray[1] = 18.88;
            valueWaitArray[2] = 13.10;
            valueWaitArray[3] = 7.24;
            valueWaitArray[4] = 1.80;
            valueWaitArray[5] = -8.00;
            valueWaitArray[6] = -5.70;
            valueWaitArray[7] = -11.26;
            valueWaitArray[8] = -17.12;
            valueWaitArray[9] = -22.88;
            valueWaitArray[10] = -27.92;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
