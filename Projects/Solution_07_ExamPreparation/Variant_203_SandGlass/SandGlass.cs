using System;

class SandGlass
{
    static void Main()
    {
        // Input data - odd integer between 3 and 101
        int n = int.Parse(Console.ReadLine());
        // Calculate and output data
        for (int i = 0, j = 0; i < n / 2; i++, j += 2)
        {
            string backGround = new string('.', i);
            string sandGlass = new string('*', n - j);
            Console.WriteLine(backGround + sandGlass + backGround);
        }
        for (int i = 0, j = 1; i <= n / 2; i++, j += 2)
        {
            string backGround = new string('.', n / 2 - i);
            string sandGlass = new string('*', j);
            Console.WriteLine(backGround + sandGlass + backGround);
        }
    }
}