using System;
using IntroCSharp;

class Chapter08: Menu
{
   public Chapter08 (): base ()
   {
      this.MenuTitle = "Chapter 8 - exercises.";

      this.Options = new MenuItem[] {
         new MenuItem (this.ConvertDecimalToBinary,
            " 1. Превърнете числата 151, 35, 43, 251 и -0,41 в" +
            " двоична бройна система."),
         new MenuItem (this.ConvertBinaryToHexadecimalAndDecimal,
            " 2. Превърнете числото 1111010110011110(2) в" +
            " шестнадесетична и в десетична бройна система."),
         new MenuItem (this.ConvertHexadecimalToBinaryAndDecimal,
            " 3. Превърнете шестнайсетичните числа 2A3E, FA," +
            " FFFF, 5A0E9 в двоична и десетична бройна система."),
         new MenuItem (this.ConvertAnyDecimalToBinary,
            " 4. Преобразувайте десетично число в двоично."),
         new MenuItem (this.ConvertAnyBinaryToDecimal,
            " 5. Преобразувайте двоично число в десетично."),
         new MenuItem (this.ConvertAnyDecimalToHexadecimal,
            " 6. Преобразувайте десетично число в" +
            " шестнадесетично."),
         new MenuItem (this.ConvertAnyHexadecimalToDecimal,
            " 7. Преобразувайте шестнадесетично число в" +
            " десетично."),
         new MenuItem (this.ConvertAnyHexadecimalToBinary,
            " 8. Преобразувайте шестнадесетично число в двоично."),
         new MenuItem (this.ConvertAnyBinaryToHexadecimal,
            " 9. Преобразувайте двоично число в шестнадесетично."),
         new MenuItem (this.ConvertAnyBinaryToDecimalByHornersRule,
            "10. Преобразувайте двоично число в десетично по" +
            " схемата на Хорнер."),
         new MenuItem (this.ConvertRomanToArabic,
            "11. Преобразувайте римските числа в арабски."),
         new MenuItem (this.ConvertArabicToRoman,
            "12. Преобразувайте арабските числа в римски."),
         new MenuItem (this.ConvertFromOneNumeralSystemToAnother,
            "13. Преобразувайте N(S) в N(D) по зададени число N" +
            " и основи S и D (2 ≤ S, D ≤ 16)."),
         new MenuItem (this.GetBinaryRepresentationOfTypeInt,
            "14. Преобразувайте дадено цяло число в двоично."),
         new MenuItem (this.TryNumericTypesSpeedAndPrecision,
            "15. Сумирайте 50 000 000 пъти числото 0.000001 за" +
            " типовете float, double и decimal. Сравнете" +
            " резултатите и скоростта."),
         new MenuItem (this.GetBinaryRepresentationOfTypeFloat,
            "16. Отпечатайте двоичното представяне на знака," +
            " експонентата и мантисата за числа от тип float" +
            " (32-битови с плаваща запетая съгласно стандарта" +
            " IEEE 754)."),
         new MenuItem (this.ConvertSignedDecimalFractionToBinary,
            "17. Преобразувайте десетично число със знак и" +
            " дробна част в двоично.")
      };
   }

   public void ConvertDecimalToBinary ()
   {
      decimal[] dec = {151m, 35m, 43m, 251m, -0.41m, -0.5m};
      string[] bin = new string[dec.Length];

      for (int i = 0; i < dec.Length; i++)
      {
         decimal absoluteValue = Math.Abs (dec[i]);
         decimal integerPart = decimal.Floor (absoluteValue);
         decimal fractionalPart = absoluteValue - integerPart;

         if (integerPart == 0m)
         {
            bin[i] = "0";
         }
         else
         {
            bin[i] = string.Empty;
            while (integerPart > 0m)
            {
               bin[i] =
                  decimal.Remainder (integerPart, 2m) + bin[i];
               integerPart = decimal.Truncate (
                  decimal.Divide (integerPart, 2m));
            }
         }

         if (dec[i] < 0m)
         {
            bin[i] = "-" + bin[i];
         }

         if (fractionalPart > 0m)
         {
            bin[i] += ".";
            while (fractionalPart > 0m && bin[i].Length < 80)
            {
               fractionalPart *= 2m;
               if (fractionalPart >= 1m)
               {
                  bin[i] += "1";
                  fractionalPart--;
               }
               else
               {
                  bin[i] += "0";
               }
            }
         }

         Console.WriteLine ("{0} = {1}(2)", dec[i], bin[i]);
      }
   }

   public void ConvertBinaryToHexadecimalAndDecimal ()
   {
      string bin = "1111010110011110", binZeroPadded = bin;

      switch (bin.Length % 4)
      {
         case 1: binZeroPadded = "000" + bin; break;
         case 2: binZeroPadded = "00" + bin; break;
         case 3: binZeroPadded = "0" + bin; break;
      }

      string hex = string.Empty;

      string bin4digits, hexDigit = string.Empty;
      for (int i = 0; i < binZeroPadded.Length; i+=4)
      {
         bin4digits = binZeroPadded.Substring(i, 4);
         switch (bin4digits)
         {
            case "0000": hexDigit = "0"; break;
            case "0001": hexDigit = "1"; break;
            case "0010": hexDigit = "2"; break;
            case "0011": hexDigit = "3"; break;
            case "0100": hexDigit = "4"; break;
            case "0101": hexDigit = "5"; break;
            case "0110": hexDigit = "6"; break;
            case "0111": hexDigit = "7"; break;
            case "1000": hexDigit = "8"; break;
            case "1001": hexDigit = "9"; break;
            case "1010": hexDigit = "a"; break;
            case "1011": hexDigit = "b"; break;
            case "1100": hexDigit = "c"; break;
            case "1101": hexDigit = "d"; break;
            case "1110": hexDigit = "e"; break;
            case "1111": hexDigit = "f"; break;
         }
         hex += hexDigit;
      }

      int dec = 0;
      int power = 1;
      for (int exponent = 0; exponent < bin.Length; exponent++)
      {
         if (bin[bin.Length - 1 - exponent].Equals('1'))
         {
            dec += power;
         }
         power *= 2;
      }

      Console.WriteLine ("{0}(2) = {1}(16) = {2}", bin, hex, dec);
   }

   public void ConvertHexadecimalToBinaryAndDecimal ()
   {
      string[] hexArray = {"2A3E", "FA", "FFFF", "5A0E9"};

      for (int i = 0; i < hexArray.Length; i++)
      {
         string hex = hexArray[i], bin = string.Empty;

         string bin4digits = string.Empty, hexDigit;
         for (int j = 0; j < hex.Length; j++)
         {
            hexDigit = hex[j].ToString ().ToLower ();
            switch (hexDigit)
            {
               case "0": bin4digits = "0000"; break;
               case "1": bin4digits = "0001"; break;
               case "2": bin4digits = "0010"; break;
               case "3": bin4digits = "0011"; break;
               case "4": bin4digits = "0100"; break;
               case "5": bin4digits = "0101"; break;
               case "6": bin4digits = "0110"; break;
               case "7": bin4digits = "0111"; break;
               case "8": bin4digits = "1000"; break;
               case "9": bin4digits = "1001"; break;
               case "a": bin4digits = "1010"; break;
               case "b": bin4digits = "1011"; break;
               case "c": bin4digits = "1100"; break;
               case "d": bin4digits = "1101"; break;
               case "e": bin4digits = "1110"; break;
               case "f": bin4digits = "1111"; break;
            }
            bin += bin4digits;
         }

         int dec = 0, power = 1, factor = 0;
         hexDigit = string.Empty;
         for (int exponent = 0; exponent < hex.Length; exponent++)
         {
            hexDigit =
               hex[hex.Length - 1 - exponent].ToString ().ToLower ();
            switch (hexDigit)
            {
               case "a": factor = 10; break;
               case "b": factor = 11; break;
               case "c": factor = 12; break;
               case "d": factor = 13; break;
               case "e": factor = 14; break;
               case "f": factor = 15; break;
               default: factor = int.Parse (hexDigit); break;
            }
            dec += factor * power;

            power *= 16;
         }

         Console.WriteLine ("{0}(16) = {1}(2) = {2}",
                            hex, bin, dec);
      }
   }

   public void ConvertAnyDecimalToBinary ()
   {
      Console.Write ("Decimal = ");
      int dec = int.Parse (Console.ReadLine ());

      int remainder = dec % 2;
      int quotient = dec / 2;
      string bin = remainder.ToString ();
      while (quotient > 0)
      {
         remainder = quotient % 2;
         quotient /= 2;
         bin = remainder + bin;
      }
      Console.WriteLine ("{0} = {1}(2)", dec, bin);
   }

   public void ConvertAnyBinaryToDecimal ()
   {
      Console.Write ("Binary = ");
      string bin = Console.ReadLine ();

      int dec = 0;
      int power = 1;
      for (int exponent = 0; exponent < bin.Length; exponent++)
      {
         if (bin[bin.Length - 1 - exponent].Equals('1'))
         {
            dec += power;
         }
         power *= 2;
      }

      Console.WriteLine ("{0}(2) = {1}", bin, dec);
   }

   public void ConvertAnyDecimalToHexadecimal ()
   {
      Console.Write ("Decimal = ");
      int dec = int.Parse (Console.ReadLine ());

      int remainder, quotient = dec;
      string hex = string.Empty, hexDigit;
      do
      {
         remainder = quotient % 16;
         quotient /= 16;

         switch (remainder)
         {
            case 10: hexDigit = "a"; break;
            case 11: hexDigit = "b"; break;
            case 12: hexDigit = "c"; break;
            case 13: hexDigit = "d"; break;
            case 14: hexDigit = "e"; break;
            case 15: hexDigit = "f"; break;
            default: hexDigit = remainder.ToString (); break;
         }
         hex = hexDigit + hex;
      }
      while (quotient > 0);

      Console.WriteLine ("{0} = {1}(16)", dec, hex);
   }

   public void ConvertAnyHexadecimalToDecimal ()
   {
      Console.Write ("Hexadecimal = ");
      string hex = Console.ReadLine ();

      int dec = 0, power = 1, factor = 0;
      string hexDigit = string.Empty;
      for (int exponent = 0; exponent < hex.Length; exponent++)
      {
         hexDigit =
            hex[hex.Length - 1 - exponent].ToString ().ToLower ();
         switch (hexDigit)
         {
            case "a": factor = 10; break;
            case "b": factor = 11; break;
            case "c": factor = 12; break;
            case "d": factor = 13; break;
            case "e": factor = 14; break;
            case "f": factor = 15; break;
            default: factor = int.Parse (hexDigit); break;
         }
         dec += factor * power;

         power *= 16;
      }

      Console.WriteLine ("{0}(16) = {1}", hex, dec);
   }

   public void ConvertAnyHexadecimalToBinary ()
   {
      Console.Write ("Hexadecimal = ");
      string hex = Console.ReadLine ();
      string bin = string.Empty;

      string bin4digits = string.Empty, hexDigit;
      for (int i = 0; i < hex.Length; i++)
      {
         hexDigit = hex[i].ToString ().ToLower ();
         switch (hexDigit)
         {
            case "0": bin4digits = "0000"; break;
            case "1": bin4digits = "0001"; break;
            case "2": bin4digits = "0010"; break;
            case "3": bin4digits = "0011"; break;
            case "4": bin4digits = "0100"; break;
            case "5": bin4digits = "0101"; break;
            case "6": bin4digits = "0110"; break;
            case "7": bin4digits = "0111"; break;
            case "8": bin4digits = "1000"; break;
            case "9": bin4digits = "1001"; break;
            case "a": bin4digits = "1010"; break;
            case "b": bin4digits = "1011"; break;
            case "c": bin4digits = "1100"; break;
            case "d": bin4digits = "1101"; break;
            case "e": bin4digits = "1110"; break;
            case "f": bin4digits = "1111"; break;
         }
         bin += bin4digits;
      }

      Console.WriteLine ("{0}(16) = {1}(2)", hex, bin);
   }

   public void ConvertAnyBinaryToHexadecimal ()
   {
      Console.Write ("Binary = ");
      string bin = Console.ReadLine ();

      switch (bin.Length % 4)
      {
         case 1: bin = "000" + bin; break;
         case 2: bin = "00" + bin; break;
         case 3: bin = "0" + bin; break;
      }

      string hex = string.Empty;

      string bin4digits, hexDigit = string.Empty;
      for (int i = 0; i < bin.Length; i+=4)
      {
         bin4digits = bin.Substring(i, 4);
         switch (bin4digits)
         {
            case "0000": hexDigit = "0"; break;
            case "0001": hexDigit = "1"; break;
            case "0010": hexDigit = "2"; break;
            case "0011": hexDigit = "3"; break;
            case "0100": hexDigit = "4"; break;
            case "0101": hexDigit = "5"; break;
            case "0110": hexDigit = "6"; break;
            case "0111": hexDigit = "7"; break;
            case "1000": hexDigit = "8"; break;
            case "1001": hexDigit = "9"; break;
            case "1010": hexDigit = "a"; break;
            case "1011": hexDigit = "b"; break;
            case "1100": hexDigit = "c"; break;
            case "1101": hexDigit = "d"; break;
            case "1110": hexDigit = "e"; break;
            case "1111": hexDigit = "f"; break;
         }
         hex += hexDigit;
      }

      Console.WriteLine ("{0}(2) = {1}(16)", bin, hex);
   }

   public void ConvertAnyBinaryToDecimalByHornersRule ()
   {
      Console.Write ("Binary = ");
      string bin = Console.ReadLine ();

      int dec = 0;

      for (int i = 0; i < bin.Length; i++)
      {
         dec *= 2;
         if (bin[i].Equals ('1'))
         {
            dec++;
         }
      }

      Console.WriteLine ("{0}(2) = {1}", bin, dec);
   }

   public void ConvertRomanToArabic ()
   {
      Console.Write ("Roman = ");
      string roman = Console.ReadLine ().ToUpper ();

      int arabic = 0, digitValue = 0,
         prevDigitValue = int.MaxValue;

      for (int i = 0; i < roman.Length; i++)
      {
         switch (roman[i])
         {
            case 'M': digitValue = 1000; break;
            case 'D': digitValue = 500; break;
            case 'C': digitValue = 100; break;
            case 'L': digitValue = 50; break;
            case 'X': digitValue = 10; break;
            case 'V': digitValue = 5; break;
            case 'I': digitValue = 1; break;
         }
         arabic += digitValue;
         if (prevDigitValue < digitValue)
         {
            arabic -= 2 * prevDigitValue;
         }

         prevDigitValue = digitValue;
      }
      Console.WriteLine ("{0} = {1}", roman, arabic);
   }

   public void ConvertArabicToRoman ()
   {
      Console.Write ("Arabic = ");
      int arabic = int.Parse (Console.ReadLine ());

      string roman = string.Empty;

      int thousands = arabic / 1000;

      for (int i = 0; i < thousands; i++)
      {
         roman += "M";
      }

      int hundreds = (arabic / 100) % 10;

      switch (hundreds)
      {
         case 1: roman += "C"; break;
         case 2: roman += "CC"; break;
         case 3: roman += "CCC"; break;
         case 4: roman += "CD"; break;
         case 5: roman += "D"; break;
         case 6: roman += "DC"; break;
         case 7: roman += "DCC"; break;
         case 8: roman += "DCCC"; break;
         case 9: roman += "CM"; break;
      }

      int tens = (arabic / 10) % 10;

      switch (tens)
      {
         case 1: roman += "X"; break;
         case 2: roman += "XX"; break;
         case 3: roman += "XXX"; break;
         case 4: roman += "XL"; break;
         case 5: roman += "L"; break;
         case 6: roman += "LX"; break;
         case 7: roman += "LXX"; break;
         case 8: roman += "LXXX"; break;
         case 9: roman += "XC"; break;
      }

      int ones = arabic % 10;

      switch (ones)
      {
         case 1: roman += "I"; break;
         case 2: roman += "II"; break;
         case 3: roman += "III"; break;
         case 4: roman += "IV"; break;
         case 5: roman += "V"; break;
         case 6: roman += "VI"; break;
         case 7: roman += "VII"; break;
         case 8: roman += "VIII"; break;
         case 9: roman += "IX"; break;
      }

      Console.WriteLine ("{0} = {1}", arabic, roman);
   }

   public void ConvertFromOneNumeralSystemToAnother ()
   {
      Console.Write ("Source number, N = ");
      string source = Console.ReadLine ();
      Console.Write ("Base of source's numeral system, S = ");
      int sourceBase = int.Parse (Console.ReadLine ());
      Console.Write ("Base of destination's numeral system, D = ");
      int destinationBase = int.Parse (Console.ReadLine ());

      int sourceValue = 0, factor = 0;

      for (int i = 0; i < source.Length; i++)
      {
         sourceValue *= sourceBase;
         switch (source[i])
         {
            case '0': factor = 0; break;
            case '1': factor = 1; break;
            case '2': factor = 2; break;
            case '3': factor = 3; break;
            case '4': factor = 4; break;
            case '5': factor = 5; break;
            case '6': factor = 6; break;
            case '7': factor = 7; break;
            case '8': factor = 8; break;
            case '9': factor = 9; break;
            case 'a': factor = 10; break;
            case 'b': factor = 11; break;
            case 'c': factor = 12; break;
            case 'd': factor = 13; break;
            case 'e': factor = 14; break;
            case 'f': factor = 15; break;
            default: factor = sourceBase + 1; break;
         }
         if (factor < sourceBase)
         {
            sourceValue += factor;
         }
         else
         {
            Console.WriteLine ("'{0}' is not a digit in numeral" +
            " system with base {1}", source[i], sourceBase);
            return;
         }
      }

      int remainder = 0, quotient = sourceValue;
      string destination = string.Empty, destinationDigit;
      do
      {
         remainder = quotient % destinationBase;
         quotient /= destinationBase;

         switch (remainder)
         {
            case 10: destinationDigit = "a"; break;
            case 11: destinationDigit = "b"; break;
            case 12: destinationDigit = "c"; break;
            case 13: destinationDigit = "d"; break;
            case 14: destinationDigit = "e"; break;
            case 15: destinationDigit = "f"; break;
            default:
               destinationDigit = remainder.ToString (); break;
         }
         destination = destinationDigit + destination;
      }
      while (quotient > 0);

      Console.WriteLine ("{0}({1}) = {2}({3})",
                         source, sourceBase,
                         destination, destinationBase);
   }

   public void GetBinaryRepresentationOfTypeInt ()
   {
      Console.Write ("Int = ");
      int dec = int.Parse (Console.ReadLine ());

      string bin = string.Empty;

      for (int i = 0; i < 32; i++)
      {
         bin = ((dec >> i) & 1) + bin;
      }

      Console.WriteLine ("{0} = {1}(2)", dec, bin);
   }

   public void TryNumericTypesSpeedAndPrecision ()
   {
      float single = 0.0f;
      double real = 0.0;
      decimal dec = 0.0m;

      DateTime singleTime, realTime, decTime;
      TimeSpan singleTimeSpan, realTimeSpan, decTimeSpan;
      singleTime = DateTime.Now;
      for (int i = 0; i < 50000000; i++)
      {
         single += 0.000001f;
      }
      singleTimeSpan = DateTime.Now - singleTime;
      realTime = DateTime.Now;
      for (int i = 0; i < 50000000; i++)
      {
         real += 0.000001;
      }
      realTimeSpan = DateTime.Now - realTime;
      decTime = DateTime.Now;
      for (int i = 0; i < 50000000; i++)
      {
         dec += 0.000001m;
      }
      decTimeSpan = DateTime.Now - decTime;

      Console.WriteLine ("float value = {0}" + NL+
                         "float time = {1}", single,
                         singleTimeSpan);
      Console.WriteLine ("double value = {0}" + NL+
                         "double time = {1}", real,
                         realTimeSpan);
      Console.WriteLine ("decimal value = {0}" + NL+
                         "decimal time = {1}", dec,
                         decTimeSpan);
   }

   public void GetBinaryRepresentationOfTypeFloat ()
   {
      Console.Write ("Float = ");
      float dec = float.Parse (Console.ReadLine ());

      string binarySign, binaryExponent, binarySignificand;
      if (dec < 0)
      {
         binarySign = "1";
      }
      else
      {
         binarySign = "0";
      }

      float significand = Math.Abs (dec);
      int exponent = 0;

      if (0.0f == significand)
      {
         significand = float.Epsilon;
      }

      while (0.0f < significand && significand < 1.0f)
      {
         significand *= 2.0f;
         exponent--;
      }
      while (2.0f <= significand)
      {
         significand /= 2.0f;
         exponent++;
      }

      significand--;
      exponent += 127;

      binaryExponent = string.Empty;
      for (int i = 0; i < 8; i++)
      {
         binaryExponent = ((exponent >> i) & 1) + binaryExponent;
      }

      binarySignificand = string.Empty;
      while (significand > 0.0f || binarySignificand.Length < 23)
      {
         significand *= 2.0f;
         if (significand < 1.0f)
         {
            binarySignificand += "0";
         }
         else
         {
            binarySignificand += "1";
            significand--;
         }
      }

      Console.WriteLine (
         "{0} = [{1}][{2}][{3}](IEEE 754)",
         dec, binarySign, binaryExponent, binarySignificand);
   }

   public void ConvertSignedDecimalFractionToBinary ()
   {
      Console.Write ("Signed decimal fraction = ");
      decimal dec = decimal.Parse (Console.ReadLine ());

      string bin;

      decimal absoluteValue = Math.Abs (dec);
      decimal integerPart = decimal.Floor (absoluteValue);
      decimal fractionalPart = absoluteValue - integerPart;

      if (integerPart == 0m)
      {
         bin = "0";
      }
      else
      {
         bin = string.Empty;
         while (integerPart > 0m)
         {
            bin =
               decimal.Remainder (integerPart, 2m) + bin;
            integerPart = decimal.Truncate (
               decimal.Divide (integerPart, 2m));
         }
      }

      if (dec < 0m)
      {
         bin = "-" + bin;
      }

      if (fractionalPart > 0m)
      {
         bin += ".";
         while (fractionalPart > 0m && bin.Length < 180)
         {
            fractionalPart *= 2m;
            if (fractionalPart >= 1m)
            {
               bin += "1";
               fractionalPart--;
            }
            else
            {
               bin += "0";
            }
         }
      }

      Console.WriteLine ("{0} = {1}(2)", dec, bin);
   }
}
