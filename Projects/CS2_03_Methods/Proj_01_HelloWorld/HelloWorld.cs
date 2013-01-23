using System;

public class HelloWorld
{
    public static void Main()
    {
        Hello();
    }
    public static void Hello()
    {
        Console.Write("Your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}
