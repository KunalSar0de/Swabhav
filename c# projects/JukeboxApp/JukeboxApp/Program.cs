using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JukeboxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyListUser> newa= ReadUserFile();
            foreach(var item in newa)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static List<MyListUser> ReadUserFile()
        {
            List<MyListUser> lstUser;
            string[] sMyData = File.ReadAllLines(@"E:\swabhav\c#\OOP\JukeboxApp\song.txt");
            if (sMyData != null)
            {
                MyListUser oTmp;
                string[] sTmp;
                lstUser = new List<MyListUser>();
                for (int i = 0; i < sMyData.GetLength(0); i++)
                {
                    sTmp = Regex.Split(sMyData[i], "/");

                    if (sTmp != null && sTmp.GetLength(0) > 1)
                    {
                        oTmp = new MyListUser();
                        oTmp.Name = sTmp[0];
                        int.TryParse(sTmp[1], out oTmp.Grades);
                        lstUser.Add(oTmp);
                    }
                }

                return lstUser.OrderBy(o => o.Grades).ToList();
            }
            return null;

        }
    }
    class MyListUser
    {
        public string Name;
        public int Grades;
        public string NameS
        {
            get
            {
                return Name;
            }
        }
        public int GradeS
        {
            get
            {
                return Grades;
            }
        }
    }
}
