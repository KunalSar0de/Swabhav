using System;


namespace ISPSolution.Model
{
    class Robot:IWorkable
    {
        public void StartEat()
        {
            throw new Exception("Robot cant eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot Starts Working");
        }

        public void StopEat()
        {
            throw new Exception("Robot cant eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stop working");
        }
    }
}
