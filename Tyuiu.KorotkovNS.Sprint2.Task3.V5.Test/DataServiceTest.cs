using Tyuiu.KorotkovNS.Sprint2.Task3.V5.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
           DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.083;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            double x = -4;
            double res = ds.Calculate(x);
            double wait = 0.001;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidExpression4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = -1100.01;
            Assert.AreEqual(wait, res);
        }
    }
}