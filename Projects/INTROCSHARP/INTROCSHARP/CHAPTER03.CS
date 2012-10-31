using System;


class Chapter03
{
	public static void InputInteger()
	{
		/* 1. Напишете израз, който да проверява дали дадено цяло
       * число е четно или нечетно.
		 * 2. Напишете булев израз, който да проверява дали дадено
       * цяло число се дели на 5 и на 7 без остатък.
		 * 3. Напишете израз, който да проверява дали третата цифра
		 * (отдясно на ляво) на дадено цяло число е 7.
		 * 4. Напишете израз, който да проверява дали третият бит на
       * дадено число е 1 или 0.
		 * .....
		 * 14. Напишете програма, която проверява дали дадено 
       * число n (1 < n < 100) е просто (т.е. се дели без остатък
       * само на себе си и на единица).
		 * 15. * Напишете програма, която разменя стойностите на
       * битовете на позиции 3, 4 и 5 с битовете на 
       * позиции 24, 25 и 26 на дадено цяло положително число.
		 */
		const uint seven = 7u; // = 4 + 2 + 1 = 111 (binary)
		uint n, swapResult, cutOutBoth, readyToPasteFirst,
         readyToPasteSecond;
		bool isEven, dividesBy5And7, digit3rdIs7, bit3rdIs0,
         isSimple = true;
		
      do {
			Console.Write("Integer n = ");
			n = uint.Parse(Console.ReadLine());
         
			isEven = (n % 2 == 0);
         dividesBy5And7 = (n % 35 == 0);
         digit3rdIs7 = ((n / 100) % 10 == 7);
         bit3rdIs0 = ((n & 4) == 4);
         if(n < 100)
         {
            int i = 2;
            while(isSimple && i < n)
               isSimple = (n % i++ > 0);
         }
         cutOutBoth = n & ~(seven << 3) & ~(seven << 24);
         readyToPasteFirst = (((n >> 3) & seven) << 24);
         readyToPasteSecond = (((n >> 24) & seven) << 3);
         swapResult = cutOutBoth | readyToPasteFirst
            | readyToPasteSecond;

			Console.WriteLine(n + " is "
			   + (isEven ? "even" : "odd"));
			Console.WriteLine(
				dividesBy5And7 ? "Both 5 and 7 divide " + n
					: "5 or 7 does not divide " + n);
			Console.WriteLine("3rd digit (right-to-left) is"
			   + (digit3rdIs7 ? " " : " not ") + 7);
			Console.WriteLine("3rd bit (right-to-left) is "
            + (bit3rdIs0 ? 1 : 0));
         if(n < 100)
         {
            Console.WriteLine(n + " (< 100) "
               + (isSimple ? "is simple" : "is not simple"));
         } else {
            Console.WriteLine(n + " > 99");
         }
			Console.WriteLine("Swapped bits 3..5 with 24..26 = "
            + swapResult);
         
			Console.WriteLine("Enter n = 0 to quit");
		} while (n != 0);
	}
	
	public static void InputIntegerAndSwapBits()
	{
		/* 16. * Напишете програма, която разменя битовете на 
		 * позиции {p, p+1, ..., p+k-1) с битовете на 
       * позиции {q, q+1, ..., q+k-1} на дадено цяло положително
       * число.
       */
		const uint zero = 0u;
      uint n, swapResult, cutOutBoth,
         readyToPasteFirst, readyToPasteSecond, kDigitMaxBinary;
		byte p, q, k;
		
      do {
			Console.Write("Integer n (unsined 32-bit) = ");
			n = uint.Parse(Console.ReadLine());
			Console.Write("Byte k (0 < k and k < 17) = ");
			k = byte.Parse(Console.ReadLine());
			Console.Write("Byte p (" + (k - 1)
			   + " < p and p < " + (33 - k) + ") = ");
			p = byte.Parse(Console.ReadLine());
			Console.Write("Byte q (q < " + (p - k + 1) + ") = ");
			q = byte.Parse(Console.ReadLine());
         
			if (0 < k && k < 17 && p > k - 1 && p < 33 - k
               && q < p - k + 1)
         {
				kDigitMaxBinary = ~zero >> (32 - k);
				cutOutBoth = n & ~(kDigitMaxBinary << p) 
               & ~(kDigitMaxBinary << q);
				readyToPasteFirst
               = (((n >> p) & kDigitMaxBinary) << q);
				readyToPasteSecond
               = (((n >> q) & kDigitMaxBinary) << p);
				swapResult = cutOutBoth | readyToPasteFirst
               | readyToPasteSecond;
				
				Console.WriteLine("Swapped bits "
               + p + ".." + (p + k - 1)
                  + " with " + q + ".." + (q + k - 1) + " = "
                     + swapResult);
			} else {
				Console.WriteLine("Invalid data!");
			}
			Console.WriteLine("Enter n = 0 to quit");
		} while (n != 0);	
	}
	
	public static void InputTrapezoidDimensions()
	{
		/* 5. Напишете израз, който изчислява площта на трапец
		 * по дадени a, b и h.
		 */
		double a, b, h, area;
		do {
			Console.Write("Base a = ");
			a = double.Parse(Console.ReadLine());
			Console.Write("Base b = ");
			b = double.Parse(Console.ReadLine());
			Console.Write("Height h = ");
			h = double.Parse(Console.ReadLine());
			
			area = (a + b) * h / 2;
         
			Console.WriteLine("Area = " + area);
			Console.WriteLine("Enter h = 0 to quit");
		} while (h > 0);
	}
	
	public static void InputRectangleDimensions()
	{
		/* 6. Напишете програма, която за подадени от потребителя
       * дължина и височина на правоъгълник, пресмята и отпечатва
       * на конзолата неговия периметър и лице.
		 */
		double a, b, area, perimeter;
		do {
			Console.Write("Side a = ");
			a = double.Parse(Console.ReadLine());
			Console.Write("Side b = ");
			b = double.Parse(Console.ReadLine());
			
			area = a * b;
         perimeter = 2 * (a + b);
			
         Console.WriteLine("Area (rectangle) = " + area);
			Console.WriteLine(
            "Perimeter (rectangle) = " + perimeter);
			Console.WriteLine("Enter a = 0 to quit");
		} while (a > 0);
	}
	
	public static void InputWeightOnEarth()
	{
		/* 7. Силата на гравитационното поле на Луната е 
       * приблизително 17% от това на Земята. Напишете програма,
       * която да изчислява тежестта на човек на Луната, по
       * дадената тежест на Земята.
		 */
		double weightOnEarth, weightOnMoon;
		do {
			Console.Write("Weight on the Earth = ");
			weightOnEarth = double.Parse(Console.ReadLine());
			
			weightOnMoon = weightOnEarth * 0.17;
			Console.WriteLine(
            "Weight on the Moon = " + weightOnMoon);
			Console.WriteLine("Enter weight = 0 to quit");
		} while (weightOnEarth > 0);
	}
	
	public static void InputPointCoordinates()
	{
		/* 8. Напишете програма, която проверява дали дадена
       * точка О (x, y) е вътре в окръжността К ((0,0), 5).
       * Пояснение: точката (0,0) е център на окръжността, а
       * радиусът и е 5.
		 * 9. Напишете програма, която проверява дали дадена
       * точка О (x, y) е вътре в окръжността К ((0,0), 5) и 
       * едновременно с това извън правоъгълника ((-1, 1), (5, 5).
       * Пояснение: правоъгълникът е зададен чрез координатите
       * на *долния* си ляв и *горния* си десен ъгъл.
		 */
		const double xc = 0;
		const double yc = 0;
		const double r = 5;
		
		const double xa = -1;
		const double ya = 1;
		const double xb = 5;
		const double yb = 5;
		
		double x, y;
		do {
			Console.Write("x = ");
			x = double.Parse(Console.ReadLine());
			Console.Write("y = ");
			y = double.Parse(Console.ReadLine());
			
			bool insideCircle
            = (x - xc) * (x - xc) + (y - yc) * (y - yc) < r * r;
         bool insideRectangular
            = (xa < x && x < xb) && (ya < y && y < yb);
         
			Console.WriteLine("Point (" + x + ", " + y + ") is"
				+ (insideCircle ? " inside " : " not inside ")
			      + "circle ((" + xc + ", " + yc + "), " + r + ")");
			Console.WriteLine("Point (" + x + ", " + y + ") is"
				+ (insideRectangular ? " inside " : " not inside ")
			      + "rectangular ((" + xa + ", " + ya + "), ("
                  + xb + ", " + yb + "))");
         
			Console.WriteLine("Enter x = 0 to quit");
		} while (x != 0);			
	}
	
	public static void InputFourDigitNumber()
	{
		/* 10. Напишете програма, която приема за вход четирицифрено
       * число във формат abcd (например числото 2011) и след това
       * извършва следните действия върху него:
  		 * - Пресмята сбора от цифрите на числото (за нашия
       * пример 2+0+1+1 = 4).
  		 * - Разпечатва на конзолата цифрите в обратен ред: dcba
  		 * (за нашия пример резултатът е 1102).
  		 * - Поставя последната цифра, на първо място: dabc
  		 * (за нашия пример резултатът е 1201).
  		 * - Разменя мястото на втората и третата цифра: acbd
  		 * (за нашия пример резултатът е 2101).
  		 */
		int abcd, sumOfDigits, reverseOrderOfDigits,
         lastDigitAtFirstPlace, swappedSecondAndThirdDigit;
		bool valid;
		do {
			Console.Write("Input a 4-digit integer (abcd) = ");
			abcd = int.Parse(Console.ReadLine());
			valid = (0 <= abcd && abcd < 10000);
			if (valid)
			{
				sumOfDigits
					= (abcd % 10)
						+ (abcd / 10) % 10
						+ (abcd / 100) % 10
						+ (abcd / 1000) % 10;
				reverseOrderOfDigits
					= (abcd % 10) * 1000
						+ ((abcd / 10) % 10) * 100
						+ ((abcd / 100) % 10) * 10
						+ ((abcd / 1000) % 10);
				lastDigitAtFirstPlace
					= (abcd % 10) * 1000
						+ ((abcd / 10) % 10) * 1
						+ ((abcd / 100) % 10) * 10
						+ ((abcd / 1000) % 10) * 100;
				swappedSecondAndThirdDigit
					= (abcd % 10)
						+ ((abcd / 10) % 10) * 100
						+ ((abcd / 100) % 10) * 10
						+ ((abcd / 1000) % 10) * 1000;
            
				Console.WriteLine(
               "Sum of digits (a+b+c+d) = "
                  + sumOfDigits);
				Console.WriteLine(
               "Digits in reverse order (dcba) = "
				      + reverseOrderOfDigits);
				Console.WriteLine(
               "Last digit becomes first (dabc)= "
				      + lastDigitAtFirstPlace);
				Console.WriteLine(
               "2. and 3. digit swap places (acbd) = "
				      + swappedSecondAndThirdDigit);
			} else {
				Console.WriteLine("Enter a four-digit number!");
			}
			Console.WriteLine("Enter abcd = 0 to quit!");
		} while (abcd != 0);			
	}

	public static void InputIntegerAndBitPosition()
	{
		/* 11. Дадено е число n и позиция p. Напишете поредица от
       * операции, които да отпечатат стойността на бита на 
       * позиция p от числото n (0 или 1). Пример: n=35, p=5 -> 1.
       * Още един пример: n=35, p=6 -> 0.
		 * 12. Напишете булев израз, който проверява дали битът на
       * позиция p на цялото число v има стойност 1.
       * Пример v=5, p=1 -> false.
		 */
		int n, p, bitValue;
		bool isOne;
		do {
			System.Console.Write("Input an integer (n) = ");
			n = int.Parse(Console.ReadLine());
			Console.Write("Input a bit position (p >= 0) = ");
			p = int.Parse(Console.ReadLine());
			bitValue = (n >> p) & 1;
			Console.WriteLine("Bit at position " + p
			                  + " = " + bitValue);
			isOne = (((n >> p) & 1) == 1);
			Console.WriteLine("\"Bit at position " + p
			                  + " = 1\" is " + isOne);
			Console.WriteLine("Enter n = 0 to quit!");
		} while (n != 0);			
	}

	public static void InputIntegerAndBitPositionAndValue()
	{
		/* 13. Дадено е число n, стойност v (v = 0 или 1) и 
       * позиция p. Напишете поредица от операции, които да 
       * променят стойността на n, така че битът на позиция p да
       * има стойност v. Пример n=35, p=5, v=0 -> n=3.
       * Още един пример: n=35, p=2, v=1 -> n=39.
		 */
		const uint one = 1u;
		uint n, newInteger;
		byte v, p;
		do {
			System.Console.Write("Input an unsigned integer (n) = ");
			n = uint.Parse(Console.ReadLine());
			Console.Write("Input a bit position (p = 0..31) = ");
			p = byte.Parse(Console.ReadLine());
			Console.Write("Input a bit value (v = 0..1) = ");
			v = byte.Parse(Console.ReadLine());
			
			newInteger = (v != 0) ? (one << p) | n : ~(one << p) & n;
			Console.WriteLine("New integer = " + newInteger);
			Console.WriteLine("Enter n = 0 to quit!");
		} while (n != 0);			
	}
	
	public static void Run ()
	{
		Console.WriteLine ("Chapter 3. Exercises.");
		InputInteger();
		InputTrapezoidDimensions();
		InputRectangleDimensions();
		InputWeightOnEarth();
		InputPointCoordinates();
		InputFourDigitNumber();
		InputIntegerAndBitPosition();
		InputIntegerAndBitPositionAndValue();
      InputIntegerAndSwapBits();
	}
}
