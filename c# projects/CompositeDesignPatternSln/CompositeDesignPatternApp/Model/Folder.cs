using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Model
{
    class Folder : IStorageItem
    {
        private string _fileName;
        private List<IStorageItem> storage = new List<IStorageItem>();
        public Folder(string filename)
        {
            _fileName = filename;
        }

        public void AddChild(IStorageItem storageItem)
        {
            storage.Add(storageItem);
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth)+_fileName);
            foreach (IStorageItem folder in storage)
            {
                folder.Display(depth+1);
            }
        }
    }
}
