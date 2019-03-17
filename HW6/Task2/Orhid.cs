using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Orhid: Flowers
    {
        public Orhid() : this("Orhid", 3)
        { }

        public Orhid(string name, int numberFlowers) : base(name, numberFlowers)
        { }

        public override double GetPrice()
        {
            return NumberFlowers * 17;
        }
    }
}
