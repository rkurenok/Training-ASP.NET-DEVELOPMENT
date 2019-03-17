using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; }
        public double Weight { get; set; }

        public Man(string name, int age, string sex, double weight)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Weight = weight;
        }

        public override string ToString()
        {
            return "Имя: " + Name + "\nВозраст: " + Age + "\nПол: " + Sex + "\nВес: " + Weight;
        }
    }
}
