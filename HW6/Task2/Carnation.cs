using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Carnation: Flowers
    {
        public Carnation() : this("Carnation", 1)
        { }

        public Carnation(string name, int numberFlowers) : base(name, numberFlowers)
        { }

        public override double GetPrice()
        {
            return NumberFlowers * 2;
        }
    }
}
