using System;

namespace CompositeDesignPatternApp.Model
{
    class File : IStorageItem
    {
        private string _fileName;
        private string _fileSize;
        public File(string filename,string size)
        {
            _fileName = filename;
            _fileSize = size;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _fileName+"|"+_fileSize);      
        }
    }
}
