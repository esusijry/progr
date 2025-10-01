using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine ("Введите трехзначное число");

            var n = int.Parse(Console.ReadLine());

            var hundreds = n / 100;
            var tents = (n / 10) % 10;
            var units = n % 10;

            var result = hundreds + tents * 10 + units * 100;
            Console.WriteLine("Ответ: " + result);

        }

        static int InputInteger(string message)
        { 
            
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
