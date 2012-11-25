using System;

/* Declare an integer variable and assign it with the value 254 in
 * hexadecimal format. Use Windows Calculator to find its hexadecimal
 * representation.
 */

class AssignHexadecimal
{
   static void Main()
   {
      int dec = 254;
      int hex = 0xFE;

      Console.WriteLine("{0:x} = {1}({2})", hex, dec, hex == dec);
   }
}
