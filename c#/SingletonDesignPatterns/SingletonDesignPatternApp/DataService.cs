using System;


namespace SingletonDesignPatternApp
{
    class DataService
    {
        private static object locker = new object();
        private static DataService bucket;
        public DataService()
        {
            Console.WriteLine("Dataservice created");
        }

        public void DoSomthing()
        {
            Console.WriteLine("work done by: "+this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            if (bucket == null)
            {
                lock (locker)
                {
                    if (bucket == null)
                    {
                        bucket = new DataService();
                    }
                }
            }
            return bucket;
        }

    }
}
