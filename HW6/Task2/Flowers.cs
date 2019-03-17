using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Flowers
    {
        public string Name { get; set; }

        public int NumberFlowers { get; set; }

        public Flowers(string name, int numberFlowers)
        {
            Name = name;
            NumberFlowers = numberFlowers;
        }

        public abstract double GetPrice();
    }
}
