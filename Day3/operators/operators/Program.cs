using System;

public class operators
{
    public static void Main()
    {
        int a = 5, b = 6;
        Console.WriteLine("Arthmetic operators: ");
        Console.Write("5 + 6: ");
        Console.WriteLine(a + b);
        Console.Write("5 - 6: ");
        Console.WriteLine(a - b);
        Console.Write("5 * 6: ");
        Console.WriteLine(a * b);
        Console.Write("5 / 6: ");
        Console.WriteLine(a / b);
        Console.Write("5 % 6: ");
        Console.WriteLine(a % b);
        Console.WriteLine("Relational operators: ");
        Console.Write("5 > 6: ");
        Console.WriteLine(a > b);
        Console.Write("5 < 6: ");
        Console.WriteLine(a < b);
        Console.Write("5 >= 4: ");
        Console.WriteLine(a >= 4);
        Console.Write("5 <= 4: ");
        Console.WriteLine(a <= 4);
        Console.Write("5 == 6: ");
        Console.WriteLine(a == b);
        Console.Write("5 != 6: ");
        Console.WriteLine(a != b);
        Console.WriteLine("Logical Operators: ");
        Console.Write("a == b && a == 5: ");
        if (a == b && a == 5)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Console.Write("a == b || a == 5: ");
        if (a == b || a == 5)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Console.Write("!(a == 5): ");
        Console.WriteLine(!(a == 5));
        Console.WriteLine("Bitwise operators: ");
        Console.Write("5 AND 6: ");
        Console.WriteLine(a & b);
        Console.Write("5 OR 6: ");
        Console.WriteLine(a | b);
        Console.Write("NOT 5: ");
        Console.WriteLine(~a);
        Console.WriteLine("Shift operators: ");
        Console.Write("5 << 2: ");
        Console.WriteLine(a << 2);
        Console.Write("5 >> 2: ");
        Console.WriteLine(a >> 2);
        Console.WriteLine("Special Operators: ");
        Console.Write("typeof(Console): ");
        Console.WriteLine(typeof(Console));
        Console.Write("sizeof(int): ");
        Console.WriteLine(sizeof(int));
        Console.Write("sizeof(float): ");
        Console.WriteLine(sizeof(float));
        Console.Write("sizeof(double): ");
        Console.WriteLine(sizeof(double));
        Console.Write("sizeof(decimal): ");
        Console.WriteLine(sizeof(decimal));
        Console.Write("sizeof(char): ");
        Console.WriteLine(sizeof(char));
        Console.Write("sizeof(bool): ");
        Console.WriteLine(sizeof(bool));
        Console.Write("sizeof(byte): ");
        Console.WriteLine(sizeof(byte));
    }
}