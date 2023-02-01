using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solo_11
{
    class Game
    {
        public static int G(ConsoleKeyInfo keyInfo, int time)
        {
            Random t = new Random();
            Random upleterRandom = new Random();
            int res = t.Next(1, 39);
            char upLeter = (char)upleterRandom.Next(65, 90);

            Sumbol sumbol = new Sumbol(upLeter);

            SetLetters let = new SetLetters(res, t.Next(1, 19), sumbol.UpLeter(upLeter));
            int userCount = 0;
            
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                int count = 1;
                do
                {
                    while (!Console.KeyAvailable && count < 20)
                    {
                        Console.Clear();
                        let.PrintLeterPosition(res, count, sumbol.UpLeter(upLeter));
                        Thread.Sleep(time);
                        count++;
                        if(count == 20)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.WriteLine("Game over");
                            Console.SetCursorPosition(50, 12);
                            Console.WriteLine($"Вы угадали {userCount}");
                        }
                        
                    }
                    keyInfo = Console.ReadKey(true);
                    Console.WriteLine(keyInfo.KeyChar);
                    if(keyInfo.KeyChar == sumbol.UpLeter(upLeter))
                    {
                        Console.WriteLine(keyInfo.KeyChar);
                        userCount++;
                        upLeter = (char)upleterRandom.Next(0x0041, 0x005A);
                        res = t.Next(1, 39);
                        break;
                    }
                    if(keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(50, 10);
                        Console.WriteLine("Game over");
                        Console.SetCursorPosition(50, 10);
                        Console.WriteLine($"Вы угадали {userCount}");
                        Console.ReadLine();
                    }
                } while (keyInfo.Key != ConsoleKey.Escape);
            }
            return userCount;
            
        }
    }
}
