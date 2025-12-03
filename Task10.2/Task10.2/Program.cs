using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            if (n <= 1)
            {
                Console.WriteLine("Число n должно быть натуральным числом (n > 1)");
                return;
            }

            double[] a = new double[n + 2];
            Console.WriteLine($"Введите {n + 2} положительных чисел a0, a1,..., an:");

            for (int i = 0; i <= n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out a[i]) || a[i] <= 0)
                {
                    Console.WriteLine("Ошибка: числа должны быть положительными.");
                    return;
                }
            }

            double product = 1.0;
            Console.WriteLine("\nСредние геометрические:");

            for (int i = 0; i <= n; i++)
            {
                product *= a[i];
                double geomMean = Math.Pow(product, 1.0 / (i + 1));
                Console.WriteLine($"Для i = {i}: {geomMean}");
            }
        }
    }
}
