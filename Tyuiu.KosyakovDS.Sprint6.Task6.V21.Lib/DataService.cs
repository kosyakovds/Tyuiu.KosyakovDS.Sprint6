using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosyakovDS.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            string str = "g";
            string resStr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains(str))
                        {
                            if (resStr.Length > 0)
                            {
                                resStr += " ";
                            }
                            resStr += word;
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
