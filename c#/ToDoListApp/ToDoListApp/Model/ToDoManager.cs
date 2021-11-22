using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoListApp.Model
{
    class ToDoManager
    {
        readonly string filePath = System.Configuration.ConfigurationManager.AppSettings["filePath"];
        public string AddInList
        {
            set
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    if (File.Exists(filePath))
                    {
                        writer.WriteLine(value.ToString());
                        writer.Close();
                    }
                    else
                    {
                        File.Create(filePath);
                        writer.Close();
                    }
                }
            }
        }

        public int RemoveFromList
        {
            set
            {
                if (File.Exists(filePath))
                {
                    List<string> fileContent = new List<string>();
                    TextReader tr = new StreamReader(filePath);
                    string currentLine = string.Empty;
                    while ((currentLine = tr.ReadLine()) != null)
                    {
                        fileContent.Add(currentLine);
                    }
                    tr.Close();

                    int count = 0;
                    if (value > fileContent.Count)
                    {
                        Console.WriteLine("Entered ID is not in ToDo list");
                    }
                    else
                    {
                        value -= 1;
                        for (int i = 0; i < fileContent.Count; i++)
                        {
                            if (i == value)
                            {
                                fileContent.Remove(fileContent[i]);
                                File.WriteAllLines(filePath, fileContent.Cast<string>().ToArray());
                                count = i;
                            }
                        }
                        tr.Close();
                        Console.WriteLine("ToDo #{0} removed successfully...", count + 1);
                    }
                }
                else
                {
                    Console.WriteLine("file is empty nothing to remove!!");
                    var myFile = File.Create(filePath);
                    myFile.Close();
                }

            }
        }

        public void DisplayContent()
        {
            int count = 0;
            if (File.Exists(filePath))
            {
                if (new FileInfo(filePath).Length == 0)
                {
                    Console.WriteLine("-->Bamm!!Nothing in ToDo list!!");
                }
                else
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            count++;
                            Console.WriteLine("#{0} {1}", count, line);
                        }
                        sr.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("Nothing to display..ToDo is empty!!");
                var myFile = File.Create(filePath);
                myFile.Close();
            }


        }
    }
}
