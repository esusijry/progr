using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите натуральное число: ");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            if (n == 0)
            {
                Console.WriteLine("Число не должно быть равно 0");
                return;
            }

            int sum = 0;
            
            while (n > 0)
            {
                int a = n % 10; 
                sum += a;            
                n /= 10;            
            }

            Console.WriteLine($"Сумма цифр: {sum}");
        }
    }
}
