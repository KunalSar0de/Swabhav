using System;
using ToDoListApp.Model;
namespace ToDoListApp
{
    class Program
    {
        static void Main()
        {
            bool appStart = true;
            ToDoManager t = new ToDoManager();
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("To Do List App");
            Console.WriteLine("---------------------------------------");

            while (appStart == true)
            {
                Console.WriteLine("\n1)Add\n2)Display\n3)Remove\n4)Exit\n");
                Console.WriteLine("Enter choice(1-4):");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("\nAdd ToDo in list:");
                        t.AddInList = Console.ReadLine();
                        Console.WriteLine("\n---------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("\nDisplaying ToDo list:");
                        t.DisplayContent();
                        Console.WriteLine("\n---------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Enter ToDO id number to remove:");
                        t.RemoveFromList = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n---------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("\nExiting TODO app...");
                        Console.WriteLine("\n---------------------------------------");
                        Console.ReadKey();
                        appStart = false;
                        break;
                    default:
                        Console.WriteLine("\nWrong choice!!try in between 1-4...");
                        Console.WriteLine("\n---------------------------------------");
                        break;
                }
            }
        }
    }
}
