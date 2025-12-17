using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 5];
            var rnd = new Random();


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(100);
                }
            }

            PrintArray(a);


            Console.Write("Введите число для проверки: ");
            int number = int.Parse(Console.ReadLine());


            bool found = false;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < number)
                    {
                        Console.WriteLine($"Элемент меньше {number} найден на строке {i}, столбце {j}: {a[i, j]}");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"Элементов меньше {number} в массиве нет.");
            }
        }

        static void PrintArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

