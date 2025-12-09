using Tyuiu.KosyakovDS.Sprint6.Task5.V14.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";

            double[] wait = { 17.57, 10, 12.22, 12, 17.91, 19.01 };
            double[] res = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
