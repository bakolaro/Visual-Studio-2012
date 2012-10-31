using System;


class Chapter05
{
   /* 1. Да се напише if-конструкция, която проверява стойността
    * на две целочислени променливи и разменя техните стойности,
    * ако стойността на първата променлива е по-голяма от
    * втората.
    */
   public static void SortTwoIntegers ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Sort two integers...");
      int a, b;
      
      Console.Write ("a = ");
      a = int.Parse (Console.ReadLine());
      Console.Write ("b = ");
      b = int.Parse (Console.ReadLine());
      if (a > b)
      {
         int c = a;
         a = b;
         b = c;
      }
      Console.WriteLine ("{0} < {1}", a, b);
      
      if (Again()) SortTwoIntegers ();
   }
   
   /* 2. Напишете програма, която показва знака (+ или -) от
    * произведението на три реални числа, без да го пресмята.
    * Използвайте последователност от if оператори.
    */
   public static void WriteProductSign ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "What sign the product of 3 " +
                         "real numbers has?...");
      double x, y, z;
      
      Console.Write ("x = ");
      x = double.Parse (Console.ReadLine());
      Console.Write ("y = ");
      y = double.Parse (Console.ReadLine());
      Console.Write ("z = ");
      z = double.Parse (Console.ReadLine());
      
      if (x < 0 && y < 0 && z < 0)
      {
         Console.WriteLine ("-");
      }
      else if (x < 0 && y < 0 && z > 0)
      {
         Console.WriteLine ("+");
      }
      else if (x < 0 && y > 0 && z < 0)
      {
         Console.WriteLine ("+");
      }
      else if (x < 0 && y > 0 && z > 0)
      {
         Console.WriteLine ("-");
      }
      else if (x > 0 && y < 0 && z < 0)
      {
         Console.WriteLine ("+");
      }
      else if (x > 0 && y < 0 && z > 0)
      {
         Console.WriteLine ("-");
      }
      else if (x > 0 && y > 0 && z < 0)
      {
         Console.WriteLine ("-");
      }
      else
      {
         Console.WriteLine ("+");
      }
      
      if (Again()) WriteProductSign ();
   }
   
   /* 3. Напишете програма, която намира най-голямото по
    * стойност число, измежду три дадени числа.
    */
   public static void LargestNumber ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Largest of 3 numbers...");
      double x, y, z;
      
      Console.Write ("x = ");
      x = double.Parse (Console.ReadLine());
      Console.Write ("y = ");
      y = double.Parse (Console.ReadLine());
      Console.Write ("z = ");
      z = double.Parse (Console.ReadLine());
      
      if (x < y)
      {
         if (y < z)
         {
            Console.WriteLine (z);
         }
         else
         {
            Console.WriteLine (y);
         }
      }
      else if (x > z)
      {
         Console.WriteLine (x);
      }
      else
      {
         Console.WriteLine (z);
      }
      
      if (Again()) LargestNumber ();
   }
   
   /* 4. Сортирайте 3 реални числа в намаляващ ред. Използвайте
    * вложени if оператори.
    */
   public static void SortNumbers ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Sort 3 numbers in descending order...");
      double x, y, z;
      
      Console.Write ("x = ");
      x = double.Parse (Console.ReadLine());
      Console.Write ("y = ");
      y = double.Parse (Console.ReadLine());
      Console.Write ("z = ");
      z = double.Parse (Console.ReadLine());
      
      if (x > y)
      {
         if (y > z)
         {
            Console.WriteLine ("{0} > {1} > {2}", x, y, z);
         }
         else if (x > z)
         {
            Console.WriteLine ("{0} > {1} > {2}", x, z, y);
         }
         else
         {
            Console.WriteLine ("{0} > {1} > {2}", z, x, y);
         }
      }
      else
      {
         if (y > z)
         {
            if (z > x)
            {
               Console.WriteLine ("{0} > {1} > {2}", y, z, x);
            }
            else
            {
               Console.WriteLine ("{0} > {1} > {2}", y, x, z);
            }
         }
         else
         {
               Console.WriteLine ("{0} > {1} > {2}", z, y, x);
         }
      }
      
      if (Again()) SortNumbers ();
   }
   
   /* 5. Напишете програма, която за дадена цифра (0-9),
    * зададена като вход, извежда името на цифрата на български
    * език.
    */
   public static void SpellDigitsInBulgarian ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Spell a digit in Bulgarian...");
      string spel;
      char ch = Console.ReadKey ().KeyChar;
      
      switch (ch)
      {
         case '0': spel = "нула"; break;
         case '1': spel = "едно"; break;
         case '2': spel = "две"; break;
         case '3': spel = "три"; break;
         case '4': spel = "четири"; break;
         case '5': spel = "пет"; break;
         case '6': spel = "шест"; break;
         case '7': spel = "седем"; break;
         case '8': spel = "осем"; break;
         case '9': spel = "девет"; break;
         default: spel = "не е цифра"; break;
      }
         
      Console.WriteLine (" = " + spel);
         
      if (Again()) SpellDigitsInBulgarian ();
   }
   
   /* 6. Напишете програма, която при въвеждане на 
    * коефициентите (a, b и c) на квадратно уравнение: ax2+bx+c,
    * изчислява и извежда неговите реални корени (ако има 
    * такива). Квадратните уравнения могат да имат 0, 1 или 2
    * реални корена.
    */
   public static void SolveQudraticEquation ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Solve a quadratic equation...");
      double a, b, c, d;
      
      Console.Write ("a = ");
      a = double.Parse (Console.ReadLine ());
      Console.Write ("b = ");
      b = double.Parse (Console.ReadLine ());
      Console.Write ("c = ");
      c = double.Parse (Console.ReadLine ());
      
      d = b * b - 4 * a * c;
      if (d < 0)
      {
         Console.WriteLine ("The equation has no real solutions.");
      }
      else if (d == 0)
      {
         Console.WriteLine ("x = {0:d5}", - b / 2 * a);
      }
      else
      {
         double x1, x2;
         x1 = (- b - Math.Sqrt(d)) / (2 * a);
         x2 = (- b + Math.Sqrt(d)) / (2 * a);
         Console.WriteLine ("x1 = {0:f5}, x2 = {1:f5}", x1, x2);
         string A = Formatted (a, false);
         string B = Formatted (b, true);
         string C = Formatted (c, true);
         string X1 = Formatted (x1, false);
         string X2 = Formatted (x2, false);
         Console.WriteLine ("Test solutions..."
             + Environment.NewLine
             + "{0}*({3})^2{1}*({3}){2} ?= {5:f5}"
             + Environment.NewLine
             + "{0}*({4})^2{1}*({4}){2} ?= {6:f5}",
             A, B, C, X1, X2,
             a * x1 * x1 + b * x1 + c,
             a * x2 * x2 + b * x2 + c);
      }
      
      if (Again()) SolveQudraticEquation ();
   }
   
   /* 7. Напишете програма, която намира най-голямото по 
    * стойност число измежду дадени 5 числа.
    */
   public static void LargestOfFive ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Largest of five numbers...");
      double x, max = 0;
      
      for (int i = 0; i < 5; i++)
      {
         Console.Write ("x = ");
         x = double.Parse (Console.ReadLine ());
         
         if (i == 0 || x > max) max = x;
      }
      Console.WriteLine ("The largest number is {0:f5}", max);
      
      if (Again()) LargestOfFive ();
   }

   /* 8. Напишете програма, която по избор на потребителя
    * прочита от конзолата променлива от тип int, double или
    * string. Ако променливата е int или double, трябва да се
    * увеличи с 1. Ако променливата е string, трябва да се 
    * прибави накрая символа "*". Отпечатайте получения
    * резултат на конзолата. Използвайте switch конструкция.
    */
   public static void ChoseType ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Input variables of different types...");
      int n;
      double x;
      string str;
      char choice;
      
      Console.WriteLine ("Choose:"
                         + Environment.NewLine
                         + "\t'0' --> integer"
                         + Environment.NewLine
                         + "\t'1' --> double"
                         + Environment.NewLine
                         + "\t'2' --> string");
      choice = Console.ReadKey ().KeyChar;
      switch (choice)
      {
         case '0':
            Console.WriteLine (" (integer)");
            Console.Write ("integer = ");
            n = int.Parse (Console.ReadLine ());
            Console.WriteLine ("n + 1 = {0}", ++n);
            break;
         case '1':
            Console.WriteLine (" (double)");
            Console.Write ("double = ");
            x = double.Parse (Console.ReadLine ());
            Console.WriteLine ("x + 1 = {0:f5}", ++x);
            break;
         case '2':
            Console.WriteLine (" (string)");
            Console.Write ("string = ");
            str = Console.ReadLine ();
            Console.WriteLine (str + "*");
            break;
         default: 
            Console.WriteLine (" (invalid choice)");
            break;
      }
      
      if (Again()) ChoseType ();
   }
   
   /* 9. Дадени са пет цели числа. Напишете програма, която 
    * намира онези подмножества от тях, които имат сума 0.
    * Примери:
    * - Ако са дадени числата {3, -2, 1, 1, 8}, сумата на -2, 1
    * и 1 е 0.
    * - Ако са дадени числата {3, 1, -7, 35, 22}, няма
    * подмножества със сума 0.
    */
   public static void SubSets ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Find zero-sum subsets of 5 integers...");
      int[] x = new int[5];
      
      for (int i = 0; i < 5; i++)
      {
         Console.Write ("x[{0}] = ", i);
         x[i] = int.Parse (Console.ReadLine ());
      }            
      
      for (int i = 0; i < 5; i++)
      {
         Console.WriteLine ("x[{0}] = {1}", i, x[i]);
      }
      
      Console.WriteLine ("Array length = {0}",
                         x.Length);
      Console.WriteLine ("Not empty subsets = {0}",
                         Subsets (x.Length));
      Console.WriteLine ("Zero-sum subsets = {0}",
         WriteLineOnlyZeroSubsets (x, 0, 0, 0, ""));
         
      if (Again()) SubSets ();
   }
   
   public static int Factorial (int n)
   {
      if (n == 0)
      {
         return 1;
      }
      else
      {
         return n * Factorial (n - 1);
      }
   }
      
   public static int Combinations (int n, int k)
   {
      return Factorial (n) / Factorial (n - k) / Factorial (k);
   }
   
   public static int Subsets (int n)
   {
      int cnt = 0;
      
      for (int k = 1; k <= n; k++)
      {
         cnt += Combinations (n, k);
      }
      
      return cnt;
   }

   public static int WriteLineOnlyZeroSubsets (int[] arr,
                                       int pos, int sum,
                                       int count, string str)
   {
      if (pos < arr.Length)
      {
         if (pos + 1 < arr.Length)
         {
            return WriteLineOnlyZeroSubsets (arr, pos + 1,
                                      sum, count,
                                      str)
            + WriteLineOnlyZeroSubsets (arr, pos + 1, 
                       sum + arr[pos], count + 1,
                       str + string.Format("arr[{0}] = {1}\t",
                       pos, arr[pos]));
         }
         else
         {
            int cnt = 0;
            if (count > 0 && sum == 0)
            {
               Console.WriteLine (str);
               cnt++;
            }
            if (count + 1 > 0 && sum + arr[pos] == 0)
            {
               Console.WriteLine (str
                               + string.Format("arr[{0}] = {1}\t",
                               pos, arr[pos]));
               cnt++;
            }
            return cnt;
         }
      }
      else
      {
         return 0;
      }
   }
   
   /* 10. Напишете програма, която прилага бонус точки към
    * дадени точки в интервала [1..9] чрез прилагане на 
    * следните правила:
    * - Ако точките са между 1 и 3, програмата ги умножава
    * по 10.
    * - Ако точките са между 4 и 6, ги умножава по 100.
    * - Ако точките са между 7 и 9, ги умножава по 1000.
    * - Ако точките са 0 или повече от 9, се отпечатва
    * съобщение за грешка.
    */
   public static void BonusPoints ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Apply rules concerning bonus points...");
      byte points;
      int total;
      
      Console.Write ("Points (1 to 9) = ");
      points = byte.Parse (Console.ReadLine ());
      
      switch (points)
      {
         case 1:
         case 2:
         case 3:
            total = points * 10; break;
         case 4:
         case 5:
         case 6:
            total = points * 100; break;
         case 7:
         case 8:
         case 9:
            total = points * 1000; break;
         default:
            total = 0; break;
      }
      if (total > 0)
      {
         Console.WriteLine ("Total = {0}", total);
      }
      else
      {
         Console.WriteLine ("Invalid number of points ({0})",
                            points);
      }
      
      if (Again()) BonusPoints ();
   }
   
   /* 11. * Напишете програма, която преобразува дадено число в
    * интервала [0..999] в текст, съответстващ на българското
    * произношение на числото. Примери:
    * - 0 → "Нула"
    * - 12 → "Дванадесет"
    * - 98 → "Деветдесет и осем"
    * - 273 → "Двеста седемдесет и три"
    * - 400 → "Четиристотин"
    * - 501 → "Петстотин и едно"
    * - 711 → "Седемстотин и единадесет"
    */
   public static void SpellNumbersInBulgarian ()
   {
      Console.WriteLine (Environment.NewLine + 
                         "Spell numbers in Bulgarian...");
      
      Console.Write ("From [1..999] = ");
      int nFrom = int.Parse (Console.ReadLine ());
      Console.Write ("To [1..999] = ");
      int nTo = int.Parse (Console.ReadLine ());

      for (int i = nFrom; i < nTo + 1; i++)
      {
         SpellNumberInBulgarian (i);
      }
      
      if (Again()) SpellNumbersInBulgarian ();
   }

   public static void SpellNumberInBulgarian (int n)
   {
      int ones = n % 10;
      int tens = n / 10 % 10;
      int hundreds = n / 100 % 10;
      string s = "";

      switch (hundreds)
      {
         case 1: s = "сто"; break;
         case 2: s = "двеста"; break;
         case 3: s = "триста"; break;
         case 4: s = "четиристотин"; break;
         case 5: s = "петстотин"; break;
         case 6: s = "шестотин"; break;
         case 7: s = "седемстотин"; break;
         case 8: s = "осемстотин"; break;
         case 9: s = "деветстотин"; break;
      }
      if (hundreds > 0 && (tens == 1 
         || tens > 1 && ones == 0 || tens == 0 && ones >0))
      {
         s += " и ";
      }
      else if (hundreds > 0 && tens + ones > 0)
      {
         s += " ";
      }
      switch (tens)
      {
         case 1: 
         switch (ones)
         {
            case 0: s += "десет"; break;
            case 1: s += "единадесет"; break;
            case 2: s += "дванадесет"; break;
            case 3: s += "тринадесет"; break;
            case 4: s += "четиринадесет"; break;
            case 5: s += "петнадесет"; break;
            case 6: s += "шестнадесет"; break;
            case 7: s += "седемнадесет"; break;
            case 8: s += "осемнадесет"; break;
            case 9: s += "деветнадесет"; break;
         }
         break;
         case 2: s += "двадесет"; break;
         case 3: s += "тридесет"; break;
         case 4: s += "четиридесет"; break;
         case 5: s += "петдесет"; break;
         case 6: s += "шестдесет"; break;
         case 7: s += "седемдесет"; break;
         case 8: s += "осемдесет"; break;
         case 9: s += "деветдесет"; break;
      }
      if (tens > 1 && ones > 0)
      {
         s += " и ";
      }
      if (tens != 1)
      {
         switch (ones)
         {
            case 0: if (hundreds == 0 && tens == 0)
            {
               s = "нула";
            }
            break;
            case 1: s += "едно"; break;
            case 2: s += "две"; break;
            case 3: s += "три"; break;
            case 4: s += "четири"; break;
            case 5: s += "пет"; break;
            case 6: s += "шест"; break;
            case 7: s += "седем"; break;
            case 8: s += "осем"; break;
            case 9: s += "девет"; break;
            default: break;
         }
      }
      Console.WriteLine (s);
   }

   public static void Run ()
   {
      Console.WriteLine ("Chapter 5. Exercises.");
      SubSets ();
      SortTwoIntegers ();
      WriteProductSign ();
      LargestNumber ();
      SortNumbers ();
      SpellDigitsInBulgarian ();
      SolveQudraticEquation ();
      LargestOfFive ();
      ChoseType ();
      
      BonusPoints ();
      SpellNumbersInBulgarian ();
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
   
   public static string Formatted (double x, bool signed)
   {
      return (signed && x >= 0 ? "+" : "")
         + string.Format ("{0:f5}", x);
   }
}
