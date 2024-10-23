using Tyuiu.PuzinaDA.Sprint6.Task4.V13.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { -9.10, 1.55, 292.78, -0.57, -0.35, 2.00, 4.35, 4.57, -288.78, 2.45, 13.10 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}