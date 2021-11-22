using System;

namespace LinkedListGenericApp
{
    class Program
    {
        static void Main()
        {
            CustomLinkList<int> linkList = new CustomLinkList<int>();
            linkList.Add(100);
            linkList.Add(200);
            linkList.Add(300);
            linkList.Count();
            linkList.ListDisplay();

            /*ConsolePrinter printer = new ConsolePrinter();
            printer.PrintDetails(linkList);            
            */Console.ReadKey();
        }      
    }
}
