using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            foreach (int o in list)
            {
                if ((o%2) == 0)
                {
                    Console.WriteLine(o);
                }
            }

            Console.ReadLine();
        }
    }
}
