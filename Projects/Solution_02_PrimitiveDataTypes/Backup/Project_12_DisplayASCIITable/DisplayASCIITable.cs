using System;

/* Find online more information about ASCII(American Standard Code
 * for Information Interchange) and write a program that prints the
 * entire ASCII table of characters on the console.
 */

class DisplayASCIITable
{
   static void Main()
   {
      Console.WriteLine("ASCII. Table of printable characters.");
      for(int code = 32; code < 127; code++)
      {
         Console.WriteLine("{0,4}.{1,4}", code,(char) code);
      }
   }
}
