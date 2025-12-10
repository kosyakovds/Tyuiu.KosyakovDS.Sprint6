using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosyakovDS.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * x - 3) / (Math.Cos(x) + x) + 5, 2);
                valueArray[cnt++] = y;
            }

            return valueArray;
        }
    }
}
