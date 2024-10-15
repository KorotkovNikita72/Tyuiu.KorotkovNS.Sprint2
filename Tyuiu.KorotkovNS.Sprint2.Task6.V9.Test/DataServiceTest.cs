using Tyuiu.KorotkovNS.Sprint2.Task6.V9.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int n = 9;
            int m = 11;

            Assert.AreEqual("10.11", ds.FindDateOfNextDay(m, n));
        }
    }
}