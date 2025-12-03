using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;

            Console.WriteLine("Введите целые числа (0 — конец ввода):");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Ошибка ввода. Введите целое число.");
                    continue;
                }

                if (number == 0)
                    break;

                sum += number;
                count++;
            }

            Console.WriteLine($"\nКоличество введённых чисел (без нуля): {count}");
            Console.WriteLine($"Сумма введённых чисел: {sum}");
        }
    }
}
