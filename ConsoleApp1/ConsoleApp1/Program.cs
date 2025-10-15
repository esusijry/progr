using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Calculate(1, 1, 2) + Calculate(2, 2, 2) + Calculate(3, 3, 5) + Calculate(4, 4, 3);
            Console.WriteLine(a);
        }
        static double Calculate(double x, double y, double f ) =>
            (x + Math.Exp(-y)) / f;
    }
}
