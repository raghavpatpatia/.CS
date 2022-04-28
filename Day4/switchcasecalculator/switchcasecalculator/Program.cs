using System;
class calculator
{
    public static void Main()
    {
        float number1, number2, result;
        Console.Write("Enter first number: ");
        number1 = float.Parse(Console.ReadLine());
        string operators;
        Console.Write("Perform operation(+, -, *, /): ");
        operators = Console.ReadLine();
        Console.Write("Enter second number: ");
        number2 = float.Parse(Console.ReadLine());
        switch (operators)
        {
            case "+":
                result = number1 + number2;
                Console.WriteLine("Result: {0}", result);
                break;
            case "-":
                result = number1 - number2;
                Console.WriteLine("Result: {0}", result);
                break;
            case "*":
                result = number1 * number2;
                Console.WriteLine("Result: {0}", result);
                break;
            case "/":
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot devide by 0");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine("Result: {0}", result);
                }
                break;
            default:
                Console.WriteLine("Try Again");
                break;
        }
    }
}