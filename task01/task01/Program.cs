using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Бальмонт К.Д.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Люба мне буква «Ка»…");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Люба мне буква «Ка»,");
            Console.WriteLine("Вокруг неё сияет бисер.");
            Console.WriteLine("Пусть вечно светит свет венца");
            Console.WriteLine("Бойцам Каплан и Каннегисер.");

            Console.WriteLine();

            Console.WriteLine("И да запомнят все, в ком есть");
            Console.WriteLine("Любовь к родимой, честь во взгляде,");
            Console.WriteLine("Отмстили попранную честь");
            Console.WriteLine("Борцы Коверда и Конради.");

            Console.ResetColor();
        }
    }
}
