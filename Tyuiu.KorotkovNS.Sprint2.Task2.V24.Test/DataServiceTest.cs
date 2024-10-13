using Tyuiu.KorotkovNS.Sprint2.Task2.V24.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 12;
            int y = 10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}