using System;


namespace ISPSolution.Model
{
    class Manager :ICanWorkAndEat
    {
        public void StartEat()
        {
            Console.WriteLine("Manager Starts Eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager Starts Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager Stop Eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager Stop working");
        }
    }
}
