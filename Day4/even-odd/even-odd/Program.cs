class program
{
    public static void Main()
    {
        System.Console.WriteLine("Even numbers form 1 to 30: ");
        for (int i = 2; i <= 30; i += 2)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Odd numbers form 1 to 30: ");
        for (int i = 1; i <= 30; i += 2)
        {
            System.Console.Write(i + " ");
        }
    }
}