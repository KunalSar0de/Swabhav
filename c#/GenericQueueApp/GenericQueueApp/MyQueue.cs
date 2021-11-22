using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericQueueApp
{
    class MyQueue<T> : IQueue<T>
    {


        LinkedList<T> _list = new LinkedList<T>();
        public MyQueue()
        {
        }

        public int Count()
        {
            return _list.Count();
        }

        public T Dequeue()
        {
            _list.RemoveFirst();                        
            return _list.First();
        }

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
      

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
