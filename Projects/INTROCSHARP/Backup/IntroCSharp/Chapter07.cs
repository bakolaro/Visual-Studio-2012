using System;
using IntroCSharp;

class Chapter07: Menu
{
   public Chapter07 (): base ()
   {
      this.MenuTitle = "Chapter 7 - exercises.";

      this.Options = new MenuItem[] {
         new MenuItem (this.PrintMaxPlatform,
            " Print the submatrix with the greatest sum of" +
            " elements..."),
         new MenuItem (this.PrintPascalTriangle,
            " Print the Pascal's triangle..."),
         new MenuItem (this.PrintFirst20x5,
            " 1. Print an array of first 20 whole numbers," +
            " each times 5..."),
         new MenuItem (this.PrintCompareArrays,
            " 2. Read two arrays and see if they are equal..."),
         new MenuItem (this.PrintCharArraysInLexicOrder,
            " 3. Read two char arrays and check their lexic order..."),
         new MenuItem (this.PrintLongestSequenceOfEqualElements,
            " 4. Read an array and print its longest sequence of" +
            " equal elements..."),
         new MenuItem (this.PrintLongestSequenceOfGreaterElements,
            " 5. Read an array and print its longest sequence of" +
            " greater elements..."),
         new MenuItem (this.PrintLongestGappedSequenceOfGreaterElements,
            " 6. Read an array and print its longest GAPPED" +
            " sequence of greater elements..."),
         new MenuItem (this.PrintFixedLengthSequenceWithGreatestSum,
            " 7. Read an array and print one of the continuous" +
            " sequences with certain length and the greatest sum" +
            " of elements..."),
         new MenuItem (this.PrintSelectionSortIntegers,
            " 8. Read, sort (using the selection sort algorithm)" +
            " and print an array of integers..."),
         new MenuItem (this.PrintSequenceWithGreatestSum,
            " 9. Read an array and print one of the continuous" +
            " sequences with the greatest sum of elements..."),
         new MenuItem (this.PrintTheMostCommonValue,
            "10. Read an array and print one of the most common" +
            " values (the modes) of its elements..."),
         new MenuItem (this.PrintSequenceWithSumEqualToNumber,
            "11. Read an array and a number and print a sequence" +
            " with elements that have the same sum..."),
         new MenuItem (this.PrintSquareMatrices,
            "12. Print four square matrices, like this..."),
         new MenuItem (this.PrintGreatestSumSubmatrix3x3,
            "13. Read a m-by-n matrix and print a 3-by-3 submatrix" +
            " with the greatest sum of elements..."),
         new MenuItem (this.PrintLongestSequenceInStringMatrix,
            "14. Read a string matrix and print the longest" +
            " sequence of equal elements in a row, column or" +
            " diagonal..."),
         new MenuItem (this.PrintLetterIndexes,
            "15. Create an array of all latin letters, read a word" +
            " and print the indices of its letters ..."),
         new MenuItem (this.PrintBinarySearchSteps,
            "16. Create a sorted array of integers and perform a" +
            " binary search of a number..."),
         new MenuItem (this.PrintIntegersMergeSort,
            "17. Create and sort an array of integers with the" +
            "\"merge sort\" algorithm..."),
         new MenuItem (this.PrintIntegersQuickSort,
            "18. Create an array of random integers and sort it" +
            " with the \"quick sort\" algorithm..."),
         new MenuItem (this.PrintPrimeNumbers,
            "19. Print all prime numbers from 1 to 10,000,000..."),
         new MenuItem (this.PrintSubsequenceWithCertainSum,
            "20. Create an array of integers and look for a subset" +
            " of its elements with sum equal to a number..."),
         new MenuItem (this.PrintSubsequenceWithCertainSumAndSize,
            "21. Create an array of integers and look for a subset" +
            " of its elements with certain size and sum equal to" +
            " a number..."),
         new MenuItem (this.PrintLongestAscendingSubsequence,
            "22. Read an array of integers and print the longest" +
            " subsequence of ascending values..."),
         new MenuItem (this.PrintPermutations,
            "23. Print all permutations of the integers from 1 to" +
            " a number (less then 13)..."),
         new MenuItem (this.PrintVariations,
            "24. Print all variations of the first n integers with" +
            " k elements (1 <= k <= n)..."),
         new MenuItem (this.PrintCombinationss,
            "25. Print all combinations with k elements out of the" +
            " set of the first n integers (1 <= k <= n)..."),
         new MenuItem (this.PrintMatricesOfDiagonallyAlignedNumbers,
            "26. Print two square matrices of diagonally aligned" +
            " integers as follows:" + NL +
            " 1. start with SE and grow from SW to NE;" + NL +
            " 2. start with SW and grow from NW to SE..."),
         new MenuItem (this.PrintLargestAreaOfEqualNumbers,
            "27. Read a matrix of integers and print the size of" +
            " its largest area of equal numbers...")
      };
   }

   public void PrintMaxPlatform ()
   {
      Console.Write ("matrix rows = ");
      int m = int.Parse (Console.ReadLine ());
      Console.Write ("matrix columns = ");
      int n = int.Parse (Console.ReadLine ());

      Random rnd = new Random ();
      int[,] matrix = new int[m, n];
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            matrix[i, j] = rnd.Next () % 100;
         }
      }
      bool validInput = true;
      while (validInput)
      {
         Console.WriteLine ("Your matrix looks like this:");
         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++)
            {
               Console.Write ("{0,6}", matrix[i, j]);
            }
            Console.WriteLine ();
         }
         Console.WriteLine (
            "To change an element, type in 3 numbers,"
            + NL +
            "indicating its row, column and new value."
            + NL +
            "To go on without changes, type in some"
            + NL +
            "numbers out of range,...");

         int row, col, val;
         Console.Write ("row (0 to {0}) = ", n - 1);
         validInput = int.TryParse (
            Console.ReadLine (), out row);
         Console.Write ("column (0 to {0}) = ", m - 1);
         validInput = validInput && int.TryParse (
            Console.ReadLine (), out col);
         Console.Write ("value = ");
         validInput = validInput && int.TryParse (
            Console.ReadLine (), out val);
         validInput = validInput && (row < m) && (col < n) &&
            (0 <= row) && (0 <= col);

         if (validInput)
         {
            matrix[row, col] = val;
         }
      }

      Console.Write (NL
                     + "submatrix rows = ");
      int sm = int.Parse (Console.ReadLine ());
      Console.Write ("submatrix columns = ");
      int sn = int.Parse (Console.ReadLine ());

      int sMaxSum = int.MinValue, sMaxRow = 0, sMaxColumn = 0;
      for (int i = 0; i < m - sm + 1; i++)
      {
         for (int j = 0; j < n - sn + 1; j++)
         {
            int sum = 0;
            for (int p = i; p < i + sm; p++)
            {
               for (int q = j; q < j + sn; q++)
               {
                  sum += matrix[p, q];
               }
            }
            if (sum > sMaxSum)
            {
               sMaxSum = sum;
               sMaxRow = i;
               sMaxColumn = j;
            }
         }
      }
      if (sm < 1 || m < sm || sn < 1 || n < sn)
      {
         Console.WriteLine ("There is no such a submatrix!");
      }
      else
      {
         Console.WriteLine ("Your solution looks like this:");
         for (int i = sMaxRow; i < sMaxRow + sm; i++)
         {
            for (int j = sMaxColumn; j < sMaxColumn + sn; j++)
            {
               Console.Write ("{0,6}", matrix[i, j]);
            }
            Console.WriteLine ();
         }
         Console.WriteLine ("Sum = " + sMaxSum);
      }
   }

   public void PrintPascalTriangle ()
   {
      Console.Write ("rows = ");
      int n = int.Parse (Console.ReadLine ());

      int[][] triangle = new int[n][];
      for (int i = 0; i < n; i++)
      {
         triangle[i] = new int[i+1];
         triangle[i][0] = triangle[i][i] = 1;
         for (int j = 1; j < i; j++)
         {
            triangle[i][j]
               = triangle[i-1][j-1] + triangle[i-1][j];
         }
      }
      for (int i = 0; i < n; i++)
      {
         for (int k = 0; k < n - i - 1; k++)
         {
            Console.Write ("{0,3}", "");
         }
         for (int j = 0; j <= i; j++)
         {
            Console.Write ("{0,6}", triangle[i][j]);
         }
         for (int k = 0; k < n - i - 1; k++)
         {
            Console.Write ("{0,3}", "");
         }
         Console.WriteLine ();
      }
   }

   /* 1. Да се напише програма, която създава масив с 20
    * елемента от целочислен тип и инициализира всеки от
    * елементите със стойност равна на индекса на елемента
    * умножен по 5. Елементите на масива да се изведат на
    * конзолата.
    */

   public void PrintFirst20x5 ()
   {
      int[] arr = new int[20];
      for (int i = 0; i < arr.Length; i++)
      {
         arr[i] = i * 5;
      }
      for (int i = 0; i < arr.Length; i++)
      {
         Console.Write (" " + arr[i]);
      }
   }

   /* 2. Да се напише програма, която чете два масива от
    * конзолата и проверява дали са еднакви
    */

   public void PrintCompareArrays ()
   {
      Console.Write (NL +
         "Number of elements = ");
      int n = int.Parse (Console.ReadLine ());

      int[] a = new int[n], b = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("a[{0}] = ", i);
         a[i] = int.Parse (Console.ReadLine ());
         Console.Write ("b[{0}] = ", i);
         b[i] = int.Parse (Console.ReadLine ());
      }

      bool areEqual = true;
      for (int i = 0; i < n && areEqual; i++)
      {
         areEqual = (a[i] == b[i]);
      }

      Console.WriteLine ("The two arrays are{0}equal!",
         (areEqual ? " " : " NOT "));
   }

   /* 3. Да се напише програма, която сравнява два масива от
    * тип char лексикографски (буква по буква) и проверява кой
    * от двата е по-рано в лексикографската подредба.
    */

   public void PrintCharArraysInLexicOrder ()
   {
      Console.Write ("First array as string = ");
      string aStr = Console.ReadLine ();
      Console.Write ("Second array as string = ");
      string bStr = Console.ReadLine ();

      int minLength = Math.Min(aStr.Length, bStr.Length),
         indexOfDiff = -1;
      for (int i = 0; i < minLength && indexOfDiff < 0; i++)
      {
         if (!aStr[i].Equals(bStr[i]))
         {
            indexOfDiff = i;
         }
      }
      if (indexOfDiff < 0)
      {
         if (aStr.Length > bStr.Length)
         {
            Console.WriteLine ("{1} < {0}", aStr, bStr);
         }
         else if (aStr.Length < bStr.Length)
         {
            Console.WriteLine ("{0} < {1}", aStr, bStr);
         }
         else
         {
            Console.WriteLine ("{0} = {1}", aStr, bStr);
         }
      }
      else
      {
         if (aStr[indexOfDiff].CompareTo (bStr[indexOfDiff]) < 0)
         {
            Console.WriteLine ("{0} < {1}", aStr, bStr);
         }
         else
         {
            Console.WriteLine ("{1} < {0}", aStr, bStr);
         }
      }
   }

   /* 4. Напишете програма, която намира максимална редица от
    * последователни еднакви елементи в масив.
    * Пример: {2, 1, 1, 2, 3, 3, 2*, 2*, 2*, 1} ~> {2, 2, 2}.
    */

   public void PrintLongestSequenceOfEqualElements ()
   {
      Console.Write (NL +
                     "Number of elements = ");
      int n = int.Parse (Console.ReadLine ());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("arr[{0}] = ", i);
         arr[i] = int.Parse (Console.ReadLine ());
      }

      int count = 1, start = 0, maxCount = 1, maxStart = 0;
      for (int i = 1; i < n; i++)
      {
         if (arr[i] == arr[i-1])
         {
            count++;
            if (count > maxCount)
            {
               maxCount = count;
               maxStart = start;
            }
         }
         else
         {
            start = i;
            count = 1;
         }
      }

      for (int i = maxStart; i < maxStart + maxCount; i++)
      {
         Console.Write (" " + arr[i]);
      }
   }

   /* 5. Напишете програма, която намира максималната редица от
    * последователни нарастващи елементи в масив.
    * Пример: {3, 2*, 3*, 4*, 2, 2, 4} ~> {2, 3, 4}.
    */

   public void PrintLongestSequenceOfGreaterElements ()
   {
      Console.Write (NL +
                     "Number of elements = ");
      int n = int.Parse (Console.ReadLine ());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("arr[{0}] = ", i);
         arr[i] = int.Parse (Console.ReadLine ());
      }

      int count = 1, start = 0, maxCount = 1, maxStart = 0;
      for (int i = 1; i < n; i++)
      {
         if (arr[i] > arr[i-1])
         {
            count++;
            if (count > maxCount)
            {
               maxCount = count;
               maxStart = start;
            }
         }
         else
         {
            start = i;
            count = 1;
         }
      }

      for (int i = maxStart; i < maxStart + maxCount; i++)
      {
         Console.Write (" " + arr[i]);
      }
   }

   /* 6. Напишете програма, която намира максималната подредица
    * от нарастващи елементи в масив arr[n]. Елементите може и
    * да не са последователни.
    * Пример: {9, 6, 2*, 7, 4*, 7, 6*, 5, 8*, 4} ~> {2, 4, 6, 8}.
    */

   public static bool[] GetLongerValidOrFirstSequence (
                                    int[] x, bool[] a, bool[] b)
   {
      int aCnt, bCnt, aMax, bMax;
      aCnt = bCnt = 0;
      aMax = bMax = int.MinValue;
      for (int i = 0; i < x.Length; i++)
      {
         if (a[i])
         {
            if (x[i] > aMax)
            {
               aCnt++;
               aMax = x[i];
            }
            else
            {
               aCnt = 0;
               break;
            }
         }
      }
      for (int i = 0; i < x.Length; i++)
      {
         if (b[i])
         {
            if (x[i] > bMax)
            {
               bCnt++;
               bMax = x[i];
            }
            else
            {
               bCnt = 0;
               break;
            }
         }
      }
      return (aCnt < bCnt ?
              (bool[]) b.Clone () : (bool[]) a.Clone ());
   }

   public static bool[] MaxGappedSequence (int[] a, bool[] b,
                                               int start)
   {
      if (start < a.Length)
      {
         b[start] = false;
         bool[] ifFalse = MaxGappedSequence (
            a, b, start + 1);
         b[start] = true;
         bool[] ifTrue = MaxGappedSequence (
            a, b, start + 1);
         return GetLongerValidOrFirstSequence (
            a, ifTrue, ifFalse);
      }
      else
      {
         return GetLongerValidOrFirstSequence (a,
            new bool[b.Length], b);
      }
   }

   public void PrintLongestGappedSequenceOfGreaterElements ()
   {
      Console.Write (NL +
                     "Number of elements = ");
      int n = int.Parse (Console.ReadLine ());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("arr[{0}] = ", i);
         arr[i] = int.Parse (Console.ReadLine ());
      }

      bool[] solution = MaxGappedSequence (arr, new bool[n], 0);
      for (int i = 0; i < solution.Length; i++)
      {
         if (solution[i]) Console.Write (arr[i] + "; ");
      }
   }

   /* 7. Да се напише програма, която чете от конзолата две
    * цели числа N и K (K<N), и масив от N елемента. Да се
    * намерят тези K поредни елемента, които имат максимална
    * сума.
    */

   public void PrintFixedLengthSequenceWithGreatestSum ()
   {
      Console.Write (NL +
                     "Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("arr[{0}] = ", i);
         arr[i] = int.Parse (Console.ReadLine ());
      }

      int maxSum = int.MinValue, maxStart = 0;
      for (int i = 0; i < n - k + 1; i++)
      {
         int sum = 0;
         for (int j = 0; j < k; j++)
         {
            sum += arr[i + j];
         }
         if (sum > maxSum)
         {
            maxSum = sum;
            maxStart = i;
         }
      }

      for (int j = 0; j < k; j++)
      {
         Console.Write (arr[maxStart + j] + "; ");
      }
   }

   /* 8. Сортиране на масив означава да подредим елементите му
    * в нарастващ (намаляващ) ред. Напишете програма, която
    * сортира масив. Да се използва алгоритъма "Selection sort".
    */

   public void PrintSelectionSortIntegers ()
   {
      Console.Write (NL +
                     "Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("arr[{0}] = ", i);
         arr[i] = int.Parse (Console.ReadLine ());
      }

      for (int unsortedFirstIndex = 0;
           unsortedFirstIndex < n - 1; unsortedFirstIndex++)
      {
         int unsortedMaxValueIndex = unsortedFirstIndex,
            unsortedMaxValue = arr[unsortedMaxValueIndex];
         for (int j = unsortedFirstIndex; j < n; j++)
         {
            if (unsortedMaxValue < arr[j])
            {
               unsortedMaxValueIndex = j;
               unsortedMaxValue = arr[unsortedMaxValueIndex];
            }
         }
         int swap = arr[unsortedFirstIndex];
         arr[unsortedFirstIndex] = arr[unsortedMaxValueIndex];
         arr[unsortedMaxValueIndex] = swap;
      }

      for (int i = 0; i < n; i++)
      {
         Console.Write (arr[i] + "; ");
      }
   }

   /* 9. Напишете програма, която намира последователност от
    * числа, чиято сума е максимална.
    * Пример: {2, 3, -6, -1, 2*, -1*, 6*, 4*, -8, 8} ~> 11
    */

   public void PrintSequenceWithGreatestSum ()
   {
      Console.Write (NL +
                     "Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("arr[{0}] = ", i);
         arr[i] = int.Parse (Console.ReadLine ());
      }

      int maxSumStartIndex, maxSumEndIndex, maxSum;
      maxSumStartIndex = maxSumEndIndex = 0;
      maxSum = int.MinValue;

      for (int startIndex = 0; startIndex < n; startIndex++)
      {
         int sum = 0;
         for (int endIndex = startIndex; endIndex < n; endIndex++)
         {
            sum += arr[endIndex];
            if (maxSum < sum)
            {
               maxSumStartIndex = startIndex;
               maxSumEndIndex = endIndex;
               maxSum = sum;
            }
         }
      }

      for (int i = maxSumStartIndex; i <= maxSumEndIndex; i++)
      {
         Console.Write (arr[i] + "; ");
      }
   }

   /* 10. Напишете програма, която намира най-често срещания
    * елемент в масив.
    * Пример: {4*, 1, 1, 4*, 2, 3, 4*, 4*, 1, 2, 4*, 9, 3} ~> 4
    * (среща се 5 пъти).
    */

   public void PrintTheMostCommonValue ()
   {
      Console.Write (NL +
                     "Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      if (n > 0)
      {
         int[] arr = new int[n];
         for (int i = 0; i < n; i++)
         {
            Console.Write ("arr[{0}] = ", i);
            arr[i] = int.Parse (Console.ReadLine ());
         }

         int mode = arr[0], maxCount = 1;

         for (int i = 0; i < n; i++)
         {
            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
               if (arr[i] == arr[j])
               {
                  count++;
               }
            }
            if (maxCount < count)
            {
               maxCount = count;
               mode = arr[i];
            }
         }
   
         Console.WriteLine (mode);
      }
   }

   /* 11. Да се напише програма, която намира последователност
    * от числа в масив, които имат сума равна на число, въведено
    * от конзолата (ако има такава).
    * Пример: {4, 3, 1, 4*, 2*, 5*, 8}, S=11 ~> {4, 2, 5}.
    */

   public void PrintSequenceWithSumEqualToNumber ()
   {
      Console.Write (NL +
                     "Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      Console.Write (NL +
                     "Sum of elements, s = ");
      int s = int.Parse (Console.ReadLine ());

      if (n > 0)
      {
         int[] arr = new int[n];
         for (int i = 0; i < n; i++)
         {
            Console.Write ("arr[{0}] = ", i);
            arr[i] = int.Parse (Console.ReadLine ());
         }

         int sameSumStartIndex, sameSumEndIndex;
         sameSumStartIndex = sameSumEndIndex = 0;
         bool found = false;

         for (int startIndex = 0;
              startIndex < n && !found; startIndex++)
         {
            int sum = 0;
            for (int endIndex = startIndex;
                 endIndex < n && !found; endIndex++)
            {
               sum += arr[endIndex];
               if (sum == s)
               {
                  sameSumStartIndex = startIndex;
                  sameSumEndIndex = endIndex;
                  found = true;
               }
            }
         }
         if (found)
         {
            for (int i = sameSumStartIndex;
                 i <= sameSumEndIndex; i++)
            {
               Console.Write (arr[i] + "; ");
            }
            Console.WriteLine ();
         }
         else
         {
            Console.WriteLine ("There is no such a sequence!");
         }
      }
   }

   /* 12. Напишете програма, която създава следните квадратни
    * матрици и ги извежда на конзолата във форматиран вид.
    * Размерът на матриците се въвежда от конзолата.
    * Пример за (4,4):
    * a) 1 5  9 13  b) 1 8  9 16  c) 7 11 14 16  d)* 1 12 11 10
    *    2 6 10 14     2 7 10 15     4  8 12 15      2 13 16  9
    *    3 7 11 15     3 6 11 14     2  5  9 13      3 14 15  8
    *    4 8 12 16     4 5 12 13     1  3  6 10      4  5  6  7
    */

   public void PrintSquareMatrices ()
   {
      Console.Write (NL +
                     "Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      if (n > 0)
      {
         int[,] a, b, c, d;
         a = new int[n, n];
         b = new int[n, n];
         c = new int[n, n];
         d = new int[n, n];

         int row, col;
         for (int i = 0; i < n * n; i++)
         {
            row = i % n;
            col = i / n;
            a[row, col] = i + 1;
         }

         for (int i = 0; i < n * n; i++)
         {
            row = i % n;
            col = i / n;

            if (i / n % 2 > 0)
            {
               row = n - 1 - row;
            }
            b[row, col] = i + 1;
         }

         int intercept;
         col = 0;
         intercept = n - 1;
         row = col + intercept;

         for (int i = 0; i < n * n; i++)
         {
            c[row, col] = i + 1;

            row++;
            col++;
            if (row > n - 1 || col > n - 1)
            {
               col = 0;
               intercept--;
               row = col + intercept;
               if (row < 0)
               {
                  col -= row;
                  row = 0;
               }
            }
         }

         int stepRows, stepCols, maxRow, minRow, maxCol, minCol;
         row = col = 0;
         stepRows = 1;
         stepCols = 0;
         maxRow = maxCol = n - 1;
         minRow = minCol = 0;

         for (int i = 0; i < n * n; i++)
         {
            d[row, col] = i + 1;

            row += stepRows;
            col += stepCols;
            if (row > maxRow || col > maxCol ||
                row < minRow || col < minCol)
            {
               row -= stepRows;
               col -= stepCols;
               if (stepRows > 0)
               {
                  minCol++;
               }
               if (stepRows < 0)
               {
                  maxCol--;
               }
               if (stepCols > 0)
               {
                  maxRow--;
               }
               if (stepCols < 0)
               {
                  minRow++;
               }
               int swap = stepRows;
               stepRows = (stepRows != 0 ? 0 : -stepCols);
               stepCols = (stepCols != 0 ? 0 : swap);
               row += stepRows;
               col += stepCols;
            }
         }

         Console.WriteLine ("a");
         for(int i = 0; i < n; i++)
         {
            for(int j = 0; j < n; j++)
            {
               Console.Write ("{0, 4}", a[i, j]);
            }
            Console.WriteLine ();
         }
         Console.WriteLine ("b");
         for(int i = 0; i < n; i++)
         {
            for(int j = 0; j < n; j++)
            {
               Console.Write ("{0, 4}", b[i, j]);
            }
            Console.WriteLine ();
         }
         Console.WriteLine ("c");
         for(int i = 0; i < n; i++)
         {
            for(int j = 0; j < n; j++)
            {
               Console.Write ("{0, 4}", c[i, j]);
            }
            Console.WriteLine ();
         }
         Console.WriteLine ("d");
         for(int i = 0; i < n; i++)
         {
            for(int j = 0; j < n; j++)
            {
               Console.Write ("{0, 4}", d[i, j]);
            }
            Console.WriteLine ();
         }
      }
   }

   /* 13. Да се напише програма, която създава правоъгълна
    * матрица с размер n на m. Размерността и елементите на
    * матрицата да се четат от конзолата. Да се намери
    * подматрицата с размер (3,3), която има максимална сума.
    */

   public void PrintGreatestSumSubmatrix3x3 ()
   {
      Console.Write ("m = ");
      int m = int.Parse (Console.ReadLine ());
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (m > 2 && n > 2)
      {
         int[,] a = new int[m, n];

         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++)
            {
               Console.Write ("a[{0}, {1}] = ", i, j);
               a[i, j] = int.Parse (Console.ReadLine ());
            }
         }

         int bestRow = 0, bestCol = 0, max = int.MinValue;
         for (int i = 0; i < m - 2; i++)
         {
            for (int j = 0; j < m - 2; j++)
            {
               int sum = 0;
               for (int p = i; p < i + 3; p++)
               {
                  for (int q = j; q < j + 3; q++)
                  {
                     sum += a[p, q];
                  }
               }
               if (max < sum)
               {
                  max = sum;
                  bestRow = i;
                  bestCol = j;
               }
            }
         }

         Console.WriteLine ("Matrix");
         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++)
            {
               Console.Write ("{0,4}", a[i, j]);
            }
            Console.WriteLine ();
         }
         Console.WriteLine ("3-by-3 submatrix with geatest sum");
         for (int i = bestRow; i < bestRow + 3; i++)
         {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
               Console.Write ("{0,4}", a[i, j]);
            }
            Console.WriteLine ();
         }
      }
      else
      {
         Console.WriteLine (
            "Invalid data! Your matrix should have at least"
            + NL +
            "3 rows and 3 columns.");
      }
   }

   /* 14. Да се напише програма, която намира най-дългата
    * последователност от еднакви string елементи в матрица.
    * Последователност в матрица дефинираме като съседни
    * елементи, които са на същия ред, колона или диагонал.
    * Пример:
    * ha*  fifi ho   hi
    * fo   ha*  hi   xx   ~>  ha, ha, ha
    * xxx  ho   ha*  xx
    */

   public void PrintLongestSequenceInStringMatrix ()
   {
      Console.Write ("Rows, m = ");
      int m = int.Parse (Console.ReadLine ());
      Console.Write ("Columns, n = ");
      int n = int.Parse (Console.ReadLine ());

      if (m > 0 && n > 0)
      {
         string[,] a =new string[m, n];
         for (int i = 0 ; i < m; i++)
         {
            for (int j = 0 ; j < n; j++)
            {
               Console.Write ("a[{0}, {1}] = ", i, j);
               a[i, j] = Console.ReadLine ();

               Console.Clear ();
               Console.WriteLine ("Your matrix");
               for (int p = 0 ; p < m; p++)
               {
                  for (int q = 0 ; q < n; q++)
                  {
                     Console.Write ("{0,5}", a[p, q]);
                  }
                  Console.WriteLine ();
               }
               Console.WriteLine ();
            }
         }

         int longestStartRow = 0, longestStartColumn = 0,
            longestLength = 1;

         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++)
            {
               int k = 1;
               while (i + k < m && a[i + k, j].Equals (a[i, j]))
               {
                  k++;
               }
               if (longestLength < k)
               {
                  longestLength = k;
                  longestStartRow = i;
                  longestStartColumn = j;
               }
               k = 1;
               while (j + k < n
                      && a[i, j + k].Equals (a[i, j]))
               {
                  k++;
               }
               if (longestLength < k)
               {
                  longestLength = k;
                  longestStartRow = i;
                  longestStartColumn = j;
               }
               k = 1;
               while (i + k < n && j + k < n
                      && a[i + k, j + k].Equals (a[i, j]))
               {
                  k++;
               }
               if (longestLength < k)
               {
                  longestLength = k;
                  longestStartRow = i;
                  longestStartColumn = j;
               }
               k = 1;
               while (i - k >=0 && j + k < n
                      && a[i - k, j + k].Equals (a[i, j]))
               {
                  k++;
               }
               if (longestLength < k)
               {
                  longestLength = k;
                  longestStartRow = i;
                  longestStartColumn = j;
               }

            }
         }

         Console.WriteLine (
            "Longest sequence of equal elements = {0}",
            a[longestStartRow, longestStartColumn]);
      }
      else
      {
         Console.WriteLine (
            "Invalid data! Your matrix must have at least 1 row"
            + NL +
            "and 1 column.");
      }
   }

   /* 15. Да се напише програма, която създава масив с всички
    * букви от латинската азбука. Да се даде възможност на
    * потребител да въвежда дума от конзолата и в резултат да
    * се извеждат индексите на буквите от думата.
    */

   public void PrintLetterIndexes ()
   {
      int count = 52;
      char[] letters = new char[count];
      for (int i = 0; i < count / 2; i++)
      {
         letters[i] = (char)(i + 65);
      }
      for (int i = count / 2; i < count; i++)
      {
         letters[i] = (char)(i + 65 + 6);
      }

      Console.Write ("Your word = ");
      string word = Console.ReadLine ();

      int[] indices = new int[word.Length];
      for (int i = 0; i < word.Length; i++)
      {
         bool found = false;
         for (int j = 0; j < letters.Length; j++)
         {
            if (word[i].Equals (letters[j]))
            {
               indices[i] = j;
               found = true;
               break;
            }
         }
         if (!found)
         {
            indices[i] = -1;
         }
      }

      for (int i = 0; i < indices.Length; i++)
      {
         Console.Write (indices[i] +"; ");
      }
   }

   /* 16. Да се реализира двоично търсене (binary search) в
    * сортиран целочислен масив.
    */

   public void PrintBinarySearchSteps ()
   {
      int count = 20, maxStep = 10;
      int[] a = new int[count];
      Random rand = new Random ();
      a[0] = rand.Next () % maxStep;
      for (int i = 1; i < count; i++)
      {
         a[i] = a[i - 1] + rand.Next () % maxStep;
      }

      Console.WriteLine ("Your array: ");
      for (int i = 0; i < count; i++)
      {
         Console.Write (a[i] + "; ");
      }
      Console.WriteLine ();

      Console.Write ("Input a number to search for: ");
      int n = int.Parse (Console.ReadLine ());

      Console.Write ("Perform a binary search: ");

      int startIndex = 0, endIndex = count - 1,
         midIndex = (count - 1) / 2;
      bool isFound = false;

      do
      {
         Console.WriteLine ("Searching in [{0}, {1}]...",
                            a[startIndex], a[endIndex]);
         if (a[midIndex] < n)
         {
            startIndex = midIndex;
         }
         else if (n < a[midIndex])
         {
            endIndex = midIndex;
         }
         else
         {
            isFound = true;
            Console.WriteLine (
               "Your number is at {0}. position!", midIndex);
         }
         midIndex = startIndex + (endIndex - startIndex) / 2;
      }
      while (!isFound && startIndex + 1 < endIndex);

      if (!isFound)
      {
         Console.WriteLine ("Searching in [{0}, {1}]...",
                            a[startIndex], a[endIndex]);
         if (a[startIndex] == n)
         {
            isFound = true;
            Console.WriteLine (
               "Your number is at {0}. position!", startIndex);
         }
         else if (a[endIndex] == n)
         {
            isFound = true;
            Console.WriteLine (
               "Your number is at {0}. position!", endIndex);            }
         else
         {
            Console.WriteLine ("There is no such number!");
         }
      }
   }

   /* 17. Напишете програма, която сортира целочислен масив по
    * алгоритъма "merge sort".
    */

   public static int[] SortMergeIntegers (int[] x)
   {
      int n = x.Length;
      if (n > 1)
      {
         int[] a = new int[n / 2], b = new int[n - n / 2];
         for (int i = 0; i < n / 2; i++)
         {
            a[i] = x[i];
         }
         a = SortMergeIntegers (a);
         for (int i = 0; i < n - n / 2; i++)
         {
            b[i] = x[i + n / 2];
         }
         b = SortMergeIntegers (b);

         int[] c = new int[a.Length + b.Length];

         int p = 0, q = 0, r = 0;
         while (p < a.Length && q < b.Length)
         {
            if (a[p] < b[q])
            {
               c[r++] = a[p++];
            }
            else
            {
               c[r++] = b[q++];
            }
         }
         while (p < a.Length)
         {
            c[r++] = a[p++];
         }
         while (q < b.Length)
         {
            c[r++] = b[q++];
         }
         return c;
      }
      else
      {
         return x;
      }
   }

   public void PrintIntegersMergeSort ()
   {
      int n = 20, max = 100;
      int[] a = new int[n];
      Random rand = new Random ();

      Console.WriteLine (
         "Initialize the array with random integers...");
      for (int i = 0; i < n; i++)
      {
         a[i] = rand.Next () % max;
         Console.Write (a[i] + "; ");
      }
      Console.WriteLine ();
      Console.WriteLine ();

      a = SortMergeIntegers (a);
      for (int i = 0; i < n; i++)
      {
         Console.Write (a[i] + "; ");
      }
   }

   /* 18. Напишете програма, която сортира целочислен масив по
    * алгоритъма "quick sort".
    */

   public void PrintQuickSortStatus (int[] x,
      int startIndex, int a, int pivotIndex, int c, int endIndex)
   {
      string prefix, suffix;
      for (int i = 0; i < x.Length; i++)
      {
         prefix = string.Empty;
         suffix = string.Empty;
         if (i == startIndex)
         {
            prefix = "(";
         }
         if (i == endIndex)
         {
            suffix = ")";
         }
         if (i == a || i == pivotIndex || i == c)
         {
            suffix += "*";
         }

         Console.Write ("{0,1}{1,2}{2,-2}", prefix, x[i], suffix);
      }
      Console.WriteLine ();
   }

   public void SwapValuesAroundPivot (int[] x,
                                             int startIndex,
                                             int endIndex)
   {
      if (startIndex < endIndex)
      {
         int pivotIndex = startIndex + (endIndex - startIndex) / 2;

         int a = startIndex, b = pivotIndex, c = endIndex;
         while (a < c)
         {
            while (a < b && x[a] <= x[b])
            {
               a++;
               PrintQuickSortStatus (
                  x, startIndex, a, pivotIndex, c, endIndex);
            }
            while (b < c && x[b] <= x[c])
            {
               c--;
               PrintQuickSortStatus (
                  x, startIndex, a, pivotIndex, c, endIndex);
            }
            if (a < c)
            {
               int swap = x[a];
               x[a] = x[c];
               x[c] = swap;

               if (a == b)
               {
                  a = startIndex;
               }
               if (b == c)
               {
                  c = endIndex;
               }

               Console.WriteLine ("swap");
               PrintQuickSortStatus (
                  x, startIndex, a, pivotIndex, c, endIndex);
            }
         }

         SwapValuesAroundPivot (x, startIndex, pivotIndex - 1);
         SwapValuesAroundPivot (x, pivotIndex + 1, endIndex);
      }
   }

   public void PrintIntegersQuickSort ()
   {
      int n = 15, max = 90;
      int[] a = new int[n];
      Random rand = new Random ();
      for (int i = 0; i < n; i++)
      {
         a[i] = rand.Next () % max;
      }
      PrintQuickSortStatus (
         a, -1, -1, -1, -1, -1);

      SwapValuesAroundPivot (a, 0, n - 1);

      PrintQuickSortStatus (
         a, -1, -1, -1, -1, -1);
   }

   /* 19. Напишете програма, която намира всички прости числа в
    * диапазона [1...10 000 000].
    */

   public void PrintPrimeNumbers ()
   {
      int max = 10000000, count = 0;
      for (int i = 2; i <= max; i++)
      {
         bool isPrime = true;
         for (int j = 2; j <= Math.Sqrt (i); j++)
         {
            if (i % j == 0)
            {
               isPrime = false;
               break;
            }
         }
         if (isPrime)
         {
            count++;
            Console.Write ("{0,9}.{1,9}", count, i);
            if (count % 4 == 0)
            {
               Console.WriteLine ();
            }
            if (count % 80 == 0 && new Pause (true).IsOver)
            {
               break;
            }
         }
      }
   }

   /* 20. Напишете програма, която по дадени N числа и число S,
    * проверява дали може да се получи сума равна на S с
    * използване на подмасив от N-те числа (не непременно
    * последователни).
    * Пример: {2, 1*, 2*, 4, 3, 5*, 2, 6*}, S = 14 ~> yes
    * (1 + 2 + 5 + 6 = 14)
    */

   public static int[] GetSubsetWithSum (int[] a,
                                         bool[] filter,
                                         int index,
                                         int s)
   {
      if (index < a.Length)
      {
         filter[index] = true;
         int[] x = GetSubsetWithSum (a, filter, index + 1, s);

         if(x.Length > 0)
         {
            return x;
         }
         else
         {
            filter[index] = false;
            return GetSubsetWithSum (a, filter, index + 1, s);
         }
      }
      else
      {
         int sum = 0, count = 0;
         for (int i = 0; i < a.Length; i++)
         {
            if (filter[i])
            {
               sum += a[i];
               count++;
            }
         }

         int[] solution = new int[0];
         if (sum == s)
         {
            solution = new int[count];
            count = 0;
            for (int i = 0; i < a.Length; i++)
            {
               if (filter[i])
               {
                  solution[count++] = a[i];
               }
            }
         }
         return solution;
      }
   }

   public void PrintSubsequenceWithCertainSum ()
   {
      Console.Write ("Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      int[] a = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("a[{0}] = ", i);
         a[i] = int.Parse (Console.ReadLine ());
      }

      Console.WriteLine ("Your array:");
      for (int i = 0; i < n; i++)
      {
         Console.Write (a[i] + "; ");
      }
      Console.WriteLine ();

      Console.Write ("Sum of elements, s = ");
      int s = int.Parse (Console.ReadLine ());

      int[] solution = GetSubsetWithSum (a, new bool[a.Length], 0,
                                         s);

      Console.WriteLine ("Your solution:");
      for (int i = 0; i < solution.Length; i++)
      {
         Console.Write (solution[i] + "; ");
      }
   }

   /* 21. Напишете програма, която по дадени N, K и S, намира К
    * на брой елементи измежду N-те числа, чиито сума е точно S
    * или показва, че това е невъзможно.
    */

   public static int[] GetSubsetWithSumAndSize (int[] a,
                                         bool[] filter,
                                         int index,
                                         int s, int size)
   {
      if (index < a.Length)
      {
         filter[index] = true;
         int[] x = GetSubsetWithSumAndSize (a, filter, index + 1,
                                            s, size);

         if(x.Length > 0)
         {
            return x;
         }
         else
         {
            filter[index] = false;
            return GetSubsetWithSumAndSize (a, filter, index + 1,
                                            s, size);
         }
      }
      else
      {
         int sum = 0, count = 0;
         for (int i = 0; i < a.Length; i++)
         {
            if (filter[i])
            {
               sum += a[i];
               count++;
            }
         }

         int[] solution = new int[0];
         if (sum == s && count == size)
         {
            solution = new int[count];
            count = 0;
            for (int i = 0; i < a.Length; i++)
            {
               if (filter[i])
               {
                  solution[count++] = a[i];
               }
            }
         }
         return solution;
      }
   }

   public void PrintSubsequenceWithCertainSumAndSize ()
   {
      Console.Write ("Number of elements, n = ");
      int n = int.Parse (Console.ReadLine ());

      Console.Write ("Size of the subset, size = ");
      int size = int.Parse (Console.ReadLine ());

      int[] a = new int[n];
      for (int i = 0; i < n; i++)
      {
         Console.Write ("a[{0}] = ", i);
         a[i] = int.Parse (Console.ReadLine ());
      }

      Console.WriteLine ("Your array:");
      for (int i = 0; i < n; i++)
      {
         Console.Write (a[i] + "; ");
      }
      Console.WriteLine ();

      Console.Write ("Sum of elements, s = ");
      int s = int.Parse (Console.ReadLine ());

      int[] solution = GetSubsetWithSumAndSize (
         a, new bool[a.Length], 0, s, size);

      Console.WriteLine ("Your solution:");
      for (int i = 0; i < solution.Length; i++)
      {
         Console.Write (solution[i] + "; ");
      }
   }

   /* 22. Напишете програма, която прочита от конзолата масив
    * от цели числа и премахва минимален на брой числа, така че
    * останали числа да са сортирани в нарастващ ред.
    * Отпечатайте резултата. Пример:
    * {6, 1*, 4, 3*, 0, 3*, 6, 4*, 5*} ~> {1, 3, 3, 4, 5}
    */

   public void PrintLongestAscendingSubsequence ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (n > 0)
      {
         int[] a = new int[n];
         for (int i = 0; i < n; i++)
         {
            Console.Write ("a[{0}] = ", i);
            a[i] = int.Parse (Console.ReadLine ());
         }
         Console.WriteLine ("Your array:");
         for (int i = 0; i < n; i++)
         {
            Console.Write (a[i] + "; ");
         }
         Console.WriteLine ();

         int m = (1 << n);
         int[,] subsets = new int[m, n];

         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++)
            {
               subsets[i, j] = i / (m / 2 / (1 << j)) % 2;
            }
         }

         int bestSubset = 0, bestLength = 0;
         for (int i = 0; i < m; i++)
         {
            int max = int.MinValue, count = 0;
            for (int j = 0; j < n; j++)
            {
               if (subsets[i, j] > 0)
               {
                  if (a[j] >= max)
                  {
                     count++;
                     max = a[j];
                  }
                  else
                  {
                     count = 0;
                     break;
                  }
               }
            }
            if (bestLength < count)
            {
               bestLength = count;
               bestSubset = i;
            }
         }

         Console.WriteLine ("Your solution:");
         for (int i = 0; i < n; i++)
         {
            if(subsets[bestSubset, i] > 0)
            {
               Console.Write (a[i] + "; ");
            }
         }
         Console.WriteLine ();

      }
      else
      {
         Console.WriteLine ("Invalid data! Let n > 0.");
      }
   }

   /* 23. Напишете програма, която прочита цяло число N от
    * конзолата и отпечатва всички пермутации на числата
    * [1...N]. Пример: N = 3 ~> {1, 2, 3}, {1, 3, 2}, {2, 1, 3},
    * {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
    */

   public void PrintPermutations ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      if (n > 0 && n < 13)
      {
         int count = 1;
         for (int i = 1; i <= n; i++)
         {
            count *= i;
         }

         Console.WriteLine (
            "Numbers from 1 to {0} have {1} permutations.",
            n, count);

         int[] a = new int[n];
         for (int i = 0; i < count; i++)
         {
            bool[] integers = new bool[n];
            int p = count, q = n;
            for (int j = 0; j < n; j++)
            {
               p /= q--;
               int cnt = (i / p) % (n - j) + 1;

               int k = 0;
               while (k < n && cnt > 0)
               {
                  if (!integers[k])
                     cnt--;
                  k++;
               }
               integers[k - 1] = true;
               a[j] = k;

               Console.Write ("{0, 4}", a[j]);
            }
            Console.WriteLine ();
            if (i % 20 == 19 && new Pause (true).IsOver)
            {
               break;
            }
         }
      }
      else
      {
         Console.WriteLine ("Invalid data! Let n > 0 and n < 13.");
      }
   }

   /* 24. Напишете програма, която прочита цели числа N и K от
    * конзолата и отпечатва всички вариации от К елемента на
    * числата [1...N]. Пример: N = 3, K = 2 ~> {1, 1}, {1, 2},
    * {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
    */

   public void PrintVariations ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      if (1 <= k && k <= n)
      {
         int variations = 1;
         for (int i = n; i > n - k; i--)
         {
            variations *= i;
         }
         Console.WriteLine ("Variations = " + variations);

         for (int i = 0; i < variations; i++)
         {
            // isNotAvailable is false i.e. isAvailable
            bool[] isNotAvailable = new bool[n];

            int numberOfAvailElems = n;
            int variationsOfAvailElems = variations;

            for (int j = 0; j < k; j++)
            {
               numberOfAvailElems--;

               // size of lots (number of consequtive rows with
               // the same elements in columns from 0 to j),
               // i.e. the number of variations of the available
               // elements
               if (numberOfAvailElems + 1 > 0)
               {
                  variationsOfAvailElems /= (numberOfAvailElems + 1);
               }
               else
               {
                  variationsOfAvailElems = 1;
               }

               // lot identifier, i.e. the number of full lots
               // which lie before the current row
               int lotId = i / variationsOfAvailElems;

               int indexInListOfAvailElems =
                  lotId % (numberOfAvailElems + 1);

               int x = 0;
               int counterOfAvailElems =
                  indexInListOfAvailElems + 1;
               while (x < n && counterOfAvailElems > 0)
               {
                  if (!isNotAvailable[x])
                  {
                     counterOfAvailElems--;
                  }
                  x++;
               }
               isNotAvailable[x - 1] = true;

               Console.Write ("{0,3}", x);
            }
            Console.WriteLine ();
         }

      }
      else
      {
         Console.WriteLine (
            "Invalid data! Let 1 <= k <= n.");
      }
   }

   /* 25. Напишете програма, която прочита цяло число N от
    * конзолата и отпечатва всички комбинации от К елемента на
    * числата [1...N]. Пример: N = 5, K = 2 ~> {1, 2}, {1, 3},
    * {1, 4}, {1, 5}, {2, 1}, {2, 3}, {2, 4}, {2, 5}, {3, 1},
    * {3, 4}, {3, 5}, {4, 5}
    */

   public void PrintCombinations (int[] selected,
                                        int[] available,
                                        int k)
   {
      if (k == 0)
      {
         for (int j = 0; j < selected.Length; j++)
         {
            Console.Write ("{0,3}", selected[j]);
         }
         Console.WriteLine ();
      }
      else if (available.Length == k)
      {
         for (int j = 0; j < selected.Length; j++)
         {
            Console.Write ("{0,3}", selected[j]);
         }
         for (int j = 0; j < available.Length; j++)
         {
            Console.Write ("{0,3}", available[j]);
         }
         Console.WriteLine ();
      }
      else if (available.Length > k)
      {
         int[] newSelected = new int[selected.Length + 1];
         int[] newAvailable = new int[available.Length - 1];
         for (int j = 0; j < selected.Length; j++)
         {
            newSelected[j] = selected[j];
         }
         newSelected[selected.Length] = available[0];
         for (int j = 1; j < available.Length; j++)
         {
            newAvailable[j - 1] = available[j];
         }
         PrintCombinations (newSelected, newAvailable, k - 1);

         PrintCombinations (selected, newAvailable, k);
      }
      else
      {
         Console.WriteLine ("Error!");
      }
   }

   public void PrintCombinationss ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());
      Console.Write ("k = ");
      int k = int.Parse (Console.ReadLine ());

      if (1 <= k && k <= n)
      {
         int variations = 1;
         for (int i = n; i > n - k; i--)
         {
            variations *= i;
         }
         Console.WriteLine ("Variations = " + variations);
         int combinations = variations;
         for (int i = k; i > 0; i--)
         {
            combinations /= i;
         }
         Console.WriteLine ("Combinations = " + combinations);

         int[] availableElements = new int[n];
         for (int i = 0; i < n; i++)
         {
            availableElements[i] = i + 1;
         }

         PrintCombinations (new int[0], availableElements, k);
      }
      else
      {
         Console.WriteLine (
            "Invalid data! Let 1 <= k <= n.");
      }
   }

   /* 26. Напишете програма, която обхожда матрица (NxN) по
    * следния начин: Пример за N=4:
    * 16 15 13 10     7 11 14 16
    * 14 12  9  6     4  8 12 15
    * 11  8  5  3     2  5  9 13
    *  7  4  2  1     1  3  6 10
   */

   public void PrintMatricesOfDiagonallyAlignedNumbers ()
   {
      Console.Write ("n = ");
      int n = int.Parse (Console.ReadLine ());

      Console.WriteLine ("1. Using formulas...");

      for (int i = 0; i < n; i++)
      {
         for (int j = 0; j < n; j++)
         {
            int d = i + j, val = 0, count = 0;
            if (d < n)
            {
               for (int k = 1; k <= d; k++)
               {
                  count += k;
               }
               val = n * n - (count + d - j);
            }
            else
            {
               for (int k = 1; k <= 2 * n - d - 2; k++)
               {
                  count += k;
               }
               val = count + j - d + n;
            }
            Console.Write ("{0,4}", val);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      for (int i = 0; i < n; i++)
      {
         for (int j = 0; j < n; j++)
         {
            int d = i - j, val = 0, count = 0;
            if (d < 0)
            {
               for (int k = 1; k <= n; k++)
               {
                  count += k;
               }
               for (int k = -1; k >= d + 1; k--)
               {
                  count += (n + k);
               }
               val = i + 1 + count;
            }
            else
            {
               for (int k = 1; k <= n - d - 1; k++)
               {
                  count += k;
               }
               val = count + j + 1;
            }
            Console.Write ("{0,4}", val);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      Console.WriteLine ("2. Using a n-by-n matrix...");

      int[,] solution = new int[n, n];

      int row = n - 1, col = n - 1;
      solution[row, col] = 1;

      for (int k = 1; k < n * n; k++)
      {
         row--; col++;

         if (row < 0 || col > n - 1)
         {
            col = row + col - n;
            row = n - 1;
            if (col < 0)
            {
               row += col;
               col -= col;
            }
         }
         solution[row, col] = k + 1;
      }

      for (row = 0; row < n; row++)
      {
         for (col = 0; col < n; col++)
         {
            Console.Write ("{0,4}", solution[row, col]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      row = n - 1;
      col = 0;
      solution[row, col] = 1;

      for (int k = 1; k < n * n; k++)
      {
         row++; col++;

         if (row > n - 1 || col > n - 1)
         {
            row -= (col + 1);
            col -= col;
            if (row < 0)
            {
               col -= row;
               row -= row;
            }
         }
         solution[row, col] = k + 1;
      }

      for (row = 0; row < n; row++)
      {
         for (col = 0; col < n; col++)
         {
            Console.Write ("{0,4}", solution[row, col]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      Console.WriteLine ("3. Using a jagged array...");

      int[][] jag = new int[2 * n - 1][];

      for (int i = 0; i < n; i++)
      {
         jag[i] = new int[i + 1];
         jag[2 * n - 2 - i] = new int[i + 1];
      }
      int diagonal = 0, element = 0;
      for (int i = 0; i < n * n; i++)
      {
         jag[diagonal][element++] = i + 1;
         if (element > jag[diagonal].Length - 1)
         {
            element = 0;
            diagonal++;
         }
      }

      for (int i = 0; i < jag.Length; i++)
      {
         for (int j = 0; j < jag[i].Length; j++)
         {
            Console.Write ("{0,4}", jag[i][j]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      for (int i = 0; i < n; i++)
      {
         diagonal = 2 * n - 2 - i;
         element = 0;
         for (int j = 0; j < n; j++)
         {
            solution[i, j] = jag[diagonal][element];
            diagonal--;
            if (diagonal >= n - 1)
            {
               element++;
            }
         }
      }

      for (row = 0; row < n; row++)
      {
         for (col = 0; col < n; col++)
         {
            Console.Write ("{0,4}", solution[row, col]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      for (int i = 0; i < n; i++)
      {
         diagonal = n - 1 - i;
         element = 0;
         for (int j = 0; j < n; j++)
         {
            solution[i, j] = jag[diagonal][element];
            diagonal++;
            if (diagonal <= n - 1)
            {
               element++;
            }
         }
      }

      for (row = 0; row < n; row++)
      {
         for (col = 0; col < n; col++)
         {
            Console.Write ("{0,4}", solution[row, col]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();
   }

   /* 27. *Напишете програма, която по подадена матрица намира
    * най-голямата област от еднакви числа. Под област разбираме
    * съвкупност от съседни (по ред и колона) елементи. Ето един
    * пример, в който имаме област, съставена от 13 на брой
    * еднакви елементи със стойност 3:
    * 1 3 2 2 2 4
    * 3 3 3 2 4 4
    * 4 3 1 2 3 3  --> 13
    * 4 3 1 3 3 1
    * 4 3 3 3 1 1
    */

   public static int GetSizeOfArea (int[,] a, int i, int j,
                                    bool[,] visited)
   {
      int up, down, left, right;
      up = down = left = right = 0;

      visited[i, j] = true;

      if (i > 0
          && !visited[i - 1, j] && a[i, j] == a[i - 1, j])
      {
         up = GetSizeOfArea (a, i - 1, j, visited);
      }
      if (i + 1 < a.GetLength (0)
          && !visited[i + 1, j] && a[i, j] == a[i + 1, j])
      {
         down = GetSizeOfArea (a, i + 1, j, visited);
      }
      if (j > 0
          && !visited[i, j - 1] && a[i, j] == a[i, j - 1])
      {
         left = GetSizeOfArea (a, i, j - 1, visited);
      }
      if (j + 1 < a.GetLength (1)
          && !visited[i, j + 1] && a[i, j] == a[i, j + 1])
      {
         right = GetSizeOfArea (a, i, j + 1, visited);
      }

      return 1 + up + down + left + right;
   }

   public void PrintLargestAreaOfEqualNumbers ()
   {
      Console.Write ("Number of rows, m = ");
      int m = int.Parse (Console.ReadLine ());
      Console.Write ("Number of columns, n = ");
      int n = int.Parse (Console.ReadLine ());

      int[,] a = new int[m, n];

      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            Console.Write ("a[{0}, {1}] = ", i, j);
            a[i, j] = int.Parse (Console.ReadLine ());
         }
      }

      Console.WriteLine ("Your matrix is as follows:");
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            Console.Write ("{0, 4}", a[i, j]);
         }
         Console.WriteLine ();
      }
      Console.WriteLine ();

      bool[,] visited = new bool[m, n];
      int maxSize = 1, val = a[0, 0], size = 1;
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            if (!visited[i, j])
            {
               size = GetSizeOfArea (a, i, j, visited);
               if (size > maxSize)
               {
                  maxSize = size;
                  val = a[i, j];
               }
            }
         }
      }

      Console.WriteLine ("Value: {0}, size: {1}.", val, maxSize);
   }
}