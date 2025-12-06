using Tyuiu.KosyakovDS.Sprint6.Task0.V26.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            double wait = 0.769;
            double res = ds.Calculate(3);
            Assert.AreEqual(wait, res);
        }
    }
}
