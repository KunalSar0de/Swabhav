using System;

public class Program
{
    public static void Main()
    {
        Coordinate point = new Coordinate(10, 20);

        Console.WriteLine(point.x); //output: 10  
        Console.WriteLine(point.y); //output: 20  
        Console.ReadLine();
    }
}

struct Coordinate
{
    public int x;
    public int y;

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
        /*The C# “this” keyword represents the “this” pointer of a class or a stuct.
        The this pointer represents the current instance of a class or stuct.*/
    }
}
