using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Teacher: Man
    {

        public string NameSubject { get; set; }
        public double Experience { get; set; }

        public Teacher(string name, int age, string sex, double weight, string nameSubject, double experience) : base(name, age, sex, weight)
        {
            NameSubject = nameSubject;
            Experience = experience;
        }

        public override string ToString()
        {
            return "Имя: " + Name + "\nВозраст: " + Age + "\nПол: " + Sex + "\nВес: " + Weight + "\nНазвание предмета: " + NameSubject + "\nСтаж преподавания: " + Experience;
        }
    }
}
