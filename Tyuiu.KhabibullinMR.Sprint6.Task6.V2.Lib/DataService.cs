using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhabibullinMR.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string str = "";
            

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] res = new string[line.Split(' ').Length];
                    res = line.Split(' ');
                    if (res.Length > 1)
                    {
                        str += res[1] + " ";
                    }
                    
                    //str += Convert.ToString(line.Split(' ').Length);

                    
                }
            }
            return str;
        }
    }
}
