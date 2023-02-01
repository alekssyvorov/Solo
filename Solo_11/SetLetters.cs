using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_11
{
    class SetLetters
    {
        int x;
        int y = 2;
        char leter;

        public SetLetters(int x, int y, char leter)
        {
            this.x = x;
            this.y = y;
            this.leter = leter;
        }

        public void PrintLeterPosition(int x, int y, char leter)
        {
            PrintPole.Print();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(leter);
        }
    }
}
