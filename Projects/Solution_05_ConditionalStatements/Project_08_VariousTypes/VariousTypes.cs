using System;
using System.Globalization;
using System.Threading;

class VariousTypes
{
    static void Main()
    {
        /* Write a program that, depending on the user's choice inputs int, double 
         * or string variable. If the variable is integer or double, increases it 
         * with 1. If the variable is string, appends "*" at its end. The program 
         * must show the value of that variable as a console output. Use switch statement.
         */
		 
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Choose variable type:");
        // Input data
        Console.WriteLine("Press 1 for \"int\".");
        Console.WriteLine("Press 2 for \"double\".");
        Console.WriteLine("Press 3 for \"string\".");
        char choice = Console.ReadKey(true).KeyChar;
        // Calculate
        switch (choice)
        {
            case '1':
                Console.Write("Input an integer, n = ");
                int n = int.Parse(Console.ReadLine());
                n++;
                Console.WriteLine("n = {0}", n);
                break;
            case '2':
                Console.Write("Input a real number, x = ");
                double x = double.Parse(Console.ReadLine());
                x++;
                Console.WriteLine("x = {0:F5}", x);
                break;
            case '3':
                Console.Write("Input a character string, str = ");
                string str = Console.ReadLine();
                str += "*";
                Console.WriteLine("str = {0}", str);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}

