using System;

class GreatestOf5Vars
{
    static void Main()
    {
        /* Write a program that finds the greatest of given 5 variables. */

        // About
        Console.WriteLine("Greatest of 5 variables:");
        // Input data
        double[] vars = new double[5];
        for (int i = 0; i < vars.Length; i++)
        {
            Console.Write("Variable[{0}] = ", i);
            vars[i] = double.Parse(Console.ReadLine());
        }
        // Calculate
        double greatest = double.MinValue;
        for (int i = 0; i < vars.Length; i++)
        {
            if (greatest < vars[i])
            {
                greatest = vars[i];
            }
        }
        // Output data
        Console.WriteLine("The greatest of these 5 numbers is {0:F4}.", greatest);
    }
}
