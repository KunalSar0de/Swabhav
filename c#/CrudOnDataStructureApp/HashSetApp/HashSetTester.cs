using System;

namespace HashSetApp
{
    class HashSetTester
    {
        static void Main()
        {
            HashSetManager hashSetManager = new HashSetManager();
            int isStart = 1;
            while(isStart == 1)
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("Menu:\n1)Add In HashSet\n2)Read From HashSet\n3)Update In HashSet\n4)Delete in HashSet\n5)Exit");
                Console.WriteLine("\nEnter Your Choice For CRUD operation:");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        hashSetManager.AddInList(num);
                        break;
                    case 2:
                        Console.WriteLine("Reading set values:");
                        hashSetManager.DisplayList();

                        break;
                    case 3:
                        Console.WriteLine("Enter replace value and update value:");
                        int RepVal = Convert.ToInt32(Console.ReadLine());
                        int updatedNum = Convert.ToInt32(Console.ReadLine());
                        hashSetManager.UpdateInList(RepVal, updatedNum);
                        break;
                    case 4:
                        Console.WriteLine("Enter value to delete :");
                        int delValue = Convert.ToInt32(Console.ReadLine());
                        hashSetManager.DeleteFromList(delValue);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        Console.ReadLine();
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
