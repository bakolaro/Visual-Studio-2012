using System;

/* Declare a character variable and assign it with the symbol that
 * has Unicode code 72. Hint: first use the Windows Calculator to
 * find the hexadecimal representation of 72.
 */

class AssignChar
{
   static void Main()
   {
      /* Instead of a calculator, we could use the format string of
       * the Console.WriteLine() method.
       */
      int unicode = 72;
      Console.WriteLine("{0} = {0:x}(16)", unicode); // 72 = 48(16)

      char ch = '\u0048';
      Console.WriteLine("{0} = {0:x}(16) = '{1}'",(int) ch, ch);
   }
}