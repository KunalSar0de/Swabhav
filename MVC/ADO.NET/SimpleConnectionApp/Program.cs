using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpleConnectionApp
{
    class Program
    {
        static void Main()
        {
            var conncectionString = ConfigurationManager
                .ConnectionStrings["dev_localdb"].ConnectionString;

            using (var con = new SqlConnection(conncectionString)) 
            {
                con.Open();
                Console.WriteLine("Connection Status : "+con.State);
                Console.WriteLine("Successfully connected to {0} and db {1}",
                   con.WorkstationId, con.Database);
            }
            Console.ReadKey();
        }
    }
}
