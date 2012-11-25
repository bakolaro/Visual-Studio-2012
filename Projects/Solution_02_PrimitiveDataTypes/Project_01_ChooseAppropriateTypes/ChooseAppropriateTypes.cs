using System;

/* Declare five variables choosing for each of them the most
 * appropriate of the types byte, sbyte, short, ushort, int, uint,
 * long, ulong to represent the following values:
 * 52130, -115, 4825932, 97, -10000.
 */

class ChooseAppropriateTypes
{
   static void Main()
   {
      ushort @ushort = 52130;
      sbyte @sbyte = -115;
      int @int = 4825932;
      byte @byte = 97;
      short @short = -10000;

      Console.WriteLine("{0,12}(min) < {1,12} < {2,12}(max), {3} = {4}",
                         ushort.MinValue, @ushort, ushort.MaxValue,
                         typeof(ushort), "ushort");
      Console.WriteLine("{0,12}(min) < {1,12} < {2,12}(max), {3} = {4}",
                         sbyte.MinValue, @sbyte, sbyte.MaxValue,
                         typeof(sbyte), "sbyte");
      Console.WriteLine("{0,12}(min) < {1,12} < {2,12}(max), {3} = {4}",
                         int.MinValue, @int, int.MaxValue,
                         typeof(int), "int");
      Console.WriteLine("{0,12}(min) < {1,12} < {2,12}(max), {3} = {4}",
                         byte.MinValue, @byte, byte.MaxValue,
                         typeof(byte), "byte");
      Console.WriteLine("{0,12}(min) < {1,12} < {2,12}(max), {3} = {4}",
                         short.MinValue, @short, short.MaxValue,
                         typeof(short), "short");
   }
}
