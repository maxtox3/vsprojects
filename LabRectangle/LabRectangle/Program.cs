using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle x = new Rectangle();
            Console.WriteLine("Площадь фигуры:" + x.getArea());

            Rectangle y = new Rectangle(1, 2);
            Console.WriteLine("Площадь второй фигуры :" + y.getArea());
        }
    }


    class Rectangle
    {

        private int lenght;
        private int width;

        public Rectangle(int lenght, int width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public Rectangle()
        {
            this.width = 1;
            this.lenght = 1;
        }

        public int getArea()
        {
            return lenght * width;
        }
    }
}
