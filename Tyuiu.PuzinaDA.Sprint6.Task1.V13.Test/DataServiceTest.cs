using Tyuiu.PuzinaDA.Sprint6.Task1.V13.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            int startValue = -5, stopValue = 5;
            DataService ds = new DataService();
            double[] res =
            { 23.92, 18.88, 13.10, 7.24, 1.80, -8.00, -5.70, -11.26, -17.12, -22.88, -27.92};
            double[] wait = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}