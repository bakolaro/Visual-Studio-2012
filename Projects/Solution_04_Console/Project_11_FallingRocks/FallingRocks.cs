using System;
using System.Threading;

class FallingRocks
{
    static void Main()
    {
        /* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the
         * bottom of the screen and can move left and right (by the arrows keys). A number of rocks
         * of different sizes and forms constantly fall down and you need to avoid a crash. Rocks are 
         * the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The
         * dwarf is (O). Ensure a constant game speed by Thread.Sleep(150). Implement collision 
         * detection and scoring system.
         */

        int x = Console.WindowWidth; 
        int y = Console.WindowHeight;

        int[,] window = new int[x, y];

        int maxRows = 100;
        int[,] gameField = new int[maxRows, y];

        int dwarf = x / 2 - 1;
        int idRow = 0;
        Random rnd = new Random();
        Console.WriteLine("Falling Rocks, window: {0} x {1}", x, y);
        Thread.Sleep(150);
        Console.Clear();
        while (true)
        {
            int xPosition = rnd.Next(0, x - 1);
            gameField[idRow, xPosition] = 1;
            idRow++;

            Console.MoveBufferArea(0, 0, x, y, 0, 1);
            Console.SetCursorPosition(xPosition, 0);
            Console.Write("*");
            Console.SetCursorPosition(dwarf, y - 1);

            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key.Equals(ConsoleKey.Escape))
                {
                    break;
                }
                else if (key.Equals(ConsoleKey.LeftArrow))
                {
                    dwarf--;
                }
                else if (key.Equals(ConsoleKey.RightArrow))
                {
                    dwarf++;
                }
                if (dwarf < 0)
                {
                    dwarf = 0;
                }
                else if (dwarf >= x)
                {
                    dwarf = x - 1;
                }
            }
            Thread.Sleep(150);
        }
        Console.Clear();
    }
}
