using System;

/* Write a program to read your age from the console and print how
 * old you will be after 10 years.
 */

class CalculateMyAge
{
   static void Main()
   {
      Console.Write("Your age now(in years) = ");
      int age = int.Parse(Console.ReadLine());
      Console.WriteLine("After 10 years you will turn {0}.", age + 10);
   }
}
