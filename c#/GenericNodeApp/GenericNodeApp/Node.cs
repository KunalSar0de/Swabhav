using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp
{
    class Node<T>
    {
        private T _data;
        private Node<T> _next;
        public Node()
        {
        }

        public T SetData
        {
            set
            {
                _data = value;
            }
        }
        public T GetData
        {
            get
            {
                return _data;
            }
        }
        public void SetNext(Node<T> node)
        {            
                _next = node;            
        }
        public Node<T> GetNext()
        {
            return _next;
        }
    }
}
