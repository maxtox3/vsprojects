using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabString
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = " world!";
            Console.WriteLine($"{hello}, {world}");
            StringBuilder sb = new StringBuilder();
            sb.Append(hello);
            sb.Append(", ");
            sb.Append(world);
            Console.WriteLine(sb);
            Console.WriteLine(String.Format("в {0} - {1:hh:mm}", world, DateTime.Now));
            Console.ReadLine();
        }
    }
}
