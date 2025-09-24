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
            Console.WriteLine("Введите длину стороны правильного икосаэдра");
            double a = double.Parse(Console.ReadLine());

            double S = 5 * Math.Sqrt(3) * a * a;
            double V = (5.0 / 12.0) * (3 + Math.Sqrt(5)) * a * a * a;

            Console.WriteLine($"Площадь поверхности: {S}");
            Console.WriteLine($"Объем: {V}");
        }
    }
}
