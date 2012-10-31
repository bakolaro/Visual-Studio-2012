using System;


class Chapter06
{
   /* 1. Напишете програма, която отпечатва на конзолата числата
    * от 1 до N. Числото N трябва да се чете от стандартния вход.
    */

   public static void PrintCountingNumbers ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 1. Print all integers from 1 to n...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      for (int i = 1; i <= n; i++)
      {
         Console.WriteLine (i);
      }

      if (Again ()) PrintCountingNumbers ();
   }

   /* 2. Напишете програма, която отпечатва на конзолата числата
    * от 1 до N, които не се делят едновременно на 3 и 7.
    * Числото N да се чете от стандартния вход.
    */

   public static void PrintNotDivisableBy21 ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 2. Print all integers from 1 to n," +
         Environment.NewLine +
         "which are not divisible by 3 and 7...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      for (int i = 1; i <= n; i++)
      {
         if (i % 21 != 0) Console.WriteLine (i);
      }

      if (Again ()) PrintNotDivisableBy21 ();
   }

   /* 3. Напишете програма, която чете от конзолата поредица от
    * цели числа и отпечатва най-малкото и най-голямото от тях.
    */

   public static void PrintMinAndMaxInteger ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 3. Read a sequence of integers and print" +
         Environment.NewLine +
         "the smallest and the largest of them..." +
         Environment.NewLine +
         Environment.NewLine +
         "Note: Input a non-integer to end the sequence!");

      bool isInteger;
      int n, count, min, max;
      count = min = max = 0;
      do
      {
         Console.Write ("n = ");
         isInteger = int.TryParse (Console.ReadLine (), out n);
         if (isInteger)
         {
            if (count > 0)
            {
               min = (n < min ? n : min);
               max = (n > max ? n : max);
            }
            else
            {
               min = max = n;
            }
            count++;
         }
      }
      while (isInteger);
      
      Console.WriteLine (
         "count = {0}, min = {1}, max = {2}", count, min, max);

      if (Again ()) PrintMinAndMaxInteger ();
   }

   /* 4. Напишете програма, която отпечатва всички възможни карти
    * от стандартно тесте карти без джокери (имаме 52 карти: 4 бои
    * по 13 карти).
    */

   public static void PrintDeckOfCards ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 4. Print a deck of playing cards...");

      int suitCount = 4, rankCount = 13;

      for (int s = 0; s < suitCount; s++)
      {
         for (int r = 0; r < rankCount; r++)
         {
            string rank = (r + 1).ToString ();
            switch (r)
            {
               case 0: rank = "Ace"; break;
               case 10: rank = "Jack"; break;
               case 11: rank = "Queen"; break;
               case 12: rank = "King"; break;
            }
            string suit = string.Empty;
            switch (s)
            {
               case 0: suit = "Spades ♠"; break;
               case 1: suit = "Hearts ♥"; break;
               case 2: suit = "Diamonds ♦"; break;
               case 3: suit = "Clubs ♣"; break;
            }
            Console.WriteLine ("{0,8} of {1}", rank, suit);
         }
      }

      if (Again ()) PrintDeckOfCards ();
   }

   /* 5. Напишете програма, която чете от конзолата числото N и
    * отпечатва сумата на първите N члена от редицата на Фибоначи:
    * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...
    */

   public static void PrintSumOfFibonacciNumbers ()
   {
      string newLine = Environment.NewLine;

      Console.Clear ();
      Console.WriteLine (
         "Task 5. Print the sum of first n Fibonacci numbers...");

      Console.Write ("n = ");
      byte n = byte.Parse (Console.ReadLine ());

      string sequenceOfFibonacci = string.Empty;
      decimal a = 0, b = 1, sum = 0;
      if (n > 0)
      {
         sum = a;
         sequenceOfFibonacci +=
            string.Format ("{0,40:n0}" + newLine, a);
      }
      if (n > 1)
      {
         sum += b;
         sequenceOfFibonacci +=
            string.Format ("{0,40:n0}" + newLine, b);
      }
      for (byte i = 2; i < n; i++)
      {
         sum += (a + b);
         sequenceOfFibonacci +=
            string.Format ("{0,40:n0}" + newLine, a + b);
         b += a;
         a = b - a;
      }

      if (n < 1)
      {
         Console.WriteLine ("Invalid input. Let 0 < n.");
      }
      else
      {
         Console.WriteLine ("Sum of terms = {0:n0}" + newLine +
                            "Sequence:" + newLine +"{1}",
            sum, sequenceOfFibonacci);
      }

      if (Again ()) PrintSumOfFibonacciNumbers ();
   }

   /* 6. Напишете програма, която пресмята N!/K! за дадени N и K
    * (1<K<N).
    */

   public static decimal Factorial (int n)
   {
      // n is nonnegative
      return (n > 0 ? n * Factorial (n - 1) : 1);
   }

   public static decimal ProductOfIntegersInRange (int n, int k)
   {
      // n is greater than or equal to k and k > 0
      return (n > k ? n * ProductOfIntegersInRange (n - 1, k) : k);
   }

   public static void PrintFnToFk ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 6. Print n!/k! (1 < k < n)...");

      Console.Write ("n = ");
      byte n = byte.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      byte k = byte.Parse (Console.ReadLine ());

      if(1 < k && k < n)
      {
         Console.WriteLine ("{0,-30}{1,30}",
            "n (n - 1)...(k + 1) = ",
                            ProductOfIntegersInRange (n, k + 1));
         Console.WriteLine ("{0,-30}{1,30}",
            "n! / k! = ", Factorial(n) / Factorial(k));
      }
      else
      {
         Console.WriteLine (
            "Invalid input. Let 1 < k < n.");
      }

      if (Again ()) PrintFnToFk ();
   }

   /* 7. Напишете програма, която пресмята N!*K!/(N-K)! за дадени
    * N и K (1<K<N).
    */

   public static void PrintFnTimesFkDivFnk ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 7. Print n!k!/(n-k)!...");

      Console.Write ("n = ");
      byte n = byte.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      byte k = byte.Parse (Console.ReadLine ());

      if(1 < k && k < n)
      {
         Console.WriteLine ("{0,-30}{1,30}",
            "n (n - 1)...(n - k + 1) k! = ",
            ProductOfIntegersInRange (n, n - k + 1) *
                            Factorial(k));
         Console.WriteLine ("{0,-30}{1,30}",
            "n! * k! / (n - k)! = ",
            Factorial(n) * Factorial(k) / Factorial(n - k));
      }
      else
      {
         Console.WriteLine (
            "Invalid input. Let 1 < k < n.");
      }

      if (Again ()) PrintFnTimesFkDivFnk ();
   }

   /* 8. В комбинаториката числата на Каталан (Catalan's numbers)
    * се изчисляват по следната формула: C[n] = (2n)! / n! / (n+1),
    * за n ≥ 0. Напишете програма, която изчислява n-тото число
    * на Каталан за дадено n.
    */

   public static void PrintCatalanNumbers ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 8. Print Catalan's numbers...");

      Console.WriteLine (
         "C[n] = (2n)! / n! / (n + 1)!, " +
         "n is a nonnegative integer");
      for (byte n = 0; n < 14; n++)
      {
         Console.WriteLine ("{0,-30}{1,30}",
            "C[" + n + "] = ",
            Factorial(n + n) / Factorial(n) / Factorial(n + 1));
      }
      Console.WriteLine ("...number overflow comes next...");

      Console.WriteLine ("{0,-30}{1,30}",
         "C[0] = ", 1);
      Console.WriteLine ("{0,-30}{1,30}",
         "C[1] = ", 1);
      Console.WriteLine (
         "C[n] = 2n(2n - 1)...(n + 2)/n!, n > 1");
      for (byte n = 2; n < 21; n++)
      {
         Console.WriteLine ("{0,-30}{1,30}",
            "C[" + n + "] = ",
            ProductOfIntegersInRange(n + n, n + 2) /
                            Factorial(n));
      }
      Console.WriteLine ("...number overflow comes next...");

      if (Again ()) PrintCatalanNumbers ();
   }

   /* 9. Напишете програма, която за дадено цяло число n, пресмята
    * сумата: S = 0!/x^0 + 1!/x^1 + ... + n!/x^n
    */

   public static decimal FnToXn (decimal x, int k)
   {
      return (k > 0 ? FnToXn (x, k - 1) * k / x : 1.0m);
   }

   public static void PrintSumOfTermsFnToXn ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 9. Print sum of terms from 0!/x^0 to n!/x^n...");

      Console.Write ("x = ");
      decimal x = decimal.Parse (Console.ReadLine ());

      for (int n = 0; x > 0.1m && n < 15; n++)
      {
         decimal sum = 0.0m;
         for (int k = 0; k < n + 1; k++)
         {
            sum += FnToXn (x, k);
         }
         Console.WriteLine (
            "Sum[x = {0,6:f2},n = {1,3}] = {2,50:f8}", x, n, sum);
      }

      if (Again ()) PrintSumOfTermsFnToXn ();
   }

   /* 10. Напишете програма, която чете от конзолата положително
    * цяло число N (N < 20) и отпечатва матрица с числа като на
    * фигурата по-долу:
    * N=3
    * 1 2 3
    * 2 3 4
    * 3 4 5
    * N=4
    * 1 2 3 4
    * 2 3 4 5
    * 3 4 5 6
    * 4 5 6 7
    */

   public static void PrintMatrix ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 10. Print matrix...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (0 < n && n < 20)
      {
         for (int i = 0; i < n; i++)
         {
            for (int j = i + 1; j < i + 1 + n; j++)
            {
               Console.Write ("{0,3}", j);
            }
            Console.WriteLine ();
         }
      }
      else
      {
         Console.WriteLine ("Invalid input. Let 0 < n < 20.");
      }

      if (Again ()) PrintMatrix ();
   }

   /* 11. Напишете програма, която пресмята с колко нули завършва
    * факториелът на дадено число. Примери:
    * N = 10 -> N! = 3628800 -> 2
    * N = 20 -> N! = 2432902008176640000 -> 4
    */

   public static void PrintFactorialTrailingZeros ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 11. Print what is the number of trailing zeros" +
         Environment.NewLine +
         "of the factorial of an integer...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      int count = 0;
      if (-1 < n)
      {
         for (int i = 1; i < n + 1; i++)
         {
            int j = i;
            while (j % 5 == 0)
            {
               j = j / 5;
               count++;
            }
         }
         Console.WriteLine ("The number is " + count);
      }
      else
      {
         Console.WriteLine ("Invalid input. Let -1 < n.");
      }

      if (Again ()) PrintFactorialTrailingZeros ();
   }

   /* 12. Напишете програма, която преобразува дадено число от
    * десетична в двоична бройна система.
    */

   public static void PrintIntegerToBinary ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 12. Print integer to binary...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (-1 < n)
      {
         string binary = string.Empty;

         Console.WriteLine (
            "Method 1. Concatenation of remainders.");
         int i = n, numSysBase = 2, remainder;
         while (i > 0)
         {
            remainder = i % numSysBase;
            binary = remainder + binary;
            i /= numSysBase;
         }
         Console.WriteLine (
            "{0,-20}{1,30}", "The number is", binary);

         Console.WriteLine (
            "Method 2. Text substitution in its hexadecimal" +
            Environment.NewLine +
            "representation.");
         Console.WriteLine (
            "{0,-20}{1,30:x}", "The number equals", n);
         string hex = string.Format ("{0:x}", n);
         string binFromHex = string.Empty;
         for (int j = 0; j < hex.Length; j++)
         {
            char ch = hex[j];
            switch (ch)
            {
               case '0': binFromHex += "0000"; break;
               case '1': binFromHex += "0001"; break;
               case '2': binFromHex += "0010"; break;
               case '3': binFromHex += "0011"; break;
               case '4': binFromHex += "0100"; break;
               case '5': binFromHex += "0101"; break;
               case '6': binFromHex += "0110"; break;
               case '7': binFromHex += "0111"; break;
               case '8': binFromHex += "1000"; break;
               case '9': binFromHex += "1001"; break;
               case 'a': binFromHex += "1010"; break;
               case 'b': binFromHex += "1011"; break;
               case 'c': binFromHex += "1100"; break;
               case 'd': binFromHex += "1101"; break;
               case 'e': binFromHex += "1110"; break;
               case 'f': binFromHex += "1111"; break;
            }
         }
         Console.WriteLine (
            "{0,-20}{1,30}",
            "i.e.", binFromHex);
      }
      else
      {
         Console.WriteLine ("Invalid input. Let -1 < n.");
      }

      if (Again ()) PrintIntegerToBinary ();
   }

   /* 13. Напишете програма, която преобразува дадено число от
    * двоична в десетична бройна система.
    */

   public static int Power (int powBase, int power)
   {
      int x = 1;
      for (int i = 0; i < power; i++)
      {
         x *= powBase;
      }
      return x;
   }

   public static void PrintBinaryToDecimal ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 13. Print binary to decimal...");

      Console.Write ("binary = ");
      string binary = Console.ReadLine ();

      int n = 0;
      for (int i = 0; i < binary.Length; i++)
      {
         if (binary[binary.Length - 1 - i].Equals('1'))
         {
            n += Power (2, i);
         }
         else if (!binary[binary.Length - 1 - i].Equals('0'))
         {
            Console.WriteLine ("Invalid input." +
               " Not a binary number!");
            return;
         }
      }
      Console.WriteLine ("n = " + n);

      if (Again ()) PrintBinaryToDecimal ();
   }

   /* 14. Напишете програма, която преобразува дадено число от
    * десетична в шестнайсетична бройна система.
    */

   public static void PrintDecimalToHexadecimal ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 14. Print decimal to hexadecimal...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (-1 < n)
      {
         Console.WriteLine ("hexadecimal = {0:x}", n);
      }
      else
      {
         Console.WriteLine ("Invalid input. Let -1 < n.");
      }

      if (Again ()) PrintDecimalToHexadecimal ();
   }

   /* 15. Напишете програма, която преобразува дадено число от
    * шестнайсетична в десетична бройна система.
    */

   public static void PrintHexadecimalToDecimal ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 15. Print hexadecimal to decimal...");

      Console.Write ("hexadecimal = ");
      string hexadecimal = Console.ReadLine ().ToLower ();

      int n = 0;
      for (int i = 0; i < hexadecimal.Length; i++)
      {
         int pow = Power (16, i);
         switch (hexadecimal[hexadecimal.Length - 1 - i])
         {
            case '0': n += 0 * pow; break;
            case '1': n += 1 * pow; break;
            case '2': n += 2 * pow; break;
            case '3': n += 3 * pow; break;
            case '4': n += 4 * pow; break;
            case '5': n += 5 * pow; break;
            case '6': n += 6 * pow; break;
            case '7': n += 7 * pow; break;
            case '8': n += 8 * pow; break;
            case '9': n += 9 * pow; break;
            case 'a': n += 10 * pow; break;
            case 'b': n += 11 * pow; break;
            case 'c': n += 12 * pow; break;
            case 'd': n += 13 * pow; break;
            case 'e': n += 14 * pow; break;
            case 'f': n += 15 * pow; break;
            default:
               Console.WriteLine ("Not a binary number!");
               return;
         }
      }
      Console.WriteLine ("n = " + n);
      Console.WriteLine ("n (hex) = {0:x}", n);

      if (Again ()) PrintHexadecimalToDecimal ();
   }

   /* 16. Напишете програма, която по дадено число N отпечатва
    * числата от 1 до N, разбъркани в случаен ред.
    */

   public static string ArrayTermsList (int[] arr)
   {
      string termsList = string.Empty;
      foreach (int i in arr)
      {
         termsList += string.Format ("[{0,3}]" , i);
      }
      return termsList;
   }

   public static void PrintShuffledNaturalNumbers ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 16. Shuffle first n natural numbers...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (-1 < n)
      {
         int[] sequence = new int[n], shuffled = new int[n];
         for (int i = 0; i < n; i++)
         {
            sequence[i] = i + 1;
         }
         Random rand = new Random ();
         int nonZeros = n, indexOfNextNonZero = 0;
         while (nonZeros > 0)
         {
            int randInt = rand.Next ();
            int step = randInt % nonZeros + 1;
            int count = 0;
            Console.WriteLine (
                  "{0,-20} = {8,40}\n" +
                  "{1,-20} = {9,40}\n" +
                  "{2,-20} = {10,40}\n" +
                  "{3,-20} = {11,40}\n" +
                  "{4,-20} = {12,40}\n" +
                  "{5,-20} = {13,40}\n" +
                  "{16,30}{6,-20} = {14,10}\n" +
                  "{16,15}{7,-20} = {15,25}",
                  "sequence", "shuffled", "n", "nonZeros",
                  "randInt", "step",
                  "indexOfNextNonZero",
                  "count",
                  ArrayTermsList (sequence),
                  ArrayTermsList (shuffled), n, nonZeros,
                  randInt, step,
                  indexOfNextNonZero, count, "");
            do
            {
               do
               {
                  indexOfNextNonZero++;
                  indexOfNextNonZero %= n;
                  Console.WriteLine (
                     "{2,30}{0,-20} = {1,10}",
                     "indexOfNextNonZero",
                     indexOfNextNonZero, "");
               }
               while (sequence[indexOfNextNonZero] == 0);
               count++;
               Console.WriteLine (
                  "{2,15}{0,-20} = {1,25}",
                  "count",
                  count, "");
            }
            while (count < step);

            shuffled[--nonZeros] = sequence[indexOfNextNonZero];
            sequence[indexOfNextNonZero] = 0;
         }
         Console.WriteLine (
               "{0,-20} = {5,40}\n" +
               "{1,-20} = {6,40}\n" +
               "{2,-20} = {7,40}\n" +
               "{3,-20} = {8,40}\n" +
               "{4,-20} = {9,40}\n",
               "sequence", "shuffled", "n", "nonZeros",
               "indexOfNextNonZero",
               ArrayTermsList (sequence),
               ArrayTermsList (shuffled), n, nonZeros,
               indexOfNextNonZero);
         for (int i = 0; i < n; i++)
         {
            Console.WriteLine ("{0}. {1}", i, shuffled[i]);
         }
      }
      else
      {
         Console.WriteLine ("Invalid input. Let -1 < n.");
      }

      if (Again ()) PrintShuffledNaturalNumbers ();
   }

   /* 17. Напишете програма, която за дадени две числа, намира
    * най-големия им общ делител.
    */

   public static void PrintGreatestCommonDenominator ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 17. Print greatest common denominator...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      int gcd = 1;
      if (0 < n && 0 < k)
      {
         for (int i = Math.Min(n, k); i > 0; i--)
         {
            if (n % i == 0 && k % i == 0)
            {
               gcd = i;
               break;
            }
         }
      }
      else
      {
         Console.WriteLine (
            "Invalid input. Let 0 < n && 0 < k.");
      }
      Console.WriteLine (
         "Greatest common denominator = " + gcd);

      if (Again ()) PrintGreatestCommonDenominator ();
   }

   /* 18. Напишете програма, която по дадено число n, извежда
    * матрица във формата на спирала: пример при n=4
    *  1  2  3  4
    * 12 13 14  5
    * 11 16 15  6
    * 10  9  8  7
    */

   public static void PrintSpiral ()
   {
      Console.Clear ();
      Console.WriteLine (
         "Task 18. Print a spiral of integers...");

      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (1 < n && n < 21)
      {
         int[,] matrix = new int[n, n];

         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < n; j++)
            {
               matrix[i,j] = 0;
            }
         }
         int row = 0, column = 0, rowOffset = 0, columnOffset = 1,
            count = 0;
         while (matrix[row, column] == 0)
         {
            matrix[row, column] = ++count;

            if (row + rowOffset > n - 1 ||
                row + rowOffset < 0 ||
                column + columnOffset > n - 1 ||
                column + columnOffset < 0 ||
                matrix[row + rowOffset, column + columnOffset] > 0)
            {
               if (rowOffset == 0)
               {
                  rowOffset = columnOffset;
                  columnOffset = 0;
               }
               else
               {
                  columnOffset = -rowOffset;
                  rowOffset = 0;
               }
            }
            row += rowOffset;
            column += columnOffset;
         }
         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < n; j++)
            {
               Console.Write ("{0,4}", matrix[i,j]);
            }
            Console.WriteLine ();
         }
      }
      else
      {
         Console.WriteLine (
            "Invalid input. Let 1 < n && n < 21.");
      }

      if (Again ()) PrintSpiral ();
   }

   public static void Run ()
   {
      string newLine = Environment.NewLine;

      Console.Write ("Chapter 6. Exercises." + newLine +
         "Select an option:" + newLine +
         " 1. PrintCountingNumbers" + newLine +
         " 2. PrintNotDivisableBy21" + newLine +
         " 3. PrintMinAndMaxInteger" + newLine +
         " 4. PrintDeckOfCards" + newLine +
         " 5. PrintSumOfFibonacciNumbers" + newLine +
         " 6. PrintFnToFk" + newLine +
         " 7. PrintFnTimesFkDivFnk" + newLine +
         " 8. PrintCatalanNumbers" + newLine +
         " 9. PrintSumOfTermsFnToXn" + newLine +
         "10. PrintMatrix" + newLine +
         "11. PrintFactorialTrailingZeros" + newLine +
         "12. PrintIntegerToBinary" + newLine +
         "13. PrintBinaryToDecimal" + newLine +
         "14. PrintDecimalToHexadecimal" + newLine +
         "15. PrintHexadecimalToDecimal" + newLine +
         "16. PrintShuffledNaturalNumbers" + newLine +
         "17. PrintGreatestCommonDenominator" + newLine +
         "18. PrintSpiral" + newLine + newLine +
         "Selected option = ");

      string task = Console.ReadLine();

      switch(task)
      {
         case "1": PrintCountingNumbers (); break;
         case "2": PrintNotDivisableBy21 (); break;
         case "3": PrintMinAndMaxInteger (); break;
         case "4": PrintDeckOfCards (); break;
         case "5": PrintSumOfFibonacciNumbers (); break;
         case "6": PrintFnToFk (); break;
         case "7": PrintFnTimesFkDivFnk (); break;
         case "8": PrintCatalanNumbers (); break;
         case "9": PrintSumOfTermsFnToXn (); break;
         case "10": PrintMatrix (); break;
         case "11": PrintFactorialTrailingZeros (); break;
         case "12": PrintIntegerToBinary (); break;
         case "13": PrintBinaryToDecimal (); break;
         case "14": PrintDecimalToHexadecimal (); break;
         case "15": PrintHexadecimalToDecimal (); break;
         case "16": PrintShuffledNaturalNumbers (); break;
         case "17": PrintGreatestCommonDenominator (); break;
         case "18": PrintSpiral (); break;
      }

      if (Again ("Main")) Run ();
   }

   public static bool Again (params string[] message)
   {
      Console.WriteLine (
         "Press <esc> to quit" +
         Environment.NewLine +
         "or some other key to repeat" +
         (message.Length > 0 ? " " + message[0] : "") +
         "...");
      
      char ch = Console.ReadKey().KeyChar;
      Console.Clear ();
      return !ch.Equals ('\u001b');
   }
}
