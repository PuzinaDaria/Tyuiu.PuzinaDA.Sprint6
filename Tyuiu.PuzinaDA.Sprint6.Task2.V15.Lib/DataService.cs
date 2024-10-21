using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PuzinaDA.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double z = 0;
            int ind = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (3 * i + 1.2 == 0)
                {
                    res[ind] = 0;
                }
                z = ((2 * Math.Sin(i)) / (3 * i + 1.2)) + Math.Cos(i) - 7 * i * 2;
                z = Math.Round((z), 2);
                res[ind] = z;
                ind++;
            }
            return res;
        }
    }
}
