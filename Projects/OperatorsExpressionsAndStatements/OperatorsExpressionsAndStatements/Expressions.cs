using System;

class Expressions
{
    static void Main()
    {
        Console.WriteLine("Hello, Expressions!");
        // Write an expression that checks if given integer is odd or even.
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        bool isEven = (n % 2 == 0);
        Console.WriteLine("{0} is even. {1}.", n, isEven);
        
        // Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        Console.Write("Integer, n = ");
        n = int.Parse(Console.ReadLine());
        bool dividedBy5And7 = (n % 7 == 0 && n % 5 == 0);
        Console.WriteLine("{0} Can be divides by 7 and 5. {1}.", n, dividedBy5And7);

        // Write an expression that calculates rectangle’s area by given width and height.
        Console.Write("Rectangle, width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Rectangle, height = ");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine("Area = {0,4}", area);

        // Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 ? true.
        Console.Write("Integer, n = ");
        n = int.Parse(Console.ReadLine());
        bool is7The3rdDigit = ((n / 100) % 10 == 7);
        Console.WriteLine("The third digit (right-to-left) of {0} is 7. {1}.", n, is7The3rdDigit);

        // Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
        Console.Write("Integer, n = ");
        n = int.Parse(Console.ReadLine());
        int bit3 = (n >> 3) & 1;
        Console.WriteLine("The third bit (right-to-left) of {0} is {1}.", n, bit3);

        // Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        Console.Write("Point, x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Point, y = ");
        double y = double.Parse(Console.ReadLine());
        bool isWithinTheCircle = ((x * x + y * y) <= 25.0);
        Console.WriteLine("Point ({0}, {1}) is within K(O, 5). {2}", x, y, isWithinTheCircle);

        // Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
        Console.Write("Integer, n (0 ≤ n ≤ 100) = ");
        n = int.Parse(Console.ReadLine());
        bool isPrime = ((n % 2 == 0) || (n % 3 == 0) || (n % 5 == 0) || (n % 7 == 0));
        // Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.Write("Trapezoid, a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Trapezoid, b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Trapezoid, h = ");
        double h = double.Parse(Console.ReadLine());
        area = (a + b) * h / 2;
        // Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
        // and out of the rectangle R(top=1, left=-1, width=6, height=2).
        Console.Write("Point, x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Point, y = ");
        y = double.Parse(Console.ReadLine());
        bool inCircleOutOfRectangle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 9 && (x < -1 || x > 5 || y < -1 || y > 1));
        // Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer 
        // number v has value of 1. Example: v=5; p=1 ? false.
        Console.Write("Integer, v = ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Bit position, p (0 ≤ p ≤ 31) = ");
        int p = int.Parse(Console.ReadLine());
        bool is1 = (((v >> p) & 1) == 1);
        // Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 ? value=1.
        Console.Write("Integer, i = ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Bit position, bp (0 ≤ bp ≤ 31) = ");
        int bp = int.Parse(Console.ReadLine());
        int value = ((i >> bp) & 1);
        // We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n 
        // to hold the value v at the position p from the binary representation of n.
	    // Example: n = 5 (00000101), p=3, v=1 ? 13 (00001101)
	    // n = 5 (00000101), p=2, v=0 ? 1 (00000001)
        Console.Write("Integer, n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Bit value, v {0, 1} = ");
        v = int.Parse(Console.ReadLine());
        Console.Write("Bit position, p = ");
        p = int.Parse(Console.ReadLine());
        n = n | (v << p);
        // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        Console.Write("Unsigned integer, uns = ");
        uint uns = uint.Parse(Console.ReadLine());
        uns = ((((111u << 24) & uns) >> 21) | (((111u << 3) & uns) << 21)) & (uns & ~(111u << 24) & ~(111u << 3));
        // * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
        Console.Write("Unsigned integer, uns = ");
        uns = uint.Parse(Console.ReadLine());
        Console.Write("First sequence of bits starts at position, p = ");
        p = int.Parse(Console.ReadLine());
        Console.Write("Second sequence of bits starts at position, q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Swap sequences length, k = ");
        int k = int.Parse(Console.ReadLine());
        uns = ((((111u << 24) & uns) >> 21) | (((111u << 3) & uns) << 21)) & (uns & ~(111u << 24) & ~(111u << 3));
        // q >= p
        if (p > q)
        {
            int swap = p;
            p = q;
            q = swap;
        }
        uint mask = ~((~0u) << k);
        uns = ((((mask << q) & uns) >> (q - p)) | (((mask << p) & uns) << (q - p))) & (uns & ~(mask << q) & ~(mask << p));
    }
}
