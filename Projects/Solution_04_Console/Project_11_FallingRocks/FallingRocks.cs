using System;
using System.Threading;
using System.Collections;

class FallingRocks
{
    class Stone
    {
        public static char[] Patterns = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        public static ConsoleColor[] SpeedIndexColors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Cyan, 
                                                ConsoleColor.Green, ConsoleColor.Magenta };
        public char Pattern;
        public int X, Y, Width, SpeedIndex;

        public Stone(char pattern, int x, int y, int width, int speedIndex)
        {
            Pattern = pattern;
            X = x;
            Y = y;
            Width = width;
            SpeedIndex = speedIndex;
        }

        public void Cut()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(new string(' ', Width));
        }

        public void Paste()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = SpeedIndexColors[SpeedIndex];
            Console.Write(new string(Pattern, Width));
            Console.ResetColor();
        }
    }

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

        string dwarf = "(0)";
        int xDwarf = columns / 2 - 1;

        Console.CursorVisible = false;
        Console.Clear();
        Console.SetCursorPosition(xDwarf, rows - 1);
        Console.Write(dwarf);

        int stoneChars = Stone.Patterns.Length;
        int speedCategories = Stone.SpeedIndexColors.Length;
        Random rnd = new Random();
        ArrayList stones = new ArrayList();
        for (int i = 0; i < stoneChars; i++)
        {
            stones.Add(new Stone(Stone.Patterns[i], rnd.Next(columns - 2) + 1, 1, 1, rnd.Next(speedCategories)));
        }
        foreach (Stone stone in stones)
        {
            stone.Paste();
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
                    if (1 < xDwarf)
                    {
                        xDwarf--;
                        Console.SetCursorPosition(xDwarf, rows - 1);
                        Console.Write(dwarf + " ");
                    }
                }
                else if (key.Equals(ConsoleKey.RightArrow))
                {
                    if (xDwarf < columns - 4)
                    {
                        xDwarf++;
                        Console.SetCursorPosition(xDwarf - 1, rows - 1);
                        Console.Write(" " + dwarf);
                    }
                }
                else if (key.Equals(ConsoleKey.Escape))
                {
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("You won {0} points.", cycleCounter);
                    // Flush console input buffer before exit
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
            for (int j = 0; j < stones.Count; j++)
            {
                Stone stone = (Stone)stones[j];
                if (cycleCounter % (stone.SpeedIndex + 1) == 0)
                {
                    if (stone.Y < rows)
                    {
                        stone.Cut();
                        stone.Y++;
                    }
                    if (stone.Y < rows)
                    {
                        stone.Paste();
                    }
                    else
                    {
                        stone.Y = 1;
                        stone.SpeedIndex += rnd.Next(speedCategories);
                        stone.SpeedIndex %= speedCategories;
                    }
                }
            }

            cycleCounter++;
            Console.SetCursorPosition(columns / 2, 0);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.Write(cycleCounter);
            Console.ResetColor();

            foreach (Stone stone in stones)
            {
                if ((stone.Y == rows - 1) && (xDwarf < stone.X + stone.Width) && (xDwarf + 3 > stone.X))
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("You won {0} points.", cycleCounter);
                    return;
                }
            }
        }
    }
}
