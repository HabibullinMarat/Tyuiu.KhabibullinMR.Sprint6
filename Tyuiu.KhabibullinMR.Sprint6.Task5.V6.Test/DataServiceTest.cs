using Tyuiu.KhabibullinMR.Sprint6.Task5.V6.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = $@"{Path.GetTempPath()}InPutDataFileTask5V6.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { };
            CollectionAssert.AreEqual(wait,res);
        }
    }
}
