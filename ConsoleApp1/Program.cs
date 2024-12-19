using System.Data.Common;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            string line;
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V13.txt");
            using (StreamReader sr = new StreamReader(path))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    string[] mass = line.Split(' ');
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i == mass.Length - 2)
                        {
                            res = res + mass[i] + Environment.NewLine;
                        }
                    }
                }

            }
            Console.WriteLine(res);

        }
    }
}
