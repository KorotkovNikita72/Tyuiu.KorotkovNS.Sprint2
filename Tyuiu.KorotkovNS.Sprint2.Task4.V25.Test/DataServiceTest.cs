using Tyuiu.KorotkovNS.Sprint2.Task4.V25.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 1.166;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = -200;
            double res = ds.Calculate(x, y);
            double wait = -200;
            Assert.AreEqual(wait, res);
        }
    }
}