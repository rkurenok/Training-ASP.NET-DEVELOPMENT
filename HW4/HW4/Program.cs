using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Из скольки цифр состоят числа, образующие последовательность?");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последовательность:");
            string sequence = Console.ReadLine();

            List<string> list = SplitString(sequence, number);

            int[] array = new int[list.Count];
            array = ConvertStrtoInt(list, array);

            Console.WriteLine(PrintNumber(array));

            Console.ReadLine();
        }

        static List<string> SplitString(string str, int num)
        {
            List<string> list = new List<string>();
            int count = 0;

            while (count < str.Length)
            {
                list.Add(str.Substring(count, num));
                count += num;
            }
            return list;
        }

        static int[] ConvertStrtoInt(List<string> str, int[] array)
        {
            string[] temp = new string[str.Count];

            for (int i = 0; i < str.Count; i++)
            {
                temp[i] = Convert.ToString(str[i]);
                int d = Convert.ToInt32(temp[i]);
                array[i] = d;
            }
            return array;
        }

        static string PrintNumber(int[] array)
        {
            int[] missingNumbers = Enumerable.Range(array[0], array[array.Length - 1]).Except(array).ToArray();

            if (missingNumbers.Length == 1)
            {
                return missingNumbers[0].ToString();
            }
            else
            {
                return "-1";
            }
        }
    }
}
