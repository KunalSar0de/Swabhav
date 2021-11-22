using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetApp
{
    class HashSetManager
    {
        private HashSet<int> set = new HashSet<int>();
        public void AddInList(int num)
        {
            set.Add(num);
        }
        public void DisplayList()
        {
            if (set.Count == 0)
            {
                Console.WriteLine("No values in set");
            }
            else
            {
                foreach (int items in set)
                {
                    Console.WriteLine(items);
                }
            }           
        }
        public void UpdateInList(int num1, int num2)
        {
            if (set.Contains(num1))
            {
                set.Remove(num1);
                set.Add(num2);
            }
            else
            {
                Console.WriteLine("{0} not found in Set",num1);
            }
        }
        public void DeleteFromList(int value)
        {
           
            if (set.Contains(value))
            {
                set.Remove(value);
            }
            else
            {
                Console.WriteLine("Value {0} not found...",value);
            }
        }
    }
}
