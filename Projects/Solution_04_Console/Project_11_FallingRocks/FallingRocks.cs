using System;
using System.Threading;
using System.Collections;

class FallingRocks
{
    class Stones
    {
        public static char[] Patterns = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        public static ConsoleColor[] SpeedIndexColors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Cyan, 
                                                ConsoleColor.Green, ConsoleColor.Magenta };
        public static ArrayList Items = new ArrayList();
        public static Random Rand = new Random();

        public static void AddMultipleItemsRandomly(int width, int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                Stones.Items.Add(new Stone(1, width - 2));
            }
        }
    }

    class Stone
    {
        public int X, Y, Width, SpeedIndex, PatternIndex;

        public Stone(int x, int y, int width, int speedIndex, int patternIndex)
        {
            X = x;
            Y = y;
            Width = width;
            SpeedIndex = speedIndex;
            PatternIndex = patternIndex;
        }

        public Stone(int minColumnIndex, int maxColumnIndex)
        {
            Width = Stones.Rand.Next(1, 3);
            X = Stones.Rand.Next(minColumnIndex, maxColumnIndex + 1 - Width);
            Y = 1;
            SpeedIndex = Stones.Rand.Next(Stones.SpeedIndexColors.Length);
            PatternIndex = Stones.Rand.Next(Stones.Patterns.Length);
        }

        public void Cut()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(new string(' ', Width));
        }

        public void Paste()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Stones.SpeedIndexColors[SpeedIndex];
            Console.Write(new string(Stones.Patterns[PatternIndex], Width));
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

        Stones.AddMultipleItemsRandomly(columns, 12);
        foreach (Stone stone in Stones.Items)
        {
            stone.Paste();
        }
        int cycleCounter = 0;
        while (true)
        {
            Thread.Sleep(30);
            
            // Dwarf stands still or moves one step left or one step right
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
                    GameOver(cycleCounter);
                    return;
                }
                // Flush console input buffer
                while (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                }
            }
            
            // Stones are falling
            for (int j = 0; j < Stones.Items.Count; j++)
            {
                Stone stone = (Stone)Stones.Items[j];
                if (cycleCounter % (stone.SpeedIndex + 1) == 0)
                {
                    stone.Cut();
                    stone.Y++;
                    if (stone.Y < rows)
                    {
                        stone.Paste();
                    }
                    else
                    {
                        Stones.Items[j] = new Stone(1, columns - 2);
                    }
                }
            }
            
            // Show results
            cycleCounter++;
            Console.SetCursorPosition(columns / 2, 0);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.Write(cycleCounter);
            Console.ResetColor();

            // New stone
            if (cycleCounter % 200 == 0)
            {
                Stones.Items.Add(new Stone(1, columns - 2));
            }

            // Detect a collision
            foreach (Stone stone in Stones.Items)
            {
                if ((stone.Y == rows - 1) && (xDwarf < stone.X + stone.Width) && (xDwarf + 3 > stone.X))
                {
                    GameOver(cycleCounter);
                    return;
                }
            }
        }
    }

    static void GameOver(int points)
    {
        Thread.Sleep(300);
        Console.Clear();
        Console.WriteLine("Game Over!");
        Console.WriteLine("You won {0} points.", points);
    }
}
