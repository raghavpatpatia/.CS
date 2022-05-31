using System;

public class C
{
    public void print()
    {
        Console.WriteLine("Class C => Parent class");
    }
}

public class D : C
{
    public void print1()
    {
        Console.WriteLine("Class D => Child class -> C and Parent class -> E");
    }
}

public class E : D
{
    public void print2()
    {
        Console.WriteLine("Class E => Child class");
    }
}

class MultiLevelInheritance
{
    static void Main()
    {
        E obj = new E();
        obj.print2();
        obj.print1();
        obj.print();
    }
}