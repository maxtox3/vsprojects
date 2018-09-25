using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> di = new Dictionary<int, string>();
            for(int i = 0; i < 10; i++)
            {
                di.Add(i, i + "a");
            }

            foreach(KeyValuePair<int, string> keyValue in di)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.ReadLine();
        }
    }
}
