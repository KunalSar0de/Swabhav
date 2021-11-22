using System;
class day4Test
{
    private static void PrintDetails(int content)
    {
        Console.WriteLine("Overloading #1");
        Console.WriteLine(+content);
    }
    private static void PrintDetails(string content)
    {
        Console.WriteLine("Overloading #2");
        Console.WriteLine(content);
    }
    private static void PrintDetails(double content)
    {
        Console.WriteLine("Overloading #3");
        Console.WriteLine(+content);
    }
    private static void PrintDetails(float content)
    {
        Console.WriteLine("Overloading #4");
        Console.WriteLine(+content);
    }
    private static void PrintDetails(bool content)
    {
        Console.WriteLine("Overloading #5");
        Console.WriteLine(content);
    }
    private static void PrintDetails(char content)
    {
        Console.WriteLine("Overloading #6");
        Console.WriteLine(content);
    }
    private static void Main(String[] args)
    {
        PrintDetails(100);
        PrintDetails("Hello");
        PrintDetails(100.55);
        PrintDetails(100.55f);
        PrintDetails(true);
        PrintDetails('#');
        Console.ReadLine();
    }
}