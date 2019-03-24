using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>(5);

            list.Add("Roma");
            list.Add("Vlad");
            list.Add("Alina");
            list.Add("Anton");
            list.Insert("Roman", 3);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine(new string('-', 20));

            list.RemoveAt(2);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
