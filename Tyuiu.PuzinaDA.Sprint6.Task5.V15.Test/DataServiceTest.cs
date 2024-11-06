using Tyuiu.PuzinaDA.Sprint6.Task5.V15.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint6\Tyuiu.PuzinaDA.Sprint6.Task5.V15\bin\Debug\net8.0-windows\InPutFileTask5V15.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = [3.36, 4.13];
            CollectionAssert.AreEqual(res, wait);
        }
    }
}