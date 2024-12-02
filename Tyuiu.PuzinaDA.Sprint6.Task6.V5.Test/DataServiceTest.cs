using Tyuiu.PuzinaDA.Sprint6.Task6.V5.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string str = "l";
            string path = "InPutDataFileTask6V5.txt";
            string wait = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";
            string res = ds.CollectTextFromFile(str, path);
            Assert.AreEqual(wait, res);
        }
    }
}