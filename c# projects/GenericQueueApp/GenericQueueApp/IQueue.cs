using System.Collections.Generic;

namespace GenericQueueApp
{
    interface IQueue<T>:IEnumerable<T>
    {
        void Enqueue(T item);
        T Dequeue();
        int Count();
    }
}
