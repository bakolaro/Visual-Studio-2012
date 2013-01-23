using System;

public class GetMax
{
    public static void Main()
    {
        Console.Write("A short integer, x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("A short integer, y = ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("A short integer, z = ");
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine("Max = " + GetMaxInteger(GetMaxInteger(x, y), z));
    }
    public static int GetMaxInteger(int a, int b)
    {
        if (a < b)
        {
            return b;
        }
        return a;
    }
}