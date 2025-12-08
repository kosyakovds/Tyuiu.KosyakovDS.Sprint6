using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosyakovDS.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] column = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                column[i] = matrix[i, 4];
            }

            Array.Sort(column);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = column[i];
            }

            return matrix;
        }
    }
}
