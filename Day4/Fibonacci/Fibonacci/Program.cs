class fibonacci
{
    static int fib(int n)
    {
        if(n <= 1)
        {
            return n;
        }

        else
        {
            return fib(n - 1) + fib(n - 2);
        }
    }
    public static void Main()
    {
        System.Console.WriteLine(fib(9));
    }
}