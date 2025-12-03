using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
