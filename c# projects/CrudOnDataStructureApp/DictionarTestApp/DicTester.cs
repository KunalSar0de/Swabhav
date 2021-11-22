using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarTestApp
{
    class DicTester
    {
        static void Main()
        { 
            DictionaryManager dictionaryManager = new DictionaryManager();
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
                        Console.WriteLine("Enter uniqie key and string:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        string val = Console.ReadLine();
                        dictionaryManager.AddInList(id,val);
                        break;
                    case 2:
                        Console.WriteLine("Reading dictionary values:");
                        dictionaryManager.DisplayList();

                        break;
                    case 3:
                        Console.WriteLine("Enter uniqie key and updated value:");
                        int key = Convert.ToInt32(Console.ReadLine());
                        string updatedval = Console.ReadLine();
                        dictionaryManager.UpdateInList(key, updatedval);
                        break;
                    case 4:
                        Console.WriteLine("Enter unique key value to delete:");
                        int uniqueKey = Convert.ToInt32(Console.ReadLine());                       
                        dictionaryManager.DeleteFromList(uniqueKey);
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
