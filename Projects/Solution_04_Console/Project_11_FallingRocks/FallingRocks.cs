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

        int columns = Console.WindowWidth;
        int rows = Console.WindowHeight;
        char[,] matrix = new char[rows, columns];
        
        char[] stones = {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';'};
        string dwarf = "(0)";
        int xDwarf = columns / 2;
        int[] xStones = { 1, 64, 6, 39, 51, 14, 18, 72, 27, 36, 45 };
        int[] yStones = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[] stoneSpeeds = { 1, 2, 3, 3, 3, 4, 5, 1, 1, 1, 2 };
        ConsoleColor[] stoneColors = { ConsoleColor.Green, ConsoleColor.Yellow,
                                         ConsoleColor.Cyan, ConsoleColor.Cyan,ConsoleColor.Cyan,
                                         ConsoleColor.Magenta, ConsoleColor.Red,
                                         ConsoleColor.Green, ConsoleColor.Green, ConsoleColor.Green, ConsoleColor.Yellow };

        Console.CursorVisible = false;
        Console.Clear();
        Console.SetCursorPosition(xDwarf - 1, rows - 1);
        Console.Write(dwarf);
        for (int i = 0; i < stones.Length; i++)
        {
            Console.SetCursorPosition(xStones[i], yStones[i]);
            Console.ForegroundColor = stoneColors[i];
            Console.Write(stones[i]);
            Console.ResetColor();
        }
        int cycleCounter = 0;
        while (true)
        {
            Thread.Sleep(30);
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key.Equals(ConsoleKey.LeftArrow))
                {
                    if (2 < xDwarf)
                    {
                        xDwarf--;
                        Console.SetCursorPosition(xDwarf - 1, rows - 1);
                        Console.Write(dwarf + " ");
                    }
                }
                else if (key.Equals(ConsoleKey.RightArrow))
                {
                    if (xDwarf < columns - 3)
                    {
                        xDwarf++;
                        Console.SetCursorPosition(xDwarf - 2, rows - 1);
                        Console.Write(" " + dwarf);
                    }
                }
                else if (key.Equals(ConsoleKey.Escape))
                {
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("You won {0} points.", cycleCounter);
                    // Flush console input buffer
                    while (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true).Key;
                    }
                    return;
                }
                // Flush console input buffer
                while (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                }
            }
            for (int j = 0; j < stones.Length; j++)
            {
                if (cycleCounter % stoneSpeeds[j] == 0)
                {
                    if (yStones[j] < rows)
                    {
                        Console.SetCursorPosition(xStones[j], yStones[j]);
                        Console.Write(" ");
                        yStones[j]++;
                    }
                    if (yStones[j] < rows)
                    {
                        Console.SetCursorPosition(xStones[j], yStones[j]);
                        Console.ForegroundColor = stoneColors[j];
                        Console.Write(stones[j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        yStones[j] = 0;
                    }
                }
            }
            cycleCounter++;
            Console.SetCursorPosition(columns / 2, 0);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.Write(cycleCounter);
            Console.ResetColor();
        }
    }
}
