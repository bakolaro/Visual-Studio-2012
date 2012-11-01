using System;

/* Write a program that safely compares floating-point numbers with
 * precision of 0.000001. Examples:(5.3 ; 6.01) --> false;
 * (5.00000001 ; 5.00000003) --> true
 */

class FloatingPointSinglePrecisionComparison
{
   static void Main()
   {
      Console.Write("First floating-point number, x = ");
      double x = double.Parse(Console.ReadLine());
      Console.Write("Second floating-point number, y = ");
      double y = double.Parse(Console.ReadLine());

      bool areEqual = Math.Abs(x - y) < 0.000001;
      Console.WriteLine("({0} ; {1} ) --> {2}", x, y, areEqual);
   }
}
