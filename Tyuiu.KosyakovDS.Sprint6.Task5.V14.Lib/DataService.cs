using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosyakovDS.Sprint6.Task5.V14.Lib
{
    public class DataService : ISprint6Task5V14
    {
        public double[] LoadFromDataFile(string path)
        {
            List <double> result = new List<double>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');

                    foreach (string number in numbers)
                    {
                        double num = double.Parse(number.Replace('.', ','));
                        if (num >= 10)
                        {
                            result.Add(num);
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
