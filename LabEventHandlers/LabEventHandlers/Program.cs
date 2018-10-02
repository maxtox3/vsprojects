using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEventHandlers
{
    class Program
    {
        static void Main(string[] args)
        {

            Student x = new Student(12, "иванов", "иван");
            Student y = new Student(13, "иванов1", "иван1");

            x.changeAge += meEventHandler;
            y.changeAge += meEventHandler;

            Console.ReadLine();
            x.Age = 25;
            Console.WriteLine(x.getFullName());
            Console.ReadLine();
            y.Age = 26;
            Console.WriteLine(y.getFullName());
            Console.ReadLine();
            x.Age = 28;

            Console.WriteLine(x.getFullName());
            Console.ReadLine();
            y.Age = 80;

            Console.WriteLine(y.getFullName());
            Console.ReadLine();
        }

        private static void meEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("ТАДАМ! СМЕрТЬ ВсЕ БлИЖе");
        }
    }

    class Student
    {
        public event EventHandler changeAge;

        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value > age)
                {
                    age = value;
                    if (changeAge != null)
                        changeAge(this, EventArgs.Empty);
                }
            }
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }

        public string getFullName()
        {
            return Name + " " + Surname + " " + Age;
        }
    }
}
