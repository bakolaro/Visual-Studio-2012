using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
            int lastDigit = K % 10;
            int prevDigits = K / 10;
            K /= 10;
            while(K > 0)
            {
                K /= 10;
                lastDigit *= 10;
            }
            K = lastDigit + prevDigits;
        }

        Console.WriteLine(K);
    }
}