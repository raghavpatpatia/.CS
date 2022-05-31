using System;

public class A
{
    public void print()
    {
        Console.WriteLine("Class A => Parent class");
    }
}

public class B : A
{
    public void print1()
    {
        Console.WriteLine("Class B => Child class");
    }
}

class Inheritance
{
    static void Main()
    {
        B obj = new B();
        obj.print1();
        obj.print();
    }
}