using System;
using System.IO;

public class Sudoku
{
    public int[, ,] Moves = new int[9, 9, 9];
    public int[,] Solution = new int[9, 9];
    public bool[,] Fixed = new bool[9, 9];
    public int Steps;
    public int FixedSteps;
    public Sudoku(string[] lines)
    {
        for (int i = 0; i < 9; i++)
        {
            char[] digits = lines[i].ToCharArray();
            for (int j = 0; j < 9; j++)
            {
                if (digits[j] != '-')
                {
                    this.TurnOff(i, j, digits[j] - 49);
                    this.Fixed[i, j] = true;
                }
            }
        }
        this.FixedSteps = this.Steps;
    }
    public static void Main()
    {
        //string file = "Sudoku.in";
        //string[] lines = File.ReadAllLines(file);
        string[] lines = ReadLinesFromConsole();
        Sudoku s = new Sudoku(lines);
        // 0 = free
        // - = turn off
        // + = turn on
        int i = 0;
        int j = 0;
        int k = 0;
        while (s.Steps < 81)
        {
            if (s.Fixed[i, j] || s.TurnOff(i, j, k))
            {
                if (j < 8)
                {
                    j++;
                }
                else
                {
                    i++;
                    j = 0;
                }
                k = 0;
            }
            else
            {
                do
                {
                    if (k < 8)
                    {
                        k++;
                        break;
                    }
                    else
                    {
                        if (j > 0)
                        {
                            j--;
                        }
                        else
                        {
                            i--;
                            j = 8;
                        }
                        k = s.Solution[i, j] - 1;
                        if (!s.TurnOn(i, j, k))
                        {
                            k = 8;
                        }
                    }
                }
                while (true);
            }
        }
        s.PrintSolution();
    }
    public bool TurnOff(int i, int j, int k)
    {
        if (this.Moves[i, j, k] == 0)
        {
            int step = ++this.Steps;
            this.Moves[i, j, k] = step;
            this.Solution[i, j] = k + 1;
            int a = i / 3 * 3;
            int b = j / 3 * 3;
            for (int x = 0; x < 9; x++)
            {
                if (this.Moves[i, j, x] == 0)
                {
                    this.Moves[i, j, x] = -step;
                }
                if (this.Moves[i, x, k] == 0)
                {
                    this.Moves[i, x, k] = -step;
                }
                if (this.Moves[x, j, k] == 0)
                {
                    this.Moves[x, j, k] = -step;
                }
                if (this.Moves[a + x / 3, b + x % 3, k] == 0)
                {
                    this.Moves[a + x / 3, b + x % 3, k] = -step;
                }
            }
            return true;
        }
        return false;
    }
    public bool TurnOn(int i, int j, int k)
    {
        if (this.Moves[i, j, k] == this.Steps)
        {
            int step = this.Steps--;
            this.Moves[i, j, k] = 0;
            this.Solution[i, j] = 0;
            int a = i / 3 * 3;
            int b = j / 3 * 3;
            for (int x = 0; x < 9; x++)
            {
                if (this.Moves[i, j, x] == -step)
                {
                    this.Moves[i, j, x] = 0;
                }
                if (this.Moves[i, x, k] == -step)
                {
                    this.Moves[i, x, k] = 0;
                }
                if (this.Moves[x, j, k] == -step)
                {
                    this.Moves[x, j, k] = 0;
                }
                if (this.Moves[a + x / 3, b + x % 3, k] == -step)
                {
                    this.Moves[a + x / 3, b + x % 3, k] = 0;
                }
            }
            return true;
        }
        return false;
    }
    public static string[] ReadLinesFromConsole()
    {
        string[] lines = new string[9];
        for (int i = 0; i < 9; i++)
        {
            lines[i] = Console.ReadLine();
        }
        return lines;
    }
    public void PrintSolution()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write("{0}", this.Solution[i, j]);
            }
            Console.WriteLine();
        }
    }
}