using System;
using System.Threading;
using System.Globalization;


class Chapter04
{
   public static void Sum3Integers ()
   {
      /* 1. Напишете програма, която чете от конзолата три числа
       * от тип int и отпечатва тяхната сума.
       */
      Console.WriteLine ("Task 1: Sum of 3 integers");
      int a, b, c;
      
      Console.Write ("a = ");
      a = int.Parse (Console.ReadLine ());
      Console.Write ("b = ");
      b = int.Parse (Console.ReadLine ());
      Console.Write ("c = ");
      c = int.Parse (Console.ReadLine ());
      
      Console.WriteLine ("Sum of a, b and c = " + (a + b + c));
      
      if (Again ())
         Sum3Integers ();
   }
   
   public static void SolveCircle ()
   {
      /* 2. Напишете програма, която чете от конзолата радиуса
       * на кръг и отпечатва неговото *лице* и обиколка.
       */
      Console.WriteLine ("Task 2: Area and perimeter of a circle");
      
      double r;
      
      Console.Write ("radius = ");
      r = double.Parse (Console.ReadLine ());
      
      Console.WriteLine (
         "Area of this circle = " + (Math.PI * r * r));
      Console.WriteLine (
         "Perimeter of this circle = " + (2 * Math.PI * r));
      
      if (Again ())
         SolveCircle ();
   }

   public static void WriteBussinessCard ()
   {
      /* 3. Дадена фирма има име, адрес, телефонен номер, факс
       * номер, уеб сайт и мениджър. Мениджърът има име, фамилия
       * и телефонен номер. Напишете програма, която чете
       * информацията за фирмата и нейния мениджър и я отпечатва
       * след това на конзолата.
       */
      Console.WriteLine ("Task 3: Business card information");
      
      string firm, address, web, managerFirstName, managerLastName;
      ulong phone, fax, managerPhone;
      
      Console.Write ("Firm: ");
      firm = Console.ReadLine ();
      Console.Write ("Address: ");
      address = Console.ReadLine ();
      Console.Write ("Phone number: ");
      phone = ulong.Parse (Console.ReadLine ());
      Console.Write ("Fax: ");
      fax = ulong.Parse (Console.ReadLine ());
      Console.Write ("Web site: ");
      web = Console.ReadLine ();
     
      Console.Write ("Manager's first name: ");
      managerFirstName = Console.ReadLine ();
      Console.Write ("Manager's last name: ");
      managerLastName = Console.ReadLine ();
      Console.Write ("Manager's phone number: ");
      managerPhone = ulong.Parse (Console.ReadLine ());
      
      Console.WriteLine ("Firm: {0}\nAddress: {1}\n"
         + "Tel.: {2:+359 (##) ####-###}, "
         + "Fax: {3:+359 (##) ####-###}\n"
         + "Web: {4}\n"
         + "Manager: {5} {6}, {7:### ## #### ###}",
         firm, address, phone, fax, web,
         managerFirstName, managerLastName, managerPhone);
      
      if (Again ())
         WriteBussinessCard ();
   }

   public static void WriteNumbersInColumns ()
   {
      /* 4. Напишете програма, която отпечатва три числа в три
       * виртуални колони на конзолата. Всяка колона трябва да е
       * с широчина 10 символа, а числата трябва да са ляво
       * подравнени. Първото число трябва да е цяло число в
       * шестнадесетична бройна система, второто да е дробно
       * положително, а третото – да е дробно отрицателно.
       * Последните две числа да се закръглят до втория знак след
       * десетичната запетая.
       */
      Console.WriteLine ("Task 4: Numbers in columns");
      
      int natural;
      double positive, negative;
      
      Console.Write ("Integer = ");
      natural = int.Parse (Console.ReadLine ());
      Console.Write ("Positive real number = ");
      positive = double.Parse (Console.ReadLine ());
      Console.Write ("Negative real number = ");
      negative = double.Parse (Console.ReadLine ());
      
      Console.WriteLine ("{0,-10:x}{1,-10:f2}{2,-10:f2}",
         natural, positive, negative);
      
      if (Again ())
         WriteNumbersInColumns ();
   }

   public static void CountIntegersDivisibleBy5 ()
   {
      /* 5. Напишете програма, която чете от конзолата две цели
       * числа (int) и отпечатва колко числа има между тях, 
       * такива, че остатъкът им от деленето на 5 да е 0.
       * Пример: в интервала [17, 25] има 2 такива числа.
       */
      Console.WriteLine ("Task 5: Count integers divisible by 5");
      
      int a, b, count;
      
      Console.Write ("a (integer) = ");
      a = int.Parse (Console.ReadLine ());
      Console.Write ("b (integer) = ");
      b = int.Parse (Console.ReadLine ());
      
      if (a > b)
      {
         int c = a;
         a = b;
         b = c;
      }
      if (0 < a && a % 5 != 0)
      {
            count = b / 5 - a / 5;
      }
      else if (b < 0 && b % 5 != 0)
      {
            count = b / 5 - a / 5;
      }
      else
      {
         count = b / 5 - a / 5 + 1;
      }

      Console.WriteLine (
         "There are {2} numbers in [{0}, {1}] which " +
            "are divisible by 5.", a, b, count);
      
      if (Again ())
         CountIntegersDivisibleBy5 ();
   }
   
   public static void LargerNumber ()
   {
      /* 6. Напишете програма, която чете две числа от конзолата 
       * и отпечатва по-голямото от тях. Решете задачата без да 
       * използвате условни конструкции.
       */
      Console.WriteLine ("Task 6: Tell which number is larger");
      
      double a, b;
      
      Console.Write ("a (double) = ");
      a = double.Parse (Console.ReadLine ());
      Console.Write ("b (double) = ");
      b = double.Parse (Console.ReadLine ());
    
      Console.WriteLine ("Max = " + Math.Max(a, b));
      
      if (Again ())
         LargerNumber ();
   }
   
   public static void ValidateAndCalculateNumbers ()
   {
      /* 7. Напишете програма, която чете пет числа и отпечатва
       * тяхната сума. При невалидно въведено число да се подкани
       * потребителя да въведе друго число.
       * 8. Напишете програма, която чете пет числа от конзолата
       * и отпечатва най-голямото от тях.
       */
      Console.WriteLine (
         "Task 7-8: Validate and calculate numbers");
      
      double x, sum = 0, max = 0;
      int count = 5;
      bool isValid;
      
      do
      {
         Console.Write ("Input a real number = ");
         isValid = double.TryParse (Console.ReadLine (), out x );
         if (isValid)
         {
            sum += x;
            max = (max < x || count == 5 ? x : max);
            count--;
         }
         else
            Console.WriteLine ("Invalid number. Try another one!");
      }
      while (count > 0);
    
      Console.WriteLine ("Sum = " + sum);
      Console.WriteLine ("Max = " + max);
      
      if (Again ())
         ValidateAndCalculateNumbers ();
   }

   public static void SolveQuadraticEquation ()
   {
      /* 9. Напишете програма, която чете коефициентите a, b и c
       * от конзолата и решава квадратното уравнение: ax2+bx+c=0.
       * Програмата трябва да принтира реалните решения на
       * уравнението на конзолата.
       */
      Console.WriteLine (
         "Task 9: Solve a quadratic equation");
      
      double a, b, c, d;

      Console.Write ("a = ");
      a = double.Parse (Console.ReadLine ());
      Console.Write ("b = ");
      b = double.Parse (Console.ReadLine ());
      Console.Write ("c = ");
      c = double.Parse (Console.ReadLine ());
      
      d = b * b - 4 * a * c;
      if (d < 0) 
         Console.WriteLine (
            "This equation has no real solutions.");
      else if (d > 0)
      {
         double x1 = (- b - Math.Sqrt (d)) / (2 * a);
         double x2 = (- b + Math.Sqrt (d)) / (2 * a);
         Console.WriteLine ("x1 = {0:f4}; x2 = {1:f4}", x1, x2);
      }
      else // d == 0
      {
         double x = - b / (2 * a);
         Console.WriteLine ("x1 = x2 = {0:f4}", x);
      }
      
      if (Again ())
         SolveQuadraticEquation ();
   }

   public static void SumAndListAnyNumberOfIntegers ()
   {
      /* 10. Напишете програма, която прочита едно цяло число n от
       * конзолата. След това прочита още n на брой числа от
       * конзолата и отпечатва тяхната сума.
       * 11. Напишете програма, която прочита цяло число n от 
       * конзолата и отпечатва на конзолата всички числа в 
       * интервала [1...n], всяко на отделен ред.
       */
      Console.WriteLine (
         "Task 10: Sum n integers");
      
      bool isValid;
      byte n;
      int a, count = 0, sum = 0;
      
      Console.Write ("n = ");
      n = byte.Parse (Console.ReadLine ());
      do
      {
         Console.Write ("a({0}) = ", count);
         isValid = int.TryParse (Console.ReadLine (), out a);
         if (isValid)
         {
            sum += a;
            count ++;
         }
      }
      while (count < n);
      
      Console.WriteLine ("Sum = " + sum);
      
      Console.WriteLine (
         "Task 11: List n integers");
      
      for (byte i = 1; i <= n; i++)
         Console.WriteLine (i);
      
      if (Again ())
         SumAndListAnyNumberOfIntegers ();
   }

   public static void FibonaciFist100 ()
   {
      /* 12. Напишете програма, която отпечатва на конзолата 
       * първите 100 числа от редицата на Фибоначи: 
       * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...
       */
      Console.WriteLine (
         "Task 12: First 100 Fibonacci numbers");

      byte count = 2;
      decimal a = 0, b = 1; 
      
      Console.WriteLine ("{1,10}.{0,30:n0}; ", a, 1);
      Console.WriteLine ("{1,10}.{0,30:n0}; ", b, 2);
      do
      {
         count++;
         b = a + b;
         a = b - a;
         Console.WriteLine ("{1,10}.{0,30:n0}; ", b, count);
      }
      while (count < 100);

      if (Again ())
         FibonaciFist100 ();
   }

   public static void SumReciprocal ()
   {
      /* 13. Напишете програма, която пресмята сумата (с точност
       * до 0.001): 1/2 + 1/3 + 1/4 + 1/5 + ...
       */
      Console.WriteLine (
         "Task 13: Sum reciprocal numbers");

      double x, sum = 0.0; 
      int n = 2;
      
      do
      {
         x = 1.0 / n;
         sum += x;
         Console.Write (
            "...+1/{0,-4}={1,7:f4}; ", n++, sum);
      }
      while (x > 0.001);
      Console.WriteLine ();
      Console.WriteLine ("Sum = {0:f4}; ", sum);

      if (Again ())
         SumReciprocal ();
   }
   
   public static string HexToBin (string hexString) 
   {
      string str = "";
      for (int i = 0; i < hexString.Length; i++)
      {
         string binStr;
         char ch = hexString[i];
         switch (ch)
         {
            case '0': binStr = "0000"; break;
            case '1': binStr = "0001"; break;
            case '2': binStr = "0010"; break;
            case '3': binStr = "0011"; break;
            case '4': binStr = "0100"; break;
            case '5': binStr = "0101"; break;
            case '6': binStr = "0110"; break;
            case '7': binStr = "0111"; break;
            case '8': binStr = "1000"; break;
            case '9': binStr = "1001"; break;
            case 'a': binStr = "1010"; break;
            case 'b': binStr = "1011"; break;
            case 'c': binStr = "1100"; break;
            case 'd': binStr = "1101"; break;
            case 'e': binStr = "1110"; break;
            case 'f': binStr = "1111"; break;
            default: binStr = ""; break;
         }
         str += binStr;
      }
      return str;
   }
   
   public static void TryRightShift ()
   {
      Console.WriteLine (
         "Task: See how right shift (>>) works");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      for (int i = 0; i < 64; i++)
      {
         Console.WriteLine ("{0} >> {1,-2} = {2} (2)", n, i,
            HexToBin (string.Format ("{0,10:x8}", n >> i)));
      }

      if (Again ())
         TryRightShift ();
   }

   public static void TryBinary ()
   {
      Console.WriteLine (
         "Task: See how binary numbers work");

      Console.WriteLine (
         "Fact 1: -positive == ~positive + 1");

      for (int i = 0; i < 64; i++)
      {
         Console.WriteLine ("{0,2} = {1}: {2,3} = {3}", i,
            HexToBin (string.Format ("{0,10:x8}", i)),
               -i, HexToBin (string.Format ("{0,10:x8}", -i)));
      }

      if (Again ())
         TryBinary ();
   }

   public static void TryShiftNegativeNumbers ()
   {
      Console.WriteLine (
         "Task: See how shift works on negative numbers");

      Console.WriteLine (
         "Fact 2: positive >> 31 == 0," +
         "negative >> 31 == ~0 == -1");

      for (int i = 0; i < 64; i++)
      {
         Console.WriteLine ("{0,2} = {1}: {2,3} = {3}", i,
            HexToBin (string.Format ("{0,10:x8}", i)),
               -i, HexToBin (string.Format ("{0,10:x8}", -i)));
         Console.WriteLine ("{0,2} = {1}: {2,3} = {3}", i >> 31,
            HexToBin (string.Format ("{0,10:x8}", i >> 31)),
               -i >> 31, HexToBin (string.Format ("{0,10:x8}", -i >> 31)));
         Console.WriteLine ();
      }

      if (Again ())
         TryShiftNegativeNumbers ();
   }
   
   public static void Run ()
   {
      Console.WriteLine ("Chapter 4. Excersises (pp. 194-195).");
      Sum3Integers ();
      SolveCircle ();
      WriteBussinessCard ();
      WriteNumbersInColumns ();
      CountIntegersDivisibleBy5 ();
      LargerNumber ();
      TryBinary ();
      TryRightShift ();
      TryShiftNegativeNumbers ();
      
      ValidateAndCalculateNumbers ();
      SolveQuadraticEquation ();
      SumAndListAnyNumberOfIntegers ();
      FibonaciFist100 ();
      SumReciprocal ();
      
   }

   public static bool Again ()
   {
      Console.WriteLine (
         "Press <esc> to quit" + Environment.NewLine
            + "or some other key to do it again...");

      char ch = Console.ReadKey().KeyChar;
      Console.Clear ();
      if (ch.Equals ('\u001b'))
      {
         return false;
      }
      else
      {
         return true;
      }
   }
}
