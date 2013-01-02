using System;

class ExcelColumns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[] idenifier = new char[N];
        for (int i = 0; i < N; i++)
        {
            idenifier[i] = Console.ReadLine()[0];
        }
        long number = 0;
        for (int i = 0; i < N; i++)
        {
            number = number * 26 + (idenifier[i] - 64);
        }
        Console.WriteLine(number);
    }
}
