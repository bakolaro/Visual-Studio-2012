using System;

class SevenlandNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int k = ConvertToInt(input);
        string output = ConvertToString(k + 1);
        Console.WriteLine(output);
    }

    public static int ConvertToInt(string number)
    {
        int n = 0;
        for (int i = 0; i < number.Length; i++)
		{
			 n = n * 7 + number[i] - 48;
		}
        return n;
    }

    public static string ConvertToString(int number)
    {
        string n = "";
        while (number > 0)
        {
            n = (number % 7) + n;
            number /= 7;
        }
        return n;
    }
}

