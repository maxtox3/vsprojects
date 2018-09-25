using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIntToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите значения х:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение х(1) = {0}", x);


            Console.WriteLine("Введите значения х:");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Значение х(2) = {0}", x);

            Console.WriteLine("Введите значения х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение х(3) = {0}", x);

            float f = 1234.4F;
            x = (int)f;
            Console.WriteLine("После преобразования х(4) = {0}", x);
            Console.ReadLine();

        }
    }
}
