using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив:");
            Print(a);

            Console.Write("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            int[] b = Multiply(a, k);
            Console.WriteLine("Массив после умножения:");
            Print(b);

            double avg = Average(a);
            Console.WriteLine("Среднее арифметическое: " + avg);

            int[] c = Swap(a);
            Console.WriteLine("Массив после обмена:");
            Print(c);
        }

        static void Print(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] Multiply(int[] x, int k)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * k;
            }
            return y;
        }

        static double Average(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum = sum + x[i];
            }
            return (double)sum / x.Length;
        }

        static int[] Swap(int[] x)
        {
            int[] y = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i];
            }

            if (y.Length > 1)
            {
                int t = y[0];
                y[0] = y[y.Length - 1];
                y[y.Length - 1] = t;
            }

            return y;
        }
    }
}
