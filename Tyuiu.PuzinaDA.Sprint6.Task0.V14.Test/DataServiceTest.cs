using Tyuiu.PuzinaDA.Sprint6.Task0.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = -0.444;
            Assert.AreEqual(res, wait);
        }
    }
}