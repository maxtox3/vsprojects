using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack x = new Stack();
            x.Push("a");
            x.Push("b");
            x.Push("d");
            x.Push("g");
            x.Push("j");
            Console.WriteLine("Количество элемкентов до : " + x.Count);
            Console.WriteLine(x.Peek());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine("Количество элемкентов  : " + x.Count);
            
            Console.ReadLine();
        }
    }
}
