using System;
using System.Collections.Generic;

namespace GenericQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> numbers = new MyQueue<int>();
            //Enqueue
            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(300);
            PrintDetails(numbers);
            Console.WriteLine("Count : "+numbers.Count());
            //Dequeue
            numbers.Dequeue();
            PrintDetails(numbers);
            Console.WriteLine("Count : " + numbers.Count());           

            Console.ReadKey();
        }
        public static void PrintDetails(IQueue<int> queue)
        {
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintWithoutUsingForEach(IQueue<int> queue)
        {
            IEnumerator<int> iterator = queue.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
