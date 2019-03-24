using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Лениво дышит полдень мглистый, лениво катится река...";
            Console.WriteLine(str);

            Console.WriteLine(new string('-', 20));

            StringSplit txt = new StringSplit(str);

            Console.WriteLine("Выделяем различные слова:");

            string[] words = txt.GetWords();

            txt.PrintWords(words);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Различные слова и частота встречаемости:");

            string wordsWithCount = txt.GetWordsWithCount();

            txt.PrintWordsWithCount(wordsWithCount);

            Console.ReadKey();
        }
    }
}
