using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwwork_14._3
{
    internal static class ConsoleEnter
    {

        public static bool CheckExit()
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nДля выхода введите Exit!");
            Console.ForegroundColor = def;
            var input = Console.ReadLine();
            return input.Equals("Exit", StringComparison.OrdinalIgnoreCase);
        }

        public static int GetIntNumber(int count)
        {
            while (true)
            {
                Console.WriteLine("\nЧисло от 1 до {0}", count / 2);
                int page;
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out page) && page <= count / 2 && page > 0)
                    return page;

                ConsoleColor def = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не верный ввод!");
                Console.ForegroundColor = def;
            }
        }
    }
}
