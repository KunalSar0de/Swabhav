using System;
using System.IO;

namespace FileOpenWriteCloseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddDataInFile();
            AppendDataInFile();
            ReadAllTextFromFile();
            Console.ReadLine();
        }
        public static void AddDataInFile()
        {
            
            if (File.Exists(@"E:\swabhav\c#\OOP\FileOpenWriteCloseApp\FileIO.txt"))
            {
                File.Delete(@"E:\swabhav\c#\OOP\FileOpenWriteCloseApp\FileIO.txt");
                Console.WriteLine("Duplicate File Deleted!!");
            }
            Console.WriteLine("New file created as FileIO.txt...");
            var path = @"E:\swabhav\c#\OOP\FileOpenWriteCloseApp\FileIO.txt";
            Console.WriteLine("Enter string to write into file:");
            string text =Console.ReadLine();
            File.WriteAllText(path,text+Environment.NewLine);
            Console.WriteLine("\ntext written in file..");

        }
        public static void AppendDataInFile()
        {
            Console.WriteLine("Enter content to append in to the file:");
            string newContent = Console.ReadLine();
            while (newContent != "exit")
            {
                File.AppendAllText(@"E:\swabhav\c#\OOP\FileOpenWriteCloseApp\FileIO.txt", newContent + Environment.NewLine);
                newContent = Console.ReadLine();
            }
            Console.WriteLine("text appended");
            Console.ReadLine();                                     
        }
        public static void ReadAllTextFromFile()
        {
            string text = File.ReadAllText(@"E:\swabhav\c#\OOP\FileOpenWriteCloseApp\FileIO.txt");
            Console.WriteLine("Content of FileIO.txt \n{0}", text);
        }
    }
}