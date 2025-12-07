using Tyuiu.KosyakovDS.Sprint6.Task1.V23.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { 3.63, -11.70, -14.02, -5.24, 1.32, 0.00, -1.32, 5.24, 14.02, 11.70, -3.63 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
