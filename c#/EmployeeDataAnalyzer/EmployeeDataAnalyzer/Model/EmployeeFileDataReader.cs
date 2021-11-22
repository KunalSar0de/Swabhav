using System;
using System.IO;

namespace EmployeeDataAnalyzerApp.Model
{
    public class EmployeeFileDataReader
    {
        public void FileReader(EmployeeManager employeeManager,string fileName)
        {
            string[] fileRows = File.ReadAllLines(fileName);
            foreach(var row in fileRows)
            {
                string[] data = row.Split(',');
                employeeManager.AddEmployee(new Employee(Convert.ToInt32(data[0]),data[1],data[2],
                                            Convert.ToInt32(IsEntryNull(data[3])),data[4],Convert.ToDouble(data[5]),
                                            IsEntryNull(data[6]),Convert.ToInt32(data[7])));
            }
        }
        public double IsEntryNull(string obj) 
        {
            if (obj == "NULL") 
                return 0;
            return Convert.ToDouble(obj);
        }
    }
}
