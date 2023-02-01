using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo = default;
            PrintPole.Print();
            //Game.G(keyInfo, 500);
            Console.WriteLine("Введите уровень 0 - 1  - 2");
            int level = int.Parse(Console.ReadLine());
            if (level == 0)
                Game.G(keyInfo, Complicat.Level(level));
            else if(level == 1)
                Game.G(keyInfo, Complicat.Level(level));
            else if (level == 2)
                Game.G(keyInfo, Complicat.Level(level));
        }
    }
}
