using Tyuiu.PuzinaDA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                {4,  32, -20,  27,  21},
                {17, 15, -1, -2, -1},
                {-3, 18, 12, -10, 29},
                {7, -15, 2, -8, 12},
                {-10, 25, 5, 27, 21}
            };
            int[,] res = ds.Calculate(matrix);
            int[,] wait =
            {
                {4,  32, -20,  27,  -1},
                {17, 15, -1, -2, 12},
                {-3, 18, 12, -10, 21},
                {7, -15, 2, -8, 21},
                {-10, 25, 5, 27, 29}
            };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}