using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarTestApp
{
    class DictionaryManager
    {
        private Dictionary<int, string> dic =new Dictionary<int, string>();
        public void AddInList(int uniqueId,string num)
        {
            dic.Add(uniqueId,num);
        }

        public void DisplayList()//read
        {
            if (dic.Count == 0)
            {
                Console.WriteLine("No values in set");
            }
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Key = {0},Value = {1}",item.Key, item.Value);
            }
            
        }
        public void UpdateInList(int key, string val)
        {
            dic.Remove(key);
            dic.Add(key,val);
        }
        public void DeleteFromList(int uniqueKey )
        {         
            dic.Remove(uniqueKey);            
        }
    }
}
