using System;

/* Create a program that assigns null values to an integer and to
 * double variables. Try to print them on the console, try to add
 * some values or the null literal to them and see the result.
 */

class NullableVariables
{
   static void Main()
   {
      int? n = null;
      double? x = null;
      Console.WriteLine("n = {0}, x = {1}", n, x);
      n += 100;
      x += 1.95;
      Console.WriteLine("n = {0}, x = {1}", n, x);
      n = 100;
      x = 1.95;
      Console.WriteLine("n = {0}, x = {1}", n, x);
      n += null;
      x += null;
      Console.WriteLine("n = {0}, x = {1}", n, x);
   }
}

