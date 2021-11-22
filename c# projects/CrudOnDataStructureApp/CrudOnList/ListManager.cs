using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CrudOnList
{
    class ListManager
    {
        private List<int> list = new List<int>();

        public void AddInList(int num)//add
        {
            list.Add(num);
        }
        public void DisplayList()//read
        {
            foreach(int items in list)
            {
                Console.WriteLine(items);
            }
        }
        public void UpdateInList(int position,int num)//update
        {
            
            for (int i = 0; i <= list.Count(); i++)//0 1 2 3 
            {
                if (position == i)//2==2
                {
                    list[position-1]=num;               
                }
            } 
            
        }
        public void DeleteFromList(int position)//0 1 2  3
        {
            position -= 1;
            for (int i = 0; i < list.Count(); i++)
            {
                if (position == i)//
                {
                    list.Remove(list[i]);                    
                }
            }
        }
    }
}
