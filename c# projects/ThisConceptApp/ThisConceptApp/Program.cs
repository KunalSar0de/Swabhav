using System;
using ThisConceptApp.Module;

namespace ThisConceptApp
{
    class Program
    {
        static void Main()
        {
            EmpDetails e1 = new EmpDetails("kunu",22);
            EmpDetails e2 = new EmpDetails(e1);

            Console.WriteLine(e1.Details);
            Console.WriteLine(e2.Details);
            Console.ReadLine();
        }
    }
}
