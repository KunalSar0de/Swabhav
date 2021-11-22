
using System.Net;
using System.IO;


namespace EmployeeDataAnalyzerApp.Model
{
    class EmployeeWebDataReader
    {
        public void ReadFromFile(EmployeeManager employeeManager)
        {
            WebClient client = new WebClient();
            using (Stream data = client.OpenRead("https://swabhav-tech.firebaseapp.com/emp.txt"))
            {
                using (StreamWriter writer = new StreamWriter(data))
                {
                    File.Create(@"f:\kunu.txt");
                    writer.WriteLine(data);
                    /*List<string> urls = new List<string>();
                    foreach (var item in content)
                    {
                        urls.Add(item);
                    }
                    foreach (var row in matches)
                    {
                        string[] data = row.Split(',');
                        employeeManager.AddEmployee(new Employee(Convert.ToInt32(data[0]), data[1], data[2],
                                                    Convert.ToInt32(CheckIfLineNull(data[3])), data[4], Convert.ToDouble(data[5]),
                                                    CheckIfLineNull(data[6]), Convert.ToInt32(data[7])));
                    }*/
                }
            }
        }
    }       
}
