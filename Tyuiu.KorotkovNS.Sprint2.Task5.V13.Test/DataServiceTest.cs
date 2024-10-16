using Tyuiu.KorotkovNS.Sprint2.Task5.V13.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 2016;
            int m = 10;
            int n = 18;

            Assert.AreEqual("19.10.2016", ds.FindDateOfNextDay(g, m, n));


        }
    }
}