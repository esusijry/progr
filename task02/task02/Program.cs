using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            var c = double.Parse(Console.ReadLine());

            var A = (a + b + c) / 3;
            var G = Math.Pow(a * b *c, 1.0 / 3.0);

            Console.WriteLine("Среднее арифметическое: " + A);
            Console.WriteLine("Среднее геометрическое: " + G);
        }
    }
}
