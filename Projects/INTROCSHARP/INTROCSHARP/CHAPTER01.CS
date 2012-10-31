using System;
using IntroCSharp;

class Chapter01: MainClass
{
   new public static void Run ()
	{
		/* 5. Да се модифицира примерната програма, така че да изписва
       * различно поздравление, например "Добър ден!".
		 */
		Console.WriteLine ("Добър ден!");			
		/* 6. Напишете програма, която изписва вашето име и фамилия на
		 * конзолата.
		 */
		Console.WriteLine ("Радослав Лаков");
		/* 7. Напишете програма, която извежда на конзолата
		 * числата 1, 101, 1001 на нов ред.
		 */
		Console.WriteLine (1);
		Console.WriteLine (101);
		Console.WriteLine (1001);
		/* 8. Напишете програма, която извежда на конзолата текущата
       * дата и час.
		 */
		Console.WriteLine (DateTime.Now);
		/* 9. Напишете програма, която извежда корен квадратен от
		 * числото 12345.
		 */
		Console.WriteLine (System.Math.Sqrt(12345));
		/* 10. Напишете програма, която извежда първите 100 члена на 
		 * редицата 2, -3, 4, -5, 6, -7, 8.
		 */
		for(int i = 0; i < 100; i++)
		{
			if( i % 2 > 0) Console.WriteLine (- i - 2);
			else Console.WriteLine (i + 2);
		}
		/*11. Направете програма, която прочита от конзолата вашата възраст и
		 * изписва (също на конзолата) каква ще бъде вашата възраст
		 * след 10 години.
		 */
		Console.Write ("My age = ");
		double myAge = double.Parse (Console.ReadLine ());
		Console.WriteLine (myAge + 10);
	}
}
