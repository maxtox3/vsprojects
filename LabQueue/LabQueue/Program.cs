using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            for( int i = 0; i < 100; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("Размер очереди : {0}", queue.Count());
            Console.ReadLine();

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();
                if( x%2 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            Console.WriteLine("Размер очереди : {0}", queue.Count());
            Console.ReadLine();
        }
    }
}
