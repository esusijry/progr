using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 5];
            var rnd = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1, 10); // используем числа 1-9 для удобства
                }
            }

            PrintArray(a);

            // Вычисление произведения нечетных элементов для каждой строки
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int product = 1;
                bool hasOdd = false;

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 != 0)
                    {
                        product *= a[i, j];
                        hasOdd = true;
                    }
                }

                if (hasOdd)
                {
                    Console.WriteLine($"Строка {i}, произведение нечетных элементов: {product}");
                }
                else
                {
                    Console.WriteLine($"Строка {i} не содержит нечетных элементов.");
                }
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

