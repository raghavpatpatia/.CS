using System;

class rectangle
{
    public int length;
    public int width;
    public rectangle(int x, int y)
    {
        length = x;
        width = y;
    }

    public int area()
    {
        return length * width;
    }
}

class cuboid : rectangle
{
    public int height;
    public cuboid(int x, int y, int z):base(x, y)
    {
        height = z;
    }
    public int volume()
    {
        return length * width * height;
    }
}

class Day7
{
    static void Main()
    {
        cuboid obj = new cuboid(10, 10, 10);
        int area = obj.area();
        int volume = obj.volume();
        Console.WriteLine("Area of rectangle= "+ area);
        Console.WriteLine("Volume of cuboid= "+ volume);
    }
}