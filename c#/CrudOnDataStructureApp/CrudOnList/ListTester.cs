using System;


namespace CrudOnList
{
    class ListTester
    {
        static void Main(string[] args)
        {
            ListManager listManager = new ListManager();
            int isStart = 1;
            while (isStart == 1)
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("Menu:\n1)Add In List\n2)Read From List\n3)Update In List\n4)Delete in List\n5)Exit");
                Console.WriteLine("\nEnter Your Choice For CRUD operation:");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        listManager.AddInList(num);
                        break;
                    case 2:
                        Console.WriteLine("Reading list values:");
                        listManager.DisplayList();
                       
                        break;
                    case 3:
                        Console.WriteLine("Enter position and updated value:");
                        int position = Convert.ToInt32(Console.ReadLine());
                        int updatedNum = Convert.ToInt32(Console.ReadLine());
                        listManager.UpdateInList(position, updatedNum);
                        break;
                    case 4:
                        Console.WriteLine("Enter position to delete value:");
                        int positionRem = Convert.ToInt32(Console.ReadLine());
                        listManager.DeleteFromList(positionRem);
                        break;
                    case 5:
                        Console.WriteLine("Exiting");
                        isStart = 0;
                        break;
                    default:
                        Console.WriteLine("Enter number between 1 to 5 only");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
