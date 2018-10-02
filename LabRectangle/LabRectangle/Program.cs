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
            Console.WriteLine("Введите значение длины : ");
            int lenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение ширины : ");
            int width = int.Parse(Console.ReadLine());
            Rectangle x = new Rectangle(lenght, width);
            Console.WriteLine("Площадь введенной вами фигуры: " + x.getArea());

            Rectangle y = new Rectangle(1, 2);
            Console.WriteLine("Площадь второй фигуры :" + y.getArea());
            Console.ReadLine();
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
