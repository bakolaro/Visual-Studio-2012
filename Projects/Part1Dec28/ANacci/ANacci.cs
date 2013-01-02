using System;

class ANacci
{
    static void Main()
    {
        char first = Console.ReadLine()[0];
        char second = Console.ReadLine()[0];
        int L = int.Parse(Console.ReadLine());

        int count = (L - 1) * 2 + 1; // L >= 1
        char[] letters = new char[count];
        letters[0] = first;
        if (L > 1)
        {
            letters[1] = second;
        }
        for (int i = 2; i < count; i++)
        {
            if (letters[i - 1] - 64 + letters[i - 2] - 64 > 26)
            {
                letters[i] = (char)(letters[i - 1] - 64 + letters[i - 2] - 26);
            }
            else
            {
                letters[i] = (char)(letters[i - 1] - 64 + letters[i - 2]);
            }
        }
        Console.WriteLine(first);
        for (int i = 1, spaces = 0; i < count; i += 2, spaces++)
        {
            Console.WriteLine("{0}" + new string(' ', spaces) + "{1}", letters[i], letters[i + 1]);
        }

    }
}