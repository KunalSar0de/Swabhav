
namespace LinkedListGenericApp
{
    class Node<T>
    {
        private T _data;
        private Node<T> _nextNode;


        public T Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public Node<T> NextNode
        {
            get
            {
                return _nextNode;
            }
            set
            {
                _nextNode = value;
            }
        }
    }
}
