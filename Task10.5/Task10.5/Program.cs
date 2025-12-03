using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            int a = m;
            int b = n;

            Console.WriteLine("\nКвадраты:");

            while (a > 0 && b > 0)
            {
                if (a > b)
                {
                    int count = a / b;
                    Console.WriteLine($"Размер квадрата: {b} × {b}, количество: {count}");
                    a = a % b;
                }
                else
                {
                    int count = b / a;
                    Console.WriteLine($"Размер квадрата: {a} × {a}, количество: {count}");
                    b = b % a;
                }
            }
        }
    }
 }
