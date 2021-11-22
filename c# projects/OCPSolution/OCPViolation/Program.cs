using System;
using OCPViolation.Model;
namespace OCPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Kunal", 10000, 5, FestivalType.NORMAL);
            Console.WriteLine("Intrest Earned {0} on amount {1}",fd1.SimpleIntrest(),fd1.Amount);
            Console.ReadKey();
        }
    }
}
