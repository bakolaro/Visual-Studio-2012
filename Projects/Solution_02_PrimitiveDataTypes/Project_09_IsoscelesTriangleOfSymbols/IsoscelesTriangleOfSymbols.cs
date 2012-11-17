using System;
using System.Text;

/* Write a program that prints an isosceles triangle of 9 copyright
 * symbols ©. Use Windows Character Map to find the Unicode code of
 * the © symbol. Note: the © symbol may be displayed incorrectly.
 */

class IsoscelesTriangleOfSymbols
{
   static void Main()
   {
       Console.OutputEncoding = Encoding.UTF8;
       char copyright = '\u00A9';
       char space = ' ';
       Console.WriteLine("{0}{0}{1}{0}{0}", space, copyright);
       Console.WriteLine("{0}{1}{1}{1}{0}", space, copyright);
       Console.WriteLine("{1}{1}{1}{1}{1}", space, copyright);
   }
}