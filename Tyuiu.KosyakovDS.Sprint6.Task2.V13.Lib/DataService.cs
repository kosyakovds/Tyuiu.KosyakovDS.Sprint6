using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosyakovDS.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double res = Math.Sin(x) + (2.0 * x) / 3.0 - Math.Cos(x) * 4.0 * x;

                mass[index] = Math.Round(res, 2);
                index++;
            }
            return mass;
        }
    }
}
