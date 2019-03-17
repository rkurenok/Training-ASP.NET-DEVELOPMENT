using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Tulip: Flowers
    {
        public Tulip() : this("Tulip", 9)
        { }

        public Tulip(string name, int numberFlowers) : base(name, numberFlowers)
        { }

        public override double GetPrice()
        {
            return NumberFlowers * 0.9;
        }
    }
}
