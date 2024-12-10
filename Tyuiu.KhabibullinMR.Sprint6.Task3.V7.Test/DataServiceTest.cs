﻿using Tyuiu.KhabibullinMR.Sprint6.Task3.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = { {31 , 25 ,-18 , 12  , 9 },

                           { 6 , 34 , -2 ,  2 ,-18 },

                           {-5  , 4 , 27 ,  4 , -1 },

                           { 4 , 15 , 34 , -6 ,-10 },

                           { 0  , 8 ,  5 , 14 ,-17 } };

            int[,] wait = { {31 , 25 ,-18 , -6  , 9 },

                           { 6 , 34 , -2 ,  2 ,-18 },

                           {-5  , 4 , 27 ,  4 , -1 },

                           { 4 , 15 , 34 , 12 ,-10 },

                           { 0  , 8 ,  5 , 14 ,-17 } };

            int[,] res = ds.Calculate(mas);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
