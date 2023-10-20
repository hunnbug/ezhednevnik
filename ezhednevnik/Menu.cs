using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ezhednevnik
{
    internal class Menu
    {
        public static int Strelki()
        {
            int pos = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != 3)
                {
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow && pos != 5)
                {
                    pos++;
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
