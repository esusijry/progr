using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam__23
{
    internal class Program
    {
        static void Main()
        {
            int sum = 0;

            for (int p = 1; p < 500; p++)
            {
                if (PrimeNumber(p))
                {
                    int fp = F(p);
                    sum += fp;
                }
            }

            Console.WriteLine("Сумма всех F(p) для p < 500 = " + sum);
        }

        static bool PrimeNumber(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static int F(int p)
        {
            int count = 0;

            for (int x = 1; x < p; x++)
            {
                for (int y = 1; y < p; y++)
                {
                    for (int z = 1; z < p; z++)
                    {
                        int left = (x * x * x + y * y * y) % p;
                        int right = (z * z * z) % p;

                        if (left == right)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
