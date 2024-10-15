using Tyuiu.KorotkovNS.Sprint2.Task7.V12.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);

        }


        
    }
}