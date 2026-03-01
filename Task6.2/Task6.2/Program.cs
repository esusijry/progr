using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите слово чемпионат");
           string h = Console.ReadLine();

            string l1 = h.Substring(8, 1); //т
            string l2 = h.Substring(1, 3); //емп
            string l3 = h.Substring(3, 1); //п
            string l4 = h.Substring(5, 2); //он
            string l5 = h.Substring(0, 1); //ч
            string l6 = h.Substring(5, 1); //о

            string wT = l1 + l2;
            string wP = l3 + l4 + l5 + l6;

            Console.WriteLine("Вот что получилось: " + wP + " " + wT);

        }
        }
    }
