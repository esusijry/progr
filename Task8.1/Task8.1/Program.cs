using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число m:");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число n:");
            var n = int.Parse(Console.ReadLine());

            if (Multiplicity(m, n))
                Console.WriteLine("Числа удовлетворяют условию");
            else Console.WriteLine("Числа не удовлетворяют условию");
        }

        static bool Multiplicity(int m, int n) => ((m * n) % 5 == 0) && ((m + n) % 5 != 0);
    }
}
