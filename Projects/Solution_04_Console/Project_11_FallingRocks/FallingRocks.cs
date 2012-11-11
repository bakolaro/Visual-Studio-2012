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

        int rows = Console.WindowHeight * 3;
        int columns = Console.WindowWidth;
        char[,] gameField = ScatterStones(rows, columns);

        for (int i = 0; i < rows; i++)
        {
            string line = string.Empty;
            for (int j = 0; j < columns; j++)
            {
                line += gameField[i, j];
            }
            Console.WriteLine(line);
            Thread.Sleep(150);
        }
    }

    static char[,] ScatterStones(int rows, int columns)
    {
        char[,] gameField = new char[rows, columns];
        char[] stoneTypes = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };

        Random rnd = new Random();
        for (int i = 0; i < 12; i++)
        {
            ClearPathThrough(ref gameField, rnd);
        }
        Scatter(ref gameField, rnd, stoneTypes);
        return gameField;
    }

    static void Scatter(ref char[,] gameField, Random randomFactor, char[] stoneTypes)
    {
        int rows = gameField.GetLength(0);
        int columns = gameField.GetLength(1);
        int area = rows * columns;
        for (int stoneIndex = 0; stoneIndex < stoneTypes.Length; stoneIndex++)
        {
            char stone = stoneTypes[stoneIndex];
            for (int k = 0; k < 24; k++)
            {
                int placeCode = randomFactor.Next(area);
                int x = placeCode / columns;
                int y = placeCode % columns;
                if (gameField[x, y] != 'Y')
                {
                    gameField[x, y] = stone;
                }
            }
        }
    }

    static void ClearPathThrough(ref char[,] gameField, Random randomFactor)
    {
        int rows = gameField.GetLength(0);
        int columns = gameField.GetLength(1);
        char freeTrack = 'Y';

        int position = randomFactor.Next(columns - 2);
        gameField[0, position] = freeTrack;
        gameField[0, position + 1] = freeTrack;
        gameField[0, position + 2] = freeTrack;

        int turn, prevTurn = randomFactor.Next(-1, 2);
        for (int i = 1; i < rows; i++)
        {
            turn = randomFactor.Next(-5 + prevTurn * 4, 6 + prevTurn * 4);
            if (turn > 0)
            {
                turn = 1;
            }
            else if (turn < 0)
            {
                turn = -1;
            }
            prevTurn = turn;
            position += turn;
            if (position < 0)
            {
                position = 0;
                prevTurn = -prevTurn;
            }
            else if (position > columns - 3)
            {
                position = columns - 3;
                prevTurn = -prevTurn;
            }
            gameField[i, position] = freeTrack;
            gameField[i, position + 1] = freeTrack;
            gameField[i, position + 2] = freeTrack;
        }
    }
}
