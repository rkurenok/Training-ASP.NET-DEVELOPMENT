using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Рома", 20, "M", 95);
            Console.WriteLine(man.ToString());

            Console.WriteLine(new string('-', 20));

            Student student = new Student("Никита", 19, "M", 83, 3);
            Console.WriteLine(student.ToString());

            Console.WriteLine(new string('-', 20));

            student.IncreasingStudyYear(2);
            Console.WriteLine(student.ToString());

            Console.WriteLine(new string('-', 20));

            Teacher teacher = new Teacher("Константин", 44, "M", 90, "ООП", 21);
            Console.WriteLine(teacher.ToString());

            Console.ReadKey();
        }
    }
}
