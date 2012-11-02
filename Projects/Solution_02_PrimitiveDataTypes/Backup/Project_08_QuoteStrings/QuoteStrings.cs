using System;

/* Declare two string variables and assign them with following value:
 * ------------------------------------------------
 * - The "use" of quotations causes difficulties. -
 * ------------------------------------------------
 * Do the above in two different ways: with and without using
 * quoted strings.
 */

class QuoteStrings
{
   static void Main()
   {
      string quoted = @"The ""use"" of quotations causes difficulties.";
      string escaped = "The \"use\" of quotations causes difficulties.";
      Console.WriteLine("1. {0}", quoted);
      Console.WriteLine("2. {0}", escaped);
      Console.WriteLine("'Sentences 1. and 2. are the same' is {0}.",
                         quoted.Equals(escaped));
   }
}
