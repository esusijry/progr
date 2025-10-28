using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абсциссу:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату");
            var y = int.Parse(Console.ReadLine());

            if (IsInArea(x, y))
                Console.WriteLine("Точка лежит в области");
            else Console.WriteLine("Точка не лежит в области");
        }

        static bool IsInArea(double x, double y) => y >= 1 || y <= -3;
    }
}
