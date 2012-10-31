using System;
using IntroCSharp;

class Chapter09: Menu
{
   public Chapter09 ()
   {
      this.MenuTitle = "Chapter 9 - exercises.";

      this.Options = new MenuItem[] {
         /* 1. Напишете метод, който при подадено име отпечатва в
          * конзолата "Hello, <name>!" (например "Hello, Peter!").
          * Напишете програма, която тества този метод дали работи
          * правилно.
          */
         new MenuItem (this.SayHello,
            " 1. Say 'Hello'!"),
         new MenuItem (this.TestHello,
            "1a. The say-hello test."),

         /* 2. Създайте метод GetMax() с два целочислени (int)
          * параметъра, който връща по-голямото от двете числа.
          * Напишете програма, която прочита три цели числа от
          * конзолата и отпечатва най-голямото от тях, използвайки
          * метода GetMax().
          */
         new MenuItem (this.GetMax,
            " 2. Get greatest of three integers."),

         /* 3. Напишете метод, който връща английското наименование
          * на последната цифра от дадено число. Примери: за числото
          * 512 отпечатва "two"; за числото 1024 – "four".
          */
         new MenuItem (this.SpellTheLastDigit,
            " 3. Spell the last digit of an integer."),

         /* 4. Напишете метод, който намира колко пъти дадено число
          * се среща в даден масив. Напишете програма, която
          * проверява дали този метод работи правилно.
          */
         new MenuItem (this.CountArrayElementsWithGivenValue,
            " 4. Count the elements of an array with a given value."),
         new MenuItem (this.TestCountArrayElementsWithGivenValue,
            "4a. Test-count the elements of an array with a given value."),

         /* 5. Напишете метод, който проверява дали елемент, намиращ
          * се на дадена позиция от масив, е по-голям, или съответно
          * по-малък от двата му съседа. Тествайте метода дали
          * работи коректно.
          */
         new MenuItem (this.TestIfElementIsLocalExtremum,
            " 5. See if given element of an array is a local" +
            " extremum (greater or lower then both the" +
            " previous and the next element)."),
         new MenuItem (this.TestTheLocalExtremumTest,
            "5a. Test the local extremum test."),

         /* 6. Напишете метод, който връща позицията на първия елемент
          * на масив, който е по-голям от двата свои съседи
          * едновременно, или -1, ако няма такъв елемент.
          */
         new MenuItem (this.GetIndexOfFirstLocalMaximum,
            " 6. Get the index of the first element of an array," +
            " which is greater then both of its neighbour elements."),

          /* 7. Напишете метод, който отпечатва цифрите на дадено
           * десетично число в обратен ред. Например 256, трябва да
           * бъде отпечатано като 652.
           */
         new MenuItem (this.GetDigitsInReverseOrder,
            " 7. Get the digits of a decimal in reverse order."),

          /* 8. Напишете метод, който пресмята сумата на две цели
           * положителни цели числа. Числата са представени като
           * масив от цифрите си, като последната цифра (единиците)
           * са записани в масива под индекс 0. Направете така, че
           * метода да работи за числа с дължина до 10 000 цифри.
           */
         new MenuItem (this.SumBigIntegers,
            " 8. Get the sum of two very big nonnegative integers" +
            " in an array of digits."),
         new MenuItem (this.TestSumBigIntegers,
            "8a. Test-sum two big integers."),

          /* 9. Напишете метод, който намира най-големия елемент в
           * част от масив. Използвайте метода за да сортирате
           * възходящо/низходящо даден масив.
           */
         new MenuItem (this.IndexOfGreatestInRangeOfArrayElements,
            " 9. Find the greatest element in a range of an array" +
            " of integers."),
         new MenuItem (this.SelectionSortOfArrayOfIntegers,
            "9a. Perform a selection sort of an array of integers."),

         /* 10. Напишете програма, която пресмята и отпечатва n! за
          * всяко n в интервала [1...100].
          */
         new MenuItem (this.BigFactoriel,
            "10. Print the factoriel of every integer from 1 to 100."),

         /* 11. Напишете програма, която решава следните задачи:
            - Обръща последователността на цифрите на едно число.
            - Пресмята средното аритметично на дадена поредица от числа.
            - Решава линейното уравнение a * x + b = 0.
            Създайте подходящи методи за всяка една от задачите.
            Напишете програмата така, че на потребителя да му бъде
            изведено текстово меню, от което да избира коя от
            задачите да решава.
            Направете проверка на входните данни:
            - Десетичното число трябва да е неотрицателно.
            - Редицата не трябва да е празна.
            - Коефициентът a не трябва да е 0.
          */
         new MenuItem (this.ThreeTaskMethod,
            "11. Choose a problem to solve..."),

         /* 12. Напишете метод, който събира два полинома с цели
          * коефициенти, например (3x2 + x - 3) + (x - 1) =
          * (3x2 + 2x - 4).
          */
         new MenuItem (this.SumOfPolinoms,
            "12. Sum of polinoms..."),

         /* 13. Напишете метод, който умножава два полинома с цели
          * коефициенти, например (3x2 + x - 3) * (x - 1) =
          * (3x3 - 2x2 - 4x + 3).
          */
         new MenuItem (this.ProductOfPolinoms,
            "13. Product of polinoms..."),

      };
   }

   public int[] InputIntArray (int min = int.MinValue, int max = int.MaxValue)
   {
      Console.Write ("Size of array, n = ");
      int n = int.Parse (Console.ReadLine ());

      Console.WriteLine (
         "Enter values within range from {0} to {1}:", min, max);
      int[] a = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("a[{0}] = ", i);
         a[i] = int.Parse (Console.ReadLine ());
         if (a[i] < min || a[i] > max)
         {
            string err = string.Format (
               "Value in range from {0} to {1} is expected.", min, max);
            throw new System.IndexOutOfRangeException (err);
         }
      }

      return a;
   }

   public string GetIntArrayString (int[] arr,
                                    bool inverseOrder = false,
                                    string prefix = null,
                                    string suffix = null)
   {
      string str = string.Empty;
      if (inverseOrder)
         for (int i = arr.Length - 1; i >= 0; i--)
            str += prefix + arr[i] + string.Format(suffix, i);
      else
         for (int i = 0; i < arr.Length; i++)
            str += prefix + arr[i] + string.Format(suffix, i);
      return str;
   }

   public string SayHello (string name)
   {
      return string.Format ("Hello, {0}!", name);
   }

   public void SayHello ()
   {
      Console.Write ("Your name = ");
      string name = Console.ReadLine ();

      Console.WriteLine (this.SayHello (name));
   }

   public void TestHello ()
   {
      string[] names = {"Alice", "Bob", "Carol", "Danny", "Elinor"};

      int errors = 0;
      foreach (string name in names)
      {
         if (this.SayHello (name).Equals ("Hello, " + name + "!"))
         {
            Console.WriteLine (this.SayHello (name) + " [OK]");
         }
         else
         {
            Console.WriteLine (this.SayHello (name) + " [Error]");
            errors++;
         }
      }
      if (errors > 0)
      {
         Console.WriteLine (
            "There were {0} errors. The test failed.", errors);
      }
      else
      {
         Console.WriteLine (
            "There were no errors. The test was successful.", errors);
      }
   }

   public int GetMax (int a, int b)
   {
      if (a > b) return a;
      return b;
   }

   public void GetMax ()
   {
      Console.Write ("a = ");
      int a = int.Parse (Console.ReadLine ());
      Console.Write ("b = ");
      int b = int.Parse (Console.ReadLine ());
      Console.Write ("c = ");
      int c = int.Parse (Console.ReadLine ());

      Console.WriteLine (
         "max = {0}", this.GetMax (a, this.GetMax (b, c)));
   }

   public string SpellTheLastDigit (int n)
   {
      switch (n % 10)
      {
         default: return "zero";
         case 1: return "one";
         case 2: return "two";
         case 3: return "three";
         case 4: return "four";
         case 5: return "five";
         case 6: return "six";
         case 7: return "seven";
         case 8: return "eight";
         case 9: return "nine";
      }
   }

   public void SpellTheLastDigit ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      Console.WriteLine (this.SpellTheLastDigit (n));
   }

   public int CountArrayElementsWithGivenValue (int[] arr, int val)
   {
      int count = 0;
      foreach (int element in arr)
      {
         if (element == val) count++;
      }
      return count;
   }

   public void CountArrayElementsWithGivenValue ()
   {
      int[] a = InputIntArray ();

      Console.Write ("Value, v = ");
      int v = int.Parse (Console.ReadLine ());

      int cnt = this.CountArrayElementsWithGivenValue (a, v);

      if (cnt != 1)
      {
         Console.WriteLine (
         "There are {0} elements equal to {1} in the array.",
         cnt, v);
      }
      else
      {
         Console.WriteLine (
         "There is one element equal to {1} in the array.",
         cnt, v);
      }
   }

   public void TestCountArrayElementsWithGivenValue ()
   {
      int[] a = {1, 2, 11, 1, 1};

      bool ok = this.CountArrayElementsWithGivenValue (a, 1) == 3
         && this.CountArrayElementsWithGivenValue (a, 2) == 1
         && this.CountArrayElementsWithGivenValue (a, 12) == 0;

      if (ok)
      {
         Console.WriteLine ("The test was successful.");
      }
      else
      {
         Console.WriteLine ("The test failed.");
      }
   }

   public int? GetValueByIndex (int[] arr, int index)
   {
      if (index < 0 || index > arr.Length - 1)
      {
         return null;
      }
      else
      {
         return arr[index];
      }
   }

   public bool ElementIsLocalExtremum (int[] arr, int index)
   {
      int? a, b, c;
      a = GetValueByIndex (arr, index - 1);
      b = GetValueByIndex (arr, index);
      c = GetValueByIndex (arr, index + 1);

      if (b == null)
         return false;
      if (a == null && c == null)
         return true;
      if (a == null) a = c;
      if (c == null) c = a;
      if (a < b && b > c || a > b && b < c)
         return true;
      return false;
   }

   public void TestIfElementIsLocalExtremum ()
   {
      int[] a = this.InputIntArray ();

      Console.Write ("index = ");
      int index = int.Parse (Console.ReadLine ());

      Console.WriteLine (
         "The {0}. element of the array {1} a local extremum.",
         index, ElementIsLocalExtremum (a, index) ? "is" : "is not");
   }

   public void TestTheLocalExtremumTest ()
   {
      int[][] a = new int[][]{
         new int[]{1, 1, 2, 5, 8, -4, -3},
         new int[]{0, -1, 2, 55, 68, 68, 17, 17},
         new int[]{-24, -1, 2, 168, 168, 168, 8, 99},
      };

      for (int i = 0; i < a.Length; i++)
      {
         for (int j = 0; j < a[i].Length; j++)
         {
            Console.Write (
               "{0}{1}, ", a[i][j],
               ElementIsLocalExtremum (a[i], j) ? "[extm]" : "");
         }
         Console.WriteLine ();
      }
   }

   public int GetIndexOfFirstLocalMaximum (int[] arr)
   {
      if (arr.Length < 3)
         return -1;
      for (int i = 1; i < arr.Length - 1; i++)
      {
         if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
            return i;
      }
      return -1;
   }

   public void GetIndexOfFirstLocalMaximum ()
   {
      int[] a = this.InputIntArray ();

      int index = GetIndexOfFirstLocalMaximum (a);

      if (index < 0)
      {
         Console.WriteLine (
            "There are no local maximums in this array.");
      }
      else
      {
         Console.WriteLine (
            "The first local maximum is at {0}. element.", index);
      }
   }

   public int GetDigitsInReverseOrder (int n)
   {
      int m = 0, sign = (n < 0 ? -1 : 1);

      n *= sign;
      do
      {
         m *= 10;
         m += n % 10;
         n /= 10;
      }
      while (n > 0);

      return sign * m;
   }

   public void GetDigitsInReverseOrder ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      Console.WriteLine ("m = {0}", GetDigitsInReverseOrder (n));
   }

   public int[] SumBigIntegers (int[] a, int[] b)
   {
      int cLen = (a.Length < b.Length ? b.Length : a.Length) + 1;
      if (cLen > 10001)
      {
         throw new System.IndexOutOfRangeException (
            "Big integers should have no more than 10000 digits!");
      }

      int[] c = new int[cLen];

      int i = 0, x, y;
      while (i < c.Length - 1)
      {
         if (i < a.Length) x = a[i]; else x = 0;
         if (i < b.Length) y = b[i]; else y = 0;

         if (0 <= x && x <= 9 && 0 <= y && y <= 9)
         {
            c[i] += (x + y);
            c[i + 1] = c[i] / 10;
            c[i] %= 10;
         }
         else
         {
            throw new System.Exception ("Invalid data!");
         }

         i++;
      }

      return c;
   }

   public void SumBigIntegers ()
   {
      int[] a = this.InputIntArray (0, 9),
         b = this.InputIntArray (0, 9);

      Console.WriteLine (
         "{0} + {1} = {2}",
         this.GetIntArrayString (a, true),
         this.GetIntArrayString (b, true),
         this.GetIntArrayString (SumBigIntegers (a, b), true));
   }

   public void TestSumBigIntegers ()
   {
      int aLen = 55, bLen = 46;
      int[] a = new int[aLen], b = new int[bLen], c;

      Random rand = new Random ();
      for (int i = 0; i < aLen; i++)
      {
         a[i] = rand.Next (10);
      }

      for (int i = 0; i < bLen; i++)
      {
         b[i] = rand.Next (10);
      }

      c = SumBigIntegers (a, b);

      Console.WriteLine ("{0," + (c.Length + 3) + "}",
         this.GetIntArrayString (a, true));
      Console.WriteLine (" + ");
      Console.WriteLine ("{0," + (c.Length + 3) + "}",
         this.GetIntArrayString (b, true));
      Console.WriteLine (" = ");
      Console.WriteLine ("{0," + (c.Length + 3) + "}",
         this.GetIntArrayString (c, true));
   }

   public int IndexOfGreatestInRangeOfArrayElements (int[] arr,
                                                     int fromIndex,
                                                     int toIndex)
   {
      int maxValue = arr[fromIndex], indexOfMaxValue = fromIndex;
      for (int i = fromIndex; i <= toIndex; i++)
      {
         if (arr[i] > maxValue)
         {
            maxValue = arr[i];
            indexOfMaxValue = i;
         }
      }

      return indexOfMaxValue;
   }

   public void IndexOfGreatestInRangeOfArrayElements ()
   {
      int[] a = this.InputIntArray ();
      Console.Write ("From index = ");
      int indexFrom = int.Parse (Console.ReadLine ());
      Console.Write ("To index = ");
      int indexTo = int.Parse (Console.ReadLine ());

      int index = IndexOfGreatestInRangeOfArrayElements (
         a, indexFrom, indexTo);
      Console.WriteLine ("Index = {0}", index);
      Console.WriteLine ("Value = {0}", a[index]);
   }

   public void SelectionSortOfArrayOfIntegers (int[] arr,
                                               bool ascending = true)
   {
      int indexOfMaxValue, swapValue;
      if (ascending)
      {
         for (int i = arr.Length - 1; i >= 0; i--)
         {
            indexOfMaxValue = IndexOfGreatestInRangeOfArrayElements (
               arr, 0, i);

            swapValue = arr[i];
            arr[i] = arr[indexOfMaxValue];
            arr[indexOfMaxValue] = swapValue;
         }
      }
      else
      {
         for (int i = 0; i < arr.Length; i++)
         {
            indexOfMaxValue = IndexOfGreatestInRangeOfArrayElements (
               arr, i, arr.Length - 1);

            swapValue = arr[i];
            arr[i] = arr[indexOfMaxValue];
            arr[indexOfMaxValue] = swapValue;
         }
      }
   }

   public void SelectionSortOfArrayOfIntegers ()
   {
      int[] a = this.InputIntArray (), b = new int[a.Length];
      Array.Copy (a, b, a.Length);

      SelectionSortOfArrayOfIntegers (a);
      SelectionSortOfArrayOfIntegers (b, false);

      Console.WriteLine (
         this.GetIntArrayString (arr: a, suffix: "; "));
      Console.WriteLine (
         this.GetIntArrayString (arr: b, suffix: "; "));
   }

   public int[] IntToArrayOfDigitValues (int n)
   {
      if (n < 0) throw new System.ArgumentException (
         "Invalid input! (" + n + " < 0).");

      int[] c = new int[n.ToString ().Length];

      int i = 0;
      if (n == 0)
      {
         c[i] = 0;
      }
      while (n > 0)
      {
         c[i] = n % 10;
         n /= 10;
         i++;
      }

      return c;
   }

   public int[] MultiplyBigIntegers (int[] a, int[] b)
   {
      int[] c = new int[a.Length + b.Length];

      for (int i = 0; i < a.Length; i++)
      {
         for (int j = 0; j < b.Length; j++)
         {
            c[i + j] += (a[i] * b[j]);
            c[i + j + 1] += c[i + j] / 10;
            c[i + j] %= 10;
         }
      }

      if (c[c.Length - 1] == 0)
      {
         int[] d = new int[c.Length - 1];
         Array.Copy (c, d, c.Length - 1);
         return d;
      }

      return c;
   }

   public void TestMultiplyBigIntegers ()
   {
      Console.Write ("x = ");
      int x = int.Parse (Console.ReadLine ());
      Console.Write ("y = ");
      int y = int.Parse (Console.ReadLine ());
      Console.WriteLine ("{0} * {1} = {2}", x, y, x * y);

      int[] a = this.IntToArrayOfDigitValues (x);
      int[] b = this.IntToArrayOfDigitValues (y);
      int[] c = this.MultiplyBigIntegers (a, b);

      Console.WriteLine ("{0} * {1} = {2}",
                         this.GetIntArrayString (a, true),
                         this.GetIntArrayString (b, true),
                         this.GetIntArrayString (c, true));
   }

   public void BigFactoriel ()
   {
      long factoriel = 1L;
      int[] bigFactoriel = new int[]{1}, bigN;
      string bigFactorielString;

      for (int i = 1; i <= 100; i++)
      {
         unchecked { factoriel *= i; }

         bigN = IntToArrayOfDigitValues (i);
         bigFactoriel = MultiplyBigIntegers (bigFactoriel, bigN);
         bigFactorielString = this.GetIntArrayString (
            bigFactoriel, true);

         Console.WriteLine (
            "{0}! = {1} (unchecked long)", i, factoriel);
         Console.WriteLine (
            "{0}! = {1} (array of digit values)", i, bigFactorielString);
         Console.WriteLine (
            factoriel.ToString ().Equals (
               bigFactorielString) ? "OK" : "Error (long overflow)");
         Console.WriteLine ();
      }
   }

   public void ReverseDigits ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (n < 0)
         throw new System.ArgumentOutOfRangeException (
            "A nonnegative integer is required.");

      int reverse = 0;

      while (n > 0)
      {
         reverse *= 10;
         reverse += n % 10;
         n /= 10;
      }

      Console.WriteLine ("Reversed n = {0}", reverse);
   }

   public void FindAverage ()
   {
      int[] a = this.InputIntArray ();
      double sum = 0.0;

      if (a.Length > 0)
      {
         for (int i = 0; i < a.Length; i++)
         {
            sum += a[i];
         }

         Console.WriteLine ("Average = {0}", sum / a.Length);
      }
      else
      {
         throw new System.ArgumentException (
            "The array must contain at least one element.");
      }
   }

   public void SolveLinearEquation ()
   {
      Console.WriteLine ("Solve the equation ax + b = 0.");

      Console.Write ("a = ");
      double a = double.Parse (Console.ReadLine ());
      if (a == 0.0)
         throw new DivideByZeroException ();

      Console.Write ("b = ");
      double b = double.Parse (Console.ReadLine ());

      double x = - b / a;

      Console.WriteLine ("x = {0}", x);
   }

   public void ThreeTaskMethod ()
   {
      Console.WriteLine ("1. Print a number digits in reverse order.");
      Console.WriteLine ("2. Find the average of a sequence of numbers.");
      Console.WriteLine ("3. Solve a linear euqtion.");
      Console.WriteLine ();
      Console.Write ("Enter the number of a task to execute: ");
      char ch = char.Parse (Console.ReadLine ());

      switch (ch)
      {
         case '1': this.ReverseDigits (); break;
         case '2': this.FindAverage (); break;
         case '3': this.SolveLinearEquation (); break;
      }

      Console.WriteLine ("Game over!");
   }

   public void SumOfPolinoms ()
   {
      Console.WriteLine (
         "Enter the coefficients of the first polinom...");
      int[] a = this.InputIntArray ();
      Console.WriteLine (
         "Enter the coefficients of the second polinom...");
      int[] b = this.InputIntArray ();

      int[] larger = (a.Length > b.Length ? a : b),
         shorter = (a.Length < b.Length ? a : b);

      int[] sum = new int[larger.Length];
      for (int i = 0; i < larger.Length; i++)
      {
         sum[i] = larger[i];
         if (i < shorter.Length) sum[i] += shorter[i];
      }

      Console.WriteLine ("{0} + {1} = {2}",
         this.GetIntArrayString (
            arr: a, inverseOrder: true, suffix: ".x^{0} "),
         this.GetIntArrayString (
            arr: b, inverseOrder: true, suffix: ".x^{0} "),
         this.GetIntArrayString (
            arr: sum, inverseOrder: true, suffix: ".x^{0} "));
   }

   public void ProductOfPolinoms ()
   {
      Console.WriteLine (
         "Enter the coefficients of the first polinom...");
      int[] a = this.InputIntArray ();
      Console.WriteLine (
         "Enter the coefficients of the second polinom...");
      int[] b = this.InputIntArray ();

      int[] product = new int[a.Length + b.Length - 1];
      for (int i = 0; i < a.Length; i++)
      {
         for (int j = 0; j < b.Length; j++)
         {
            product[i + j] += (a[i] * b[j]);
         }
      }

      Console.WriteLine ("{0} * {1} = {2}",
         this.GetIntArrayString (
            arr: a, inverseOrder: true, suffix: ".x^{0} "),
         this.GetIntArrayString (
            arr: b, inverseOrder: true, suffix: ".x^{0} "),
         this.GetIntArrayString (
            arr: product, inverseOrder: true, suffix: ".x^{0} "));
   }
}

