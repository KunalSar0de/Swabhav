using System;
using ISPViolation.Model;

namespace ISPViolation
{
    class Program
    {
        static void Main()
        {
            var manager = new Manager();
            var robot = new Robot();
            
            AtCafeteria(manager);
            //AtCafeteria(robot);
            AtWorkStation(manager);
            AtWorkStation(robot);
           
            Console.ReadKey();
        }
        public static void AtCafeteria(IWorker worker)
        {
            Console.WriteLine("\nAt Cafeteria:");
            worker.StartEat();
            worker.StopEat();
        }
        public static void AtWorkStation(IWorker worker)
        {
            Console.WriteLine("\nAt Workstation:");
            worker.StartWork();
            worker.StopWork();
        }
    }
}
