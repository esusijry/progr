using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, отличное от 0");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Число должно быть больше 0");
                return;
            }

            double sum = 0;

            for (int a = 1; a <= n; a++)
            {
                sum += (double)(a + 1) / a;
            }

            Console.WriteLine($"Сумма выражения 2/1 + 3/2 + ... + (n+1)/n при n = {n} равна {sum}");

        }
    }
}
