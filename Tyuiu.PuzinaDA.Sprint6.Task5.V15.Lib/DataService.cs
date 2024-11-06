using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PuzinaDA.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            };
            int index = 0;
            double[] res = new double[len];
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    res[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            res = res.Where(var => ((var >= 2) && (var <= 7))).ToArray();
            return res;

        }
    }
}
