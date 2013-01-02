using System;

class QuadronacciRectangle
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();
        string fourth = Console.ReadLine();
        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int count = (R * C > 4 ? R * C: 4);
        long[] sequence = new long[count];
        sequence[0] = long.Parse(first);
        sequence[1] = long.Parse(second);
        sequence[2] = long.Parse(third);
        sequence[3] = long.Parse(fourth);
        for (int i = 4; i < count; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3] + sequence[i - 4];
        }
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C - 1; j++)
            {
                Console.Write("{0} ", sequence[i * C + j]);
            }
            Console.WriteLine("{0}", sequence[i * C + C - 1]);
        }
    }
}