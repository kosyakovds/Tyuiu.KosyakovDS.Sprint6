using Tyuiu.KosyakovDS.Sprint6.Task6.V21.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V21.txt";
            string wait = "nXkwQYzgZ XcNHugFmbsRgVVfsgHNGuUC";
            Assert.AreEqual(wait, ds.CollectTextFromFile(path));
        }
    }
}
