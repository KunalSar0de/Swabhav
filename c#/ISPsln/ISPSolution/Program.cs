using System;
using ISPSolution.Model;

namespace ISPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();

            AtCafeteria(manager);
            //AtCafeteria(robot);
            AtWorkStation(manager);
            AtWorkStation(robot);

            Console.ReadKey();
        }
        public static void AtCafeteria(IEatble eatable)
        {
            Console.WriteLine("\nAt Cafeteria:");
            eatable.StartEat();
            eatable.StopEat();
        }
        public static void AtWorkStation(IWorkable worker)
        {
            Console.WriteLine("\nAt Workstation:");
            worker.StartWork();
            worker.StopWork();
        }
    }   
}
