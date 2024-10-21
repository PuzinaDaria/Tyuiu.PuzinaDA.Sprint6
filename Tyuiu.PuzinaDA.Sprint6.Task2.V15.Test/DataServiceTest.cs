using Tyuiu.PuzinaDA.Sprint6.Task2.V15.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task2.V15.Test
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
            double[] wait = {70.14, 55.21, 41.05, 27.96, 15.48, 1.00, -13.06, -28.16, -42.96, -56.77, -69.83};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}