using System;
using IntroCSharp;

class Chapter10: Menu
{
   public Chapter10 ()
   {
      this.MenuTitle = "Chapter 10 - exercises.";

      this.Options = new MenuItem[] {
         /* 1. Напишете програма, която симулира изпълнението на n
          * вложени цикъла от 1 до n.
          */
         new MenuItem (this.NLoopsFrom1ToN,
            " 1. Print the counter values for each step of n nested" +
            " loops form 1 to n."),

         /* 2. Напишете рекурсивна програма, която генерира и
          * отпечатва всички комбинации с повторение на k елемента
          * над n-елементно множество.
          */
         new MenuItem (this.SubsetsWithGivenNumberOfElements,
            " 2. Print all k-element subsets of a n-element set."),

         /* 3. Напишете рекурсивна програма, която генерира всички
          * вариации с повторение на n елемента от k-ти клас.
          */
         new MenuItem (this.OrderedSubsetsWithGivenNumberOfElements,
            " 3. Print all k-element ordered subsets of a set of" +
            " n elements."),

         /* 4. Нека е дадено множество от символни низове. Да се
          * напише рекурсивна програма, която генерира всички
          * подмножества съставени от точно k на брой символни низа,
          * избрани измежду елементите на това множество.
          */
         new MenuItem (this.ConcatenateNumberOfStringsInEveryWay,
            " 4. Concatenate every k of n strings in every" +
            " possible way."),

         /* 5. Напишете рекурсивна програма, която отпечатва всички
          * подмножества на дадено множество от думи.
          */
         new MenuItem (this.PrintAllSubsetsOfWords,
            " 5. Print all subsets of a set of words."),

         /* 6. Реализирайте алгоритъма "сортиране чрез сливане"
          * (merge-sort). При него началният масив се разделя на две
          * равни по големина части, които се сортират (рекурсивно
          * чрез merge-sort) и след това двете сортирани части се
          * сливат, за да се получи целият масив в сортиран вид.
          */
         new MenuItem (this.MergeSort,
            " 6. Merge-sort."),

         /* 7. Напишете рекурсивна програма, която генерира и
          * отпечатва пермутациите на числата 1, 2, ..., n, за дадено
          * цяло число n.
          */
         new MenuItem (this.Permutations,
            " 7. Permutations of first n natural numbers."),

         /* 8. Даден е масив с цели числа и число N. Напишете
          * рекурсивна програма, която намира всички подмножества
          * от числа от масива, които имат сума N.
          */
         new MenuItem (this.PrintSumsEqualToNumber,
            " 8. Print all sums in a set of integers, which are" +
            " equal to a given number."),

         /* 9. Даден е масив с цели *положителни* числа. Напишете
          * програма, която проверява дали в масива съществуват едно
          * или повече числа, чиято сума е N. Можете ли да решите
          * задачата без рекурсия?
          */
         new MenuItem (this.CountSumsOfPositiveIntegersEqualToNumber,
            " 9. Count all sums in a set of positive integers," +
            "which are equal to a given number."),

         /* 10. Дадена е матрица с проходими и непроходими клетки.
          * Напишете рекурсивна програма, която намира всички пътища
          * между две клетки в матрицата.
          */
         new MenuItem (this.PrintPathsBetweenCellsInMaze,
            " 10. Print all paths between two cells in a maze."),

         /* 11. Модифицирайте горната програма, за да проверява дали
          * съществува път между две клетки без да се намират всички
          * възможни пътища. Тествайте за матрица 100х100 пълна само
          * с проходими клетки.
          */
         new MenuItem (this.CheckForPathBetweenCellsInMaze,
            " 11. Check if a path between two cells in a maze exists."),

         /* 12. Напишете програма, която намира най-дългата поредица
          * от съседни проходими клетки в матрица.
          */
         new MenuItem (this.FindLongestFreePathInMaze,
            " 12. Find longest free path in a maze."),
      };
   }

   public void PrintLine (int[] a)
   {
      for (int j = 0; j < a.Length; j++)
      {
         Console.Write ("{0,4}", a[j]);
      }
      Console.WriteLine ();
   }

   public bool SetNextIteration (ref int[] a)
   {
      int n = a.Length, index = a.Length - 1;
      while (index > -1)
      {
         if (a[index] < n)
         {
            a[index]++;
            break;
         }
         else
         {
            a[index] = 1;
            index--;
         }
      }
      return index > -1;
   }

   public void RunAndPrintCountersOfNestedLoops (
      ref int[] loopCounters, int startAtLoop = 0)
   {
      if (startAtLoop < loopCounters.Length - 1)
      {
         for (int i = 0; i < loopCounters.Length; i++)
         {
            loopCounters[startAtLoop] = i + 1;
            this.RunAndPrintCountersOfNestedLoops (
               ref loopCounters, startAtLoop + 1);
         }
      }
      else // startAtLoop == loopCounters.Length - 1
      {
         for (int i = 0; i < loopCounters.Length; i++)
         {
            loopCounters[startAtLoop] = i + 1;
            this.PrintLine (loopCounters);

            if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
            {
               loopCounters = new int[0];
               break;
            }
         }
      }
   }

   public void NLoopsFrom1ToN ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      int[] a = new int[n];

      Console.WriteLine ("An iterative solution...");
      for (int i = 0; i < n; i++)
      {
         a[i] = 1;
      }
      while (this.SetNextIteration (ref a))
      {
         this.PrintLine (a);

         if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
         {
            break;
         }
      }

      Console.WriteLine ("A recursive solution...");
      this.RunAndPrintCountersOfNestedLoops (ref a);
   }

   public void RunAndPrintGrowingCountersOfNestedLoops (
      ref int max, ref int[] loopCounters, int startAtLoop = 0)
   {
      int i = 0;
      if (startAtLoop > 0)
      {
         i = loopCounters[startAtLoop - 1];
      }

      if (startAtLoop < loopCounters.Length - 1)
      {
         for (; i < max - loopCounters.Length + startAtLoop + 1; i++)
         {
            loopCounters[startAtLoop] = i + 1;
            this.RunAndPrintGrowingCountersOfNestedLoops (
               ref max, ref loopCounters, startAtLoop + 1);
         }
      }
      else // startAtLoop == loopCounters.Length - 1
      {
         for (; i < max; i++)
         {
            loopCounters[startAtLoop] = i + 1;
            this.PrintLine (loopCounters);

            if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
            {
               max = 0;
               break;
            }
         }
      }
   }

   public bool AddOneStep (ref int[] a, int max)
   {
      int index = a.Length - 1;
      while (index >= 0)
      {
         if (a[index] == max - a.Length + 1 + index)
         {
            index--;
         }
         else
         {
            a[index]++;
            index++;
            while (index < a.Length)
            {
               a[index] = a[index - 1] + 1;
               index++;
            }
            return true;
         }
      }
      return false;
   }

   public void PrintCombs (int n, int k)
   {
      int[] a = new int[k];
      for (int index = 0; index < k; index++)
      {
         a[index] = index + 1;
      }

      do
      {
         this.PrintLine (a);

         if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
         {
            break;
         }
      }
      while (this.AddOneStep (ref a, n));
   }

   public void SubsetsWithGivenNumberOfElements ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      Console.WriteLine ("An iterative solution...");
      this.PrintCombs (n, k);

      Console.WriteLine ("A recursive solution...");
      int[] a = new int[k];
      this.RunAndPrintGrowingCountersOfNestedLoops (ref n, ref a);
   }

   public void OrderedSubsetsWithGivenNumberOfElements ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      int[] elems = new int[n];
      for (int i = 0; i < n; i++)
      {
         elems[i] = i + 1;
      }

      Console.WriteLine ("An iterative solution...");
      this.PrintVariations (elems, k);

      Console.WriteLine ("A recursive solution...");
      int[] a = new int[k];
      this.PrintVariationsRecursively (ref a, ref elems);
   }

   public bool IsValidVariation (ref int[] a)
   {
      for (int i = 0; i < a.Length - 1; i++)
      {
         for (int j = i + 1; j < a.Length; j++)
         {
            if (a[i] == a[j]) return false;
         }
      }
      return true;
   }

   public bool AddOne (ref int[] number, int systemBase)
   {
      int i = number.Length - 1;
      while (i >= 0)
      {
         if (number[i] < systemBase - 1)
         {
            number[i]++;
            return true;
         }
         else
         {
            number[i] = 0;
            i--;
         }
      }
      return false;
   }

   public void PrintVariations<T> (T[] elements, int k)
   {
      int[] a = new int[k];
      for (int i = 0; i < k; i++)
      {
         a[i] = i;
      }

      do
      {
         if (this.IsValidVariation (ref a))
         {
            for (int j = 0; j < k; j++)
            {
               Console.Write ("{0} ", elements[a[j]]);
            }
            Console.WriteLine ();

            if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
            {
               break;
            }
         }
      }
      while (this.AddOne (ref a, elements.Length));
   }

   public void PrintVariationsRecursively<T> (ref int[] subset, ref T[] elements, int index = 0)
   {
      if (index < 0)
      {
         return;
      }
      else if (index == subset.Length)
      {
         if (this.IsValidVariation (ref subset))
         {
            for (int j = 0; j < subset.Length; j++)
            {
               Console.Write ("{0} ", elements[subset[j]]);
            }
            Console.WriteLine ();

            if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
            {
               subset = new int[0];
            }
         }
      }
      else
      {
         for (int i = 0; i < elements.Length && index < subset.Length; i++)
         {
            subset[index] = i;
            this.PrintVariationsRecursively (ref subset, ref elements, index + 1);
         }
      }
   }

   public void ConcatenateNumberOfStringsInEveryWay ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      string[] words = new string[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("Next word = ");
         words[i] = Console.ReadLine ();
      }

      Console.WriteLine ("An iterative solution...");
      this.PrintVariations (words, k);

      Console.WriteLine ("A recursive solution...");
      int[] a = new int[k];
      this.PrintVariationsRecursively (ref a, ref words);
   }

   public void PrintAllSubsetsOfWords ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      string[] words = new string[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("Next word = ");
         words[i] = Console.ReadLine ();
      }

      Console.WriteLine (NL + "An iterative solution...");
      this.PrintSubsets<string> (ref words);

      Console.WriteLine (NL + "A recursive solution...");
      bool[] b = new bool[words.Length];
      this.PrintSubsetsRecursively<string> (ref words, ref b);
   }

   public void PrintSubsets<T> (ref T[] elements)
   {
      int[] a;

      for (int i = 0; i < elements.Length; i++)
      {
         a = new int[i + 1];
         for (int j = 0; j < a.Length; j++)
         {
            a[j] = j;
         }

         do
         {
            for (int j = 0; j < a.Length; j++)
            {
               Console.Write ("{0} ", elements[a[j]]);
            }
            Console.WriteLine ();

            if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
            {
               a = new int[0];
            }
         }
         while (this.NextCombination (ref a, elements.Length));
      }
   }

   public bool NextCombination (ref int[] a, int max)
   {
      int index = a.Length - 1;
      while (index >= 0)
      {
         if (a[index] == max - a.Length + index)
         {
            index--;
         }
         else if (a[index] < max - a.Length + index)
         {
            a[index]++;
            index++;
            while (index < a.Length)
            {
               a[index] = a[index - 1] + 1;
               index++;
            }
            return true;
         }
         else
         {
            throw new System.ArgumentOutOfRangeException ();
         }
      }
      return false;
   }

   public void PrintSubsetsRecursively<T> (ref T[] elements, ref bool[] absent, int index = 0)
   {
      if (index == elements.Length)
      {
         for (int j = 0; j < elements.Length; j++)
         {
            if (!absent[j]) Console.Write ("{0} ", elements[j]);
         }
         Console.WriteLine ();

         if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
         {
            absent = new bool[0];
         }
      }
      else if (index < elements.Length)
      {
         absent[index] = false;
         this.PrintSubsetsRecursively<T> (ref elements, ref absent, index + 1);
         absent[index] = true;
         this.PrintSubsetsRecursively<T> (ref elements, ref absent, index + 1);
      }
      else
      {
         throw new System.ArgumentOutOfRangeException ();
      }
   }

   public void MergeSort ()
   {
      Console.WriteLine (NL + "Merge-sort integers...");
      int[] a = InputArray<int> (ReadAndParseInteger);
      this.MergeSort (ref a, IsGreaterInteger);

      for (int i = 0; i < a.Length; i++)
      {
         Console.Write("{0}; ", a[i]);
      }
      Console.WriteLine();

      Console.WriteLine (NL + "Merge-sort strings...");
      string[] b = InputArray<string> (ReadAndParseString);
      this.MergeSort (ref b, IsGreaterString);

      for (int i = 0; i < b.Length; i++)
      {
         Console.Write("{0}; ", b[i]);
      }
      Console.WriteLine();
   }

   public void MergeSortedArraysTest ()
   {
      Console.WriteLine (NL + "Merge sorted arrays of integers...");
      int[] a = InputArray<int> (ReadAndParseInteger);
      int[] b = InputArray<int> (ReadAndParseInteger);

      int[] c = MergeSortedArrays<int> (ref a, ref b, IsGreaterInteger);

      for (int i = 0; i < c.Length; i++)
      {
         Console.Write("{0}; ", c[i]);
      }
      Console.WriteLine();

      Console.WriteLine (NL + "Merge sorted arrays of strings...");
      string[] x = InputArray<string> (ReadAndParseString);
      string[] y = InputArray<string> (ReadAndParseString);

      string[] z = MergeSortedArrays<string> (ref x, ref y, IsGreaterString);

      for (int i = 0; i < z.Length; i++)
      {
         Console.Write("{0}; ", z[i]);
      }
      Console.WriteLine();
   }

   public delegate bool IsGreater<T> (T a, T b);

   public bool IsGreaterInteger (int a, int b)
   {
      return (a > b);
   }

   public bool IsGreaterString (string a, string b)
   {
      return a.CompareTo (b) > 0;
   }

   public delegate T ReadAndParse<T> ();

   public int ReadAndParseInteger ()
   {
      return int.Parse (Console.ReadLine ());
   }

   public uint ReadAndParseUnsignedInteger ()
   {
      return uint.Parse (Console.ReadLine ());
   }

   public string ReadAndParseString ()
   {
      return Console.ReadLine ();
   }

   public T[] InputArray<T>(ReadAndParse<T> parse)
   {
      Console.Write ("Number of elements = ");
      int n = int.Parse (Console.ReadLine ());
      T[] a = new T[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("a[{0}] = ", i);
         a[i] = parse ();
      }
      return a;
   }

   public T[] MergeSortedArrays<T> (ref T[] a, ref T[] b,
                                    IsGreater<T> isGreater)
   {
      T[] c = new T[a.Length + b.Length];
      int i = a.Length - 1, j = b.Length - 1;
      while (i + j + 1 >= 0)
      {
         if (i < 0)
         {
            c[i + j + 1] = b[j--];
         }
         else if (j < 0)
         {
            c[i + j + 1] = a[i--];
         }
         else if (isGreater(a[i], b[j]))
         {
            c[i + j + 1] = a[i--];
         }
         else
         {
            c[i + j + 1] = b[j--];
         }
      }
      return c;
   }

   public void MergeSort<T> (ref T[] x, IsGreater<T> isGreater)
   {
      int d = x.Length;

      if (d < 2)
      {
         return;
      }
      else
      {
         T[] a = new T[d / 2];
         for (int i = 0; i < a.Length; i++)
         {
            a[i] = x[i];
         }
         this.MergeSort<T> (ref a, isGreater);
         T[] b = new T[d - d / 2];
         for (int i = 0; i < b.Length; i++)
         {
            b[i] = x[d / 2 + i];
         }
         this.MergeSort<T> (ref b, isGreater);
         x = this.MergeSortedArrays<T> (ref a, ref b, isGreater);
      }
   }

   public void Permutations ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      int[] a = new int[n], b = new int[n];
      for (int i = 0; i < n; i++)
      {
         a[i] = i + 1;
      }

      this.PrintVariationsRecursively<int> (ref b, ref a);

      this.Perm (ref a, a.Length - 1);
   }

   public void PrintSums (ref int[] x, ref bool[] sums, int n, int index = 0)
   {
      if (index < x.Length)
      {
         sums[index] = true;
         this.PrintSums (ref x, ref sums, n, index + 1);
         sums[index] = false;
         this.PrintSums (ref x, ref sums, n, index + 1);
      }
      else
      {
         int sum = 0, count = 0;
         for (int i = 0; i < x.Length; i++)
         {
            if (sums[i])
            {
               sum += x[i];
               count++;
            }
         }
         if (sum == n && count > 0)
         {
            for (int i = 0; i < x.Length; i++)
            {
               if (sums[i])
               {
                  Console.Write ("{0}; ", x[i]);
               }
            }
            Console.WriteLine ("Sum = {0}", sum);
         }
      }
   }

   public void PrintSumsEqualToNumber ()
   {
      int[] a = InputArray<int> (ReadAndParseInteger);
      bool[] b = new bool[a.Length];

      Console.Write ("Sum = ");
      int sum = int.Parse (Console.ReadLine ());

      this.PrintSums (ref a, ref b, sum);
   }

   public int CountSubsetSumsEqualToNumber (ref uint[] x, ref bool[] sums, uint n, int index = 0)
   {
      if (index < x.Length)
      {
         int a, b;
         sums[index] = true;
         a = this.CountSubsetSumsEqualToNumber (ref x, ref sums, n, index + 1);
         sums[index] = false;
         b = this.CountSubsetSumsEqualToNumber (ref x, ref sums, n, index + 1);
         return a + b;
      }
      else
      {
         uint sum = 0u;
         int count = 0;
         for (int i = 0; i < x.Length; i++)
         {
            if (sums[i])
            {
               sum += x[i];
               count++;
            }
         }
         if (sum == n && count > 0)
         {
            return 1;
         }
         else
         {
            return 0;
         }
      }
   }

   public int CountSubsetSumsEqualToNumberIteratively (uint[] a, uint sum)
   {
      int selectedSubsetsCount = 0, setMembers = a.Length;
      ulong subSetBitMap = 1uL;
      while (subSetBitMap < (1uL << setMembers))
      {
         int index = 0;
         uint tempSum = 0u;
         ulong temp = subSetBitMap;
         while (temp > 0uL)
         {
            if (temp % 2uL == 1uL)
            {
               tempSum += a[index];
            }
            index++;
            temp /= 2uL;
         }
         if (tempSum == sum)
         {
            selectedSubsetsCount++;
         }

         subSetBitMap++;
      }
      return selectedSubsetsCount;
   }

   public uint[] GetArrayOfRandomPositiveIntegers (int count, int max = int.MaxValue)
   {
      uint[] c = new uint[count];

      Random rnd = new Random ();
      for (int i = 0; i < count; i++)
      {
         c[i] = (uint) (rnd.Next () % max + 1);
      }

      return c;
   }

   public void PrintVector<T> (T[] array)
   {
      for (int i = 0; i < array.Length; i++)
      {
         Console.Write ("{0}; ", array[i]);
      }
      Console.WriteLine ();
   }

   public void CountSumsOfPositiveIntegersEqualToNumber ()
   {
      int testCount = 6, methodCount = 3;
      uint[] a;
      DateTime[] times = new DateTime[methodCount + 1];
      TimeSpan[,] testTimes = new TimeSpan[testCount, methodCount];
      for (int testNo = 0; testNo < testCount; testNo++)
      {
         int count = testNo * 4 + 4;
         a = this.GetArrayOfRandomPositiveIntegers (count, count);
         this.PrintVector<uint> (a);

         bool[] b = new bool[a.Length];
         System.Collections.Hashtable t = new System.Collections.Hashtable ();

         uint sum = (uint)(count * count / 4);

         times[0] = DateTime.Now;
         Console.WriteLine ("An iterative solution...");
         Console.WriteLine ("Count of sums (equal to {0}) = {1}", sum,
            this.CountSubsetSumsEqualToNumberIteratively (a, sum));

         times[1] = DateTime.Now;
         Console.WriteLine ("A recursive solution...");
         Console.WriteLine ("Count of sums (equal to {0}) = {1}", sum,
            this.CountSubsetSumsEqualToNumber (ref a, ref b, sum));

         times[2] = DateTime.Now;
         Console.WriteLine ("A more efficient recursive solution...");
         Console.WriteLine ("Count of sums (equal to {0}) = {1}", sum,
            this.SubsetSumsCount (ref a, ref t, a.Length - 1, sum));
   
         times[3] = DateTime.Now;

         testTimes[testNo, 0] = times[1] - times[0];
         testTimes[testNo, 1] = times[2] - times[1];
         testTimes[testNo, 2] = times[3] - times[2];
      }

      for (int testNo = 0; testNo < testCount; testNo++)
      {
         for (int methodNo = 0; methodNo < methodCount; methodNo++)
         {
            Console.Write ("{0,20}", testTimes[testNo, methodNo]);
         }
         Console.WriteLine ();
      }
   }

   public bool ParseBool (string boolean)
   {
      char ch;
      if (boolean.Length > 0)
      {
         ch = boolean.Substring (0, 1).ToLower ().ToCharArray ()[0];
      }
      else
      {
         ch = '0';
      }
      switch (ch)
      {
         case 't': return true;
         case 'y': return true;
         case '1': return true;
         default: return false;
      }
   }

   public int[,] InputMaze ()
   {
      Console.WriteLine ("Input dimensions of your maze...");
      Console.Write ("Number of rows = ");
      int m = int.Parse (Console.ReadLine ());
      Console.Write ("Number of columns = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("Empty cells (no less then) = ");
      int cellsAvailable = m * n - int.Parse (Console.ReadLine ());

      int[,] maze = new int[m, n];
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n && cellsAvailable > 0; j++)
         {
            Console.Write ("a[{0}, {1}] = ", i, j);
            maze[i, j] = this.ParseBool (Console.ReadLine ()) ? -1 : 0;
            Console.SetCursorPosition (20, Console.CursorTop - 1);
            Console.WriteLine (" ({0})", maze[i, j] == 0 ? "free" : "wall");
            cellsAvailable += maze[i, j];
         }
      }
      return maze;
   }

   public void PrintMaze (int[,] maze)
   {
      if (maze.GetLength (1) > Console.BufferWidth / 7)
      {
         Console.WriteLine ("Your maze is too large to be" +
          " represented in {0} columns...", Console.BufferWidth / 7);
         return;
      }

      Console.WriteLine (
         "This is a numeric representation of your maze...");
      int m = maze.GetLength (0);
      int n = maze.GetLength (1);

      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            Console.Write ("{0,7}", maze[i, j]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();
   }

   public void DrawMaze (int[,] maze)
   {
      if (maze.GetLength (1) > Console.BufferWidth)
      {
         Console.WriteLine ("Your maze is too large to be" +
          " represented in {0} columns...", Console.BufferWidth);
         return;
      }

      Console.WriteLine (
         "This is a text-mode representation of your maze...");
      int m = maze.GetLength (0);
      int n = maze.GetLength (1);
      char ch;
      int code;

      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            code = maze[i, j];
            if (code > 1)
            {
               code = 0;
               if (i > 0 && maze[i, j] == maze[i - 1, j] + 1 ||
                   i > 0 && maze[i, j] == maze[i - 1, j] - 1)
               {
                  code = 1;
               }
               if (i < m - 1 && maze[i, j] == maze[i + 1, j] + 1 ||
                   i < m - 1 && maze[i, j] == maze[i + 1, j] - 1)
               {
                  code += 2;
               }
               if (j > 0 && maze[i, j] == maze[i, j - 1] + 1 ||
                   j > 0 && maze[i, j] == maze[i, j - 1] - 1)
               {
                  code += 4;
               }
               if (j < n - 1 && maze[i, j] == maze[i, j + 1] + 1 ||
                   j < n - 1 && maze[i, j] == maze[i, j + 1] - 1)
               {
                  code += 8;
               }
            }
            switch (code)
            {
               // free cells
               case 0: ch = '\x2591'; break; // light shade 25%
               // wall cells
               case -1: ch = '\x2588'; break; // full block
               // cells of the selected pathway
               case 3: ch = '\x2502'; break; // light vertical
               case 12: ch = '\x2500'; break; // light horizontal
               case 9: ch = '\x2514'; break; // light up and right
               case 10: ch = '\x250C'; break; // light down and right
               case 6: ch = '\x2510'; break; // light down and left
               case 5: ch = '\x2518'; break; // light up and left
               // entry and exit points
               default: ch = '\x2715'; break; // multiplication 'x'
            }
            Console.Write ("{0}", ch);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();
   }

   public struct Cell
   {
      public int row, column, number;

      public Cell (int r, int c, int n = 0)
      {
         this.row = r;
         this.column = c;
         this.number = n;
      }
   }

   public bool IsInsideMaze (int[,] maze, Cell cell)
   {
      if (cell.row < 0 || cell.row > maze.GetLength (0) - 1 ||
          cell.column < 0 || cell.column > maze.GetLength (1) - 1)
         return false;
      return true;
   }

   public void PrintPathways (ref int[,] maze, Cell a, Cell b)
   {
      if (this.IsInsideMaze (maze, a) &&
          this.IsInsideMaze (maze, b) &&
          maze[a.row, a.column] == 0 &&
          maze[b.row, b.column] == 0)
      {
         maze[a.row, a.column] = a.number;
         if (a.row == b.row && a.column == b.column)
         {
            this.PrintMaze (maze);
            this.DrawMaze (maze);
            maze[a.row, a.column] = 0;

            if (new Pause (true).IsOver)
            {
               maze = new int[0, 0];
            }
         }
         else
         {
            Cell c = new Cell (a.row - 1, a.column, a.number + 1);
            this.PrintPathways (ref maze, c, b);
            c = new Cell (a.row + 1, a.column, a.number + 1);
            this.PrintPathways (ref maze, c, b);
            c = new Cell (a.row, a.column - 1, a.number + 1);
            this.PrintPathways (ref maze, c, b);
            c = new Cell (a.row, a.column + 1, a.number + 1);
            this.PrintPathways (ref maze, c, b);

            if (this.IsInsideMaze (maze, a))
            {
               maze[a.row, a.column] = 0;
            }
         }
      }
   }

   public bool IsPathwayFound (ref int[,] maze, Cell a, Cell b)
   {
      if (this.IsInsideMaze (maze, a) &&
          this.IsInsideMaze (maze, b) &&
          maze[a.row, a.column] == 0 &&
          maze[b.row, b.column] == 0)
      {
         maze[a.row, a.column] = a.number;
         if (a.row == b.row && a.column == b.column)
         {
            maze[a.row, a.column] = 0;
            return true;
         }
         else
         {
            Cell c = new Cell (a.row - 1, a.column, a.number + 1);
            if (this.IsPathwayFound (ref maze, c, b))
            {
               return true;
            }
            c = new Cell (a.row + 1, a.column, a.number + 1);
            if (this.IsPathwayFound (ref maze, c, b))
            {
               return true;
            }
            c = new Cell (a.row, a.column - 1, a.number + 1);
            if (this.IsPathwayFound (ref maze, c, b))
            {
               return true;
            }
            c = new Cell (a.row, a.column + 1, a.number + 1);
            if (this.IsPathwayFound (ref maze, c, b))
            {
               return true;
            }
            return false;
         }
      }
      return false;
   }

   public void PrintPathsBetweenCellsInMaze ()
   {
      int[,] maze = this.InputMaze ();
      this.PrintMaze (maze);
      this.DrawMaze (maze);

      Console.WriteLine ("Input coordinates of your first cell...");
      Console.Write ("Row = ");
      int r1 = int.Parse (Console.ReadLine ());
      Console.Write ("Column = ");
      int c1 = int.Parse (Console.ReadLine ());
      Console.WriteLine ("Input coordinates of your second cell...");
      Console.Write ("Row = ");
      int r2 = int.Parse (Console.ReadLine ());
      Console.Write ("Column = ");
      int c2 = int.Parse (Console.ReadLine ());

      this.PrintPathways (
         ref maze, new Cell (r1, c1, 1), new Cell (r2, c2));
   }

   public void CheckForPathBetweenCellsInMaze ()
   {
      int[,] maze = this.InputMaze ();
      this.PrintMaze (maze);
      this.DrawMaze (maze);

      Console.WriteLine ("Input coordinates of your first cell...");
      Console.Write ("Row = ");
      int r1 = int.Parse (Console.ReadLine ());
      Console.Write ("Column = ");
      int c1 = int.Parse (Console.ReadLine ());
      Console.WriteLine ("Input coordinates of your second cell...");
      Console.Write ("Row = ");
      int r2 = int.Parse (Console.ReadLine ());
      Console.Write ("Column = ");
      int c2 = int.Parse (Console.ReadLine ());

      if (this.IsPathwayFound (
            ref maze, new Cell (r1, c1, 1), new Cell (r2, c2)))
      {
         Console.WriteLine ("A pathway is found!");
      }
      else
      {
         Console.WriteLine (
            "There are no pathways between these cells!");
      }
   }

   public int MaxLengthOfPathsFromCell (ref int[,] maze, Cell a)
   {
      if (this.IsInsideMaze (maze, a) && maze[a.row, a.column] == 0)
      {
         maze[a.row, a.column] = a.number;
         Cell c = new Cell (a.row - 1, a.column, a.number + 1);
         int up = this.MaxLengthOfPathsFromCell (ref maze, c);
         c = new Cell (a.row + 1, a.column, a.number + 1);
         int down = this.MaxLengthOfPathsFromCell (ref maze, c);
         c = new Cell (a.row, a.column - 1, a.number + 1);
         int left = this.MaxLengthOfPathsFromCell (ref maze, c);
         c = new Cell (a.row, a.column + 1, a.number + 1);
         int right = this.MaxLengthOfPathsFromCell (ref maze, c);

         maze[a.row, a.column] = 0;
         return Math.Max (up, Math.Max (down, Math.Max (left, right))) + 1;
      }
      return 0;
   }

   public int MaxLengthOfPathsInMaze (ref int[,] maze)
   {
      int maxLength = 0, maxLengthFromCell;
      for (int i = 0; i < maze.GetLength (0); i++)
      {
         for (int j = 0; j < maze.GetLength (1); j++)
         {
            maxLengthFromCell = this.MaxLengthOfPathsFromCell (
               ref maze, new Cell (i, j, 1));
            if (maxLengthFromCell > maxLength)
            {
               maxLength = maxLengthFromCell;
            }
         }
      }
      return maxLength;
   }

   public void FindLongestFreePathInMaze ()
   {
      int[,] maze = this.InputMaze ();
      this.PrintMaze (maze);
      this.DrawMaze (maze);

      Console.WriteLine ("Input coordinates of your cell...");
      Console.Write ("Row = ");
      int r = int.Parse (Console.ReadLine ());
      Console.Write ("Column = ");
      int c = int.Parse (Console.ReadLine ());

      Console.WriteLine ("Longest path starting with Cell ({0}, {1})" +
         " has length of {2} cells.", r, c,
         this.MaxLengthOfPathsFromCell (ref maze, new Cell(r, c, 1)));

      Console.WriteLine ("Longest path has length of {0} cells.",
         this.MaxLengthOfPathsInMaze (ref maze));

   }

   public void Perm (ref int[] a, int index)
   {
      if (index == 0 && index < a.Length)
      {
         this.PrintLine (a);

         if (this.DisplayedLines++ % 20 == 19 && new Pause (true).IsOver)
         {
            a = new int[0];
         }
      }
      else
      {
         for (int i = 0; i < index && index < a.Length; i++)
         {
            int swap = a[index];
            a[index] = a[i];
            a[i] = swap;
            Perm (ref a, index - 1);
            a[i] = a[index];
            a[index] = swap;
         }
         Perm (ref a, index - 1);
      }
   }

   public struct DoubleKey
   {
      public int index;
      public uint sum;

      public DoubleKey (int index, uint sum)
      {
         this.index = index;
         this.sum = sum;
      }
   }

   public bool OptimizedSubsetSumsCount (
      ref uint[] a, ref System.Collections.Hashtable t, int index, uint sum)
   {
      if (index < 0)
         return false;
      if (a[index] == sum)
      {
         return true;
      }
      else
      {
         DoubleKey keyIfIn = new DoubleKey (index - 1, sum - a[index]),
            keyIfOut = new DoubleKey (index - 1, sum);
         bool valueIfIn, valueIfOut;

         if (t.ContainsKey (keyIfIn))
         {
            valueIfIn = (bool)t[keyIfIn];
            Console.WriteLine ("OK");
         }
         else
         {
            valueIfIn = this.OptimizedSubsetSumsCount (
               ref a, ref t, index - 1, sum - a[index]);
            t.Add (keyIfIn, valueIfIn);
         }
         if (valueIfIn) return true;

         if (t.ContainsKey (keyIfOut))
         {
            valueIfOut = (bool)t[keyIfOut];
         }
         else
         {
            valueIfOut = this.OptimizedSubsetSumsCount (
               ref a, ref t, index - 1, sum);
            t.Add (keyIfOut, valueIfOut);
         }
         if (valueIfOut) return true;

         return false;
      }
   }

   public int SubsetSumsCount (
      ref uint[] a, ref System.Collections.Hashtable t, int index, uint sum)
   {
      if (index < 0)
         return 0;

      int valueIfIn, valueIfOut, valueIfIs = 0;
      if (a[index] == sum)
      {
         valueIfIs = 1;
      }

      DoubleKey keyIfIn = new DoubleKey (index - 1, sum - a[index]),
         keyIfOut = new DoubleKey (index - 1, sum);


      if (t.ContainsKey (keyIfIn))
      {
         valueIfIn = (int)t[keyIfIn];
      }
      else
      {
         valueIfIn = this.SubsetSumsCount (
            ref a, ref t, index - 1, sum - a[index]);
         t.Add (keyIfIn, valueIfIn);
      }

      if (t.ContainsKey (keyIfOut))
      {
         valueIfOut = (int)t[keyIfOut];
      }
      else
      {
         valueIfOut = this.SubsetSumsCount (
            ref a, ref t, index - 1, sum);
         t.Add (keyIfOut, valueIfOut);
      }

      return valueIfIn + valueIfOut + valueIfIs;
   }

}

