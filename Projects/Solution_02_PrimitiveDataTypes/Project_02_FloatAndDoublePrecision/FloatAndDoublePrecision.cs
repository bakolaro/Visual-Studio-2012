using System;
using System.Globalization;
using System.Threading;

/* Which of the following values can be assigned to a variable of
 * type float and which to a variable of type double:
 * 34.567839023, 12.345, 8923.1234857, 3456.091?
 */

class FloatAndDoublePrecision
{
   static void Main()
   {
      Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
       
      double @double = 34.567839023;
      float @float = 34.567839023f;
      string str = "34.567839023";
      Console.WriteLine("double: {0} = {1}({2})", @double, str,
                         @double.ToString().Equals(str));
      Console.WriteLine("float: {0} = {1}({2})", @float, str,
                         @float.ToString().Equals(str));
      Console.WriteLine();
      @double = 12.345;
      @float = 12.345f;
      str = "12.345";
      Console.WriteLine("double: {0} = {1}({2})", @double, str,
                         @double.ToString().Equals(str));
      Console.WriteLine("float: {0} = {1}({2})", @float, str,
                         @float.ToString().Equals(str));
      Console.WriteLine();
      @double = 8923.1234857;
      @float = 8923.1234857f;
      str = "8923.1234857";
      Console.WriteLine("double: {0} = {1}({2})", @double, str,
                         @double.ToString().Equals(str));
      Console.WriteLine("float: {0} = {1}({2})", @float, str,
                         @float.ToString().Equals(str));
      Console.WriteLine();
      @double = 3456.091;
      @float = 3456.091f;
      str = "3456.091";
      Console.WriteLine("double: {0} = {1}({2})", @double, str,
                         @double.ToString().Equals(str));
      Console.WriteLine("float: {0} = {1}({2})", @float, str,
                         @float.ToString().Equals(str));
   }
}
