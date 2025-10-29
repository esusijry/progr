using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"f({x:F2}) = {F(x):F2}");
        }

    static double F(double x)
     {
            if (x<-2) 
                return Math.Sqrt(x*x + 4);
            else if (x >= -2 && x <= 1)
                return 1/(x*x + 1);
            else 
                return Math.Sqrt(x * x - 1);
     }
    }
}
