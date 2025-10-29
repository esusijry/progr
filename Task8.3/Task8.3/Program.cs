using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._3
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию черного короля");
            var blackKingPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();

            if (blackKingPosition == whiteQueenPosition)
            {
                Console.WriteLine("Фигуры не могут стоять на одной клетке");
                return;
            }

            int blackKingV, blackKingH;
            int whiteQueenV, whiteQueenH;

            DecodePosition(blackKingPosition, out blackKingV, out blackKingH);
            DecodePosition(whiteQueenPosition, out whiteQueenV, out whiteQueenH);

            // Проверка диапазона позиций
            if (blackKingV < 1 || blackKingV > 8 || blackKingH < 1 || blackKingH > 8 ||
                whiteQueenV < 1 || whiteQueenV > 8 || whiteQueenH < 1 || whiteQueenH > 8)
            {
                Console.WriteLine("Недопустимая позиция");
                return;
            }

            bool queenAttacksKing = IsUnderStrikeByQueen(blackKingPosition, whiteQueenPosition);
            bool kingAttacksQueen = IsUnderStrikeByKing(whiteQueenPosition, blackKingPosition);

            if (queenAttacksKing && kingAttacksQueen || queenAttacksKing || kingAttacksQueen)
                Console.WriteLine("Фигура находится под боем другой");
            else
                Console.WriteLine("Фигуры не бьют друг друга");
        }

        static void DecodePosition(string position, out int vert, out int hor)
        {
            position = position.ToLower();
            vert = (int)position[0] - 0x60; // 'a' -> 1, 'b' -> 2 ...
            hor = int.Parse(position[1].ToString());
        }

        static bool IsUnderStrikeByQueen(string position, string queenPosition)
        {
            int qV, qH, kV, kH;
            DecodePosition(position, out qV, out qH);
            DecodePosition(queenPosition, out kV, out kH);

            return qV == kV || qH == kH || Math.Abs(qV - kV) == Math.Abs(qH - kH);
        }

        static bool IsUnderStrikeByKing(string position, string kingPosition)
        {
            int qV, qH, kV, kH;
            DecodePosition(position, out qV, out qH);
            DecodePosition(kingPosition, out kV, out kH);

            return Math.Abs(qV - kV) <= 1 && Math.Abs(qH - kH) <= 1;
        }
    }
}