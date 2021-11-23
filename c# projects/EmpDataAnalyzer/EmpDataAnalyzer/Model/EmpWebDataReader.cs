using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace EmpDataAnalyzer.Model
{
    class EmpWebDataReader
    {
        private List<string> _list = new List<string>();
        public void WebReader(EmpManager empManager)
        {
            
            WebRequest request = WebRequest.Create("https://swabhav-tech.firebaseapp.com/emp.txt");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                StringReader stringReader = new StringReader(responseFromServer);
                EmpDataStore(empManager, _list, stringReader);
            }
            response.Close();
        }

        private void EmpDataStore(EmpManager empManager, List<string> list, StringReader stringReader)
        {
            while (stringReader.ReadLine() != null)
            {                
                string data = stringReader.ReadLine();             
                if (!_list.Contains(data).Equals(data))
                {
                    _list.Add(data);
                }
            }
            foreach (var dataRow in list)
            {
                string[] data1 = dataRow.Split(',');
                empManager.AddEmployee(new Employee(int.Parse(data1[0]), data1[1], data1[2],
                                            Convert.ToInt32(IsValueNull(data1[3])), data1[4], double.Parse(data1[5]),
                                            IsValueNull(data1[6]), int.Parse(data1[7])));
            }
        }

        public double IsValueNull(string obj)
        {
            if (obj == "NULL")
                return 0;
            return Convert.ToDouble(obj);
        }
    }
}
