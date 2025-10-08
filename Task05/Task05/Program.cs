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
            var a = Calculate(2, 3) + 1/Calculate(5, 7); 
            Console.WriteLine(a);
        }
        static double Calculate(double x, double y) => 
            (Math.Sin(x) + Math.Sin(y)) / (Math.Cos(x) + Math.Cos(y));
    }
}
