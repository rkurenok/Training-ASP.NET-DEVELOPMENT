using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student: Man
    {
        public double StudyYear { get; set; }

        public Student(string name, int age, string sex, double weight, double studyYear) : base(name, age, sex, weight)
        {
            StudyYear = studyYear;
        }

        public void IncreasingStudyYear(int increaseYear)
        {
            StudyYear += increaseYear;
        }

        public override string ToString()
        {
            return "Имя: " + Name + "\nВозраст: " + Age + "\nПол: " + Sex + "\nВес: " + Weight + "\nГод обучения: " + StudyYear;
        }
    }
}
