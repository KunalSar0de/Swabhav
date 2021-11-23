using System;
using System.IO;


namespace EmpDataAnalyzer.Model
{
    class EmpFileDataReader
    {
        public void FileReader(EmpManager empManager, string fileName)
        {
            string[] rows = File.ReadAllLines(fileName);
            foreach (var row in rows)
            {
                string[] dataInRow = row.Split(',');
                empManager.AddEmployee(new Employee(int.Parse(dataInRow[0]), dataInRow[1], dataInRow[2],
                                       Convert.ToInt32(IsValueNull(dataInRow[3])), dataInRow[4], Convert.ToInt32(dataInRow[5]),
                                             IsValueNull(dataInRow[6]), int.Parse(dataInRow[7])));
            }
        }
        public int IsValueNull(string data)
        {
            if (data == "NULL")
                return 0;
            return 0;
        }
    }
}
