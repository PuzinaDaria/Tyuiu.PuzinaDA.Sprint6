using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PuzinaDA.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue+1;
            double[] mass = new double[len];
            double y;
            for (int i = 0; i < len; i++)
            {
                y = Math.Round((3 * startValue + 2 - ((2 * startValue - startValue) / (Math.Cos(startValue) + 1))), 2);
                mass[i] = y;
                startValue++;
            }
            return mass;
        }
    }
}
