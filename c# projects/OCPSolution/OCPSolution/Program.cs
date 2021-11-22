using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolution.Model;
using OCPSolution.Client;
namespace OCPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Kunal", 12000, 5 ,new DiwaliFestPolicy());
            var fd2 = new FixedDeposit("Sohan", 10000, 7, new EidPolicy());
            Console.WriteLine("Intrest Earned {0} on amount {1} in {2} years", fd1.SimpleIntrest(), fd1.Amount,fd1.Duration);
            Console.WriteLine("Intrest Earned {0} on amount {1} in {2} years", fd2.SimpleIntrest(), fd2.Amount, fd2.Duration);
            Console.ReadKey();
        }
    }
}
