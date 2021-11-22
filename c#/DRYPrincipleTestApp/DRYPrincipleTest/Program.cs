using System;

class Program
{
    static void Main(string[] args)
    {
        DoSomething();
        DoSomethingAgain();
        DoSomethingMore();
        DoSomethingExtraordinary();
        Console.ReadLine();
    }

    private static void DoSomething()
    {
        string address = "Nerul, Maharashtra";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Kunal", "a good friend", address, 22);
    }

    private static void DoSomethingAgain()
    {
        string address = "Nerul, Maharashtra";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Sohan", "a neighbour", address, 20);
    }

    private static void DoSomethingMore()
    {
        string address = "Nerul, Maharashtra";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Nita", "my sister", address, 18);
    }

    private static void DoSomethingExtraordinary()
    {
        string address = "Nerul, Maharashtra";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Shivani", "my sister's best friend", address, 18);
    }
}