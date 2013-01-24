using System;

class RandomNumbers
{
    /* Write a program that generates and prints to the 
     * console 10 random values in the range [100, 200].
     */
    static void Main()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            double d = rnd.NextDouble() * 100 + 100;
            Console.WriteLine("{0:f4}", d);
        }
    }
}
