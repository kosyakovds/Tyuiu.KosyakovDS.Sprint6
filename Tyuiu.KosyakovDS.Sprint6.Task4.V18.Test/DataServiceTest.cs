using Tyuiu.KosyakovDS.Sprint6.Task4.V18.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();
            double[] wait = { 7.76, 7.36, 7.26, 7.9, 15.88, 2, 4.35, 5.63, 6.49, 6.49, 6.32 };
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
