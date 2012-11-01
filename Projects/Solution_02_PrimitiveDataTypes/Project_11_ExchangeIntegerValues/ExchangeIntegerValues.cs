using System;

/* Declare two integer variables and assign them with 5 and 10 and
 * after that exchange their values.
 */

class ExchangeIntegerValues
{
   static void Main()
   {
      int m = 5;
      int n = 10;
      Console.WriteLine("m = {0}, n = {1}", m, n);

      int swap = m;
      m = n;
      n = swap;
      Console.WriteLine("m = {0}, n = {1}", m, n);
   }
}
