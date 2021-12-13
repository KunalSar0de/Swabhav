using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpleCommandApp
{
    class Program
    {
        static void Main()
        {
            var connectionString = ConfigurationManager
                .ConnectionStrings["dev_localdb"].ConnectionString;

            //DisplayAll(connectionString);
            Displayone(connectionString);

            Console.ReadKey(); 
        }

        public static void DisplayAll(string connectionString)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student", con);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("Id\t\tF Name\t\tL Name\t\tCGPA");
                Console.WriteLine("-----------------------------------------------------");
                while (dr.Read())
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", dr["Id"].ToString(), dr["Firstname"].ToString(), dr["Lastname"], dr["Cgpa"]);
                }
            }
        }

        public static void Displayone(string conncectionString)
        {
            using (var con = new SqlConnection(conncectionString))
            {
                con.Open();
                Console.Write("Enter Id : ");
                string id = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("select * from student where id= "+id, con);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("Id\t\tF Name\t\tL Name\t\tCGPA");
                Console.WriteLine("-----------------------------------------------------");
                while (dr.Read())
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", dr["Id"].ToString(), dr["Firstname"].ToString(), dr["Lastname"], dr["Cgpa"]);
                }
            }
        }
    }
}
