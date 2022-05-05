using System;

public class Box
{
    private int length;
    private int bredth;
    private int height;

    public int getVolume()
    {
        return length * bredth * height;
    }

    public void setLength(int len)
    {
        length = len;
    }

    public void setBredth(int bed)
    {
        bredth = bed;
    }

    public void setHeight(int high)
    {
        height = high;
    }

    public static Box operator + (Box a, Box b)
    {
        Box box = new Box();
        box.length = a.length + b.length;
        box.bredth = a.bredth + b.bredth;
        box.height = a.height + b.height;
        return box;
    }
}

class program {
    public static void Main()
    {
        Box box1 = new Box();
        Box box2 = new Box();
        Box box3 = new Box();
        int volume = 0;

        box1.setLength(5);
        box1.setBredth(7);
        box1.setHeight(12);

        volume = box1.getVolume();
        Console.WriteLine("box1 volume: " + volume);

        box2.setLength(6);
        box2.setBredth(4);
        box2.setHeight(7);

        volume = box2.getVolume();
        Console.WriteLine("box2 volume: " + volume);

        box3 = box1 + box2;
        volume = box3.getVolume();
        Console.WriteLine("box3 volume: " + volume);
    }
}