using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rose: Flowers
    {
        public Rose() : this("Rose", 11)
        { }

        public Rose(string name, int numberFlowers) : base(name, numberFlowers)
        { }

        public override double GetPrice()
        {
            return NumberFlowers * 3.4;
        }
    }
}
