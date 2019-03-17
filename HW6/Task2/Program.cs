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
            Flowers[] bouquet = new Flowers[] {
                new Rose("Rose", 11),
                new Carnation(),
                new Tulip("Tulip", 11),
                new Orhid() };

            double totalPrice = 0;

            Console.WriteLine("Ваш букет: ");
            foreach (var i in bouquet)
            {
                Console.WriteLine("{0}, цена: {1}", i.Name, i.GetPrice());
                totalPrice += i.GetPrice();
            }

            Console.WriteLine("Общая стоимость: {0}р", totalPrice);

            Console.ReadKey();
        }
    }
}
