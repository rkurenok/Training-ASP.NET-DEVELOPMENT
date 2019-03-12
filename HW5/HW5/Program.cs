using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массивов: ");
            int size = int.Parse(Console.ReadLine());

            string[] array1 = new string[size];
            string[] array2 = new string[size];

            Console.WriteLine("Введите первый массив:");
            CreateArray(array1);

            Console.WriteLine("Введите второй массив:");
            CreateArray(array2);

            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("\nВторой массив:");
            PrintArray(array2);

            Console.WriteLine();

            Console.WriteLine(EqualsArrays(array1, array2));

            Console.ReadLine();
        }

        static void CreateArray(string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                mas[i] = Console.ReadLine();
            }
        }

        static void PrintArray(string[] mas1)
        {
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
        }

        static bool EqualsArrays(string[] mas1, string[] mas2)
        {
            bool isEqual = true;
            int[] temp = new int[mas1.Length];
            int count = 0;

            try
            {
                int[] a = mas1.Select(ch => int.Parse(ch)).ToArray();
                int[] b = mas2.Select(ch => int.Parse(ch)).ToArray();
            }
            catch
            {
                return false;
            }

            int[] mass1 = mas1.Select(ch => int.Parse(ch)).ToArray();
            int[] mass2 = mas2.Select(ch => int.Parse(ch)).ToArray();

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = mass1[i] * mass1[i];
            }

            for (int i = 0; i < mas1.Length; i++)
            {
                for (int j = 0; j < mas2.Length; j++)
                {
                    if (mass2[i] == temp[j])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
                count = 0;
            }

            return isEqual;
        }
    }
}
