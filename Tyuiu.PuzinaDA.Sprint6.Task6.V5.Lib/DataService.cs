using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO;

namespace Tyuiu.PuzinaDA.Sprint6.Task6.V5.Lib;

public class DataService : ISprint6Task6V5
{
    public string CollectTextFromFile(string path)
    {
        string str = "l";
        string resStr = "";
        string word = "";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(str))
                {
                    string[] z = line.Split();
                    for (int i = 0; i < z.Length; i++)
                    {
                        if (z[i].Contains(str))
                        {
                            resStr = resStr + z[i] + " ";
                        }
                    }
                }

            }

        }
        resStr = resStr.Remove(resStr.Length - 1);
        return resStr;
    }
}

