using Tyuiu.PuzinaDA.Sprint6.Task7.V25.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V25.csv");
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { { -17, -17, 16, -19, 2, 2, 2, 4, 18, 19 }, { -13, -19, -4, 17, 13, -11, -16, -1, 6, 2 },
            {-19, -19, -6, 7, 3, 11, 8, -16, -9, -8}, {-13, -13, 11, -4, 7, 2, 2, 2, -6, 7}, 
            {-3, 2, 2, 19, 3, -4, 13, -12, -18, 18}, {-19, 18, -18, -3, 11, 3, 9, -13, 13, 2},
            {-19, 18, -4, -6, 2, 14, 12, 2, 18, 2}, {-14, -9, -14, 2, 2, -9, -1, 2, 14, -9},
            {2, -4, -14, 6, 2, 12, 11, 9, 2, 2}, {2, -8, 2, 2, 2, 4, 2, 18, 2, 11} }; 
            CollectionAssert.AreEqual(wait, res);
        }
    }
}