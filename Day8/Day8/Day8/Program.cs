using System;

class Sup
{
    public int x;
    public Sup(int x)
    {
        this.x = x;
    }
    public virtual void display()
    {
        Console.WriteLine("Value of x {0}", x);
    }
}

class Sub : Sup
{
    public int y;
    public Sub(int y, int x) : base(x)
    {
        this.y = y;
    }
    public override void display()
    {
        Console.WriteLine("Value of x {0}", x);
        Console.WriteLine("Value of y {0}", y);
    }
    ~Sub()
    {
        Console.WriteLine("Destructor");
    }
}

class Day8
{
    public static void Main()
    {
        Sub obj = new Sub(10, 20);
        obj.display();
    }
}

//class abc
//{
//    public abc()
//    {
//        Console.WriteLine("Constructor is created");
//    }
//    ~abc()
//    {
//        Console.WriteLine("Destructor is created");
//    }

//    public static void Main()
//    {
//        abc obj = new abc();
//    }
//}
