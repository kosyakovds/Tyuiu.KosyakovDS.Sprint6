using Tyuiu.KosyakovDS.Sprint6.Task2.V13.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { 3.3, -12.37, -14.02, -5.57, 0.65, 0.0, -0.65, 5.57, 14.02, 12.37, -3.3 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
