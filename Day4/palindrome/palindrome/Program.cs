class palindrome
{
    static void pal(int n)
    {
        int original, reversed = 0, remainder;
        original = n;
        
        // reversed
        while(n != 0)
        {
            remainder = n % 10;
            reversed = reversed * 10 + remainder;
            n /= 10;
        }

        // check
        if (original == reversed)
        {
            System.Console.WriteLine(original + " is palindrome");
        }

        else
        {
            System.Console.WriteLine(original + " is not a palindrome");
        }
    }
    public static void Main()
    {
        System.Console.WriteLine("Enter number: ");
        int x = int.Parse(System.Console.ReadLine());
        pal(x);
    }
}