using System;


namespace LinkedListGenericApp
{
    class CustomLinkList<T>
    {
        private string _status;
        private Node<T> _startNode=null;
        private Node<T> _lastNode=null;

        public CustomLinkList(){ }
        public void Add(T item)
        {
            Node<T> node = new Node<T>();
            node.Data=item;
            if (_startNode == null)
            {
                _startNode = node;
            }            
            _status += "\nAdded First";
        }
       
        public void Remove(T data)
        {
            Node<T> node = _startNode;
            Node<T> prevNode = null;
            while (node != null) 
            {
                _status += "\nRemoved";
                if (data.Equals(_startNode.Data))
                {
                    _startNode = _startNode.NextNode;
                    break;
                }else if (node.Data.Equals(data))
                {
                    RemoveCurrentNode(node, prevNode);
                    break;
                }
                prevNode = node;
                node = node.NextNode;
            }
                       
        }

        private void RemoveCurrentNode(Node<T> node, Node<T> prevNode)
        {
            if (node == _lastNode)
            {
                prevNode.NextNode = null;
                _lastNode = prevNode;
            }
            else
            {
                prevNode.NextNode = node.NextNode;
            }
        }
        
        public void ListDisplay()
        {
            Node<T> node = _startNode;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.NextNode;
            }
        }
        public string LinkedListOperations()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Link List Operations:");
            Console.WriteLine("----------------------------");
            return _status;
        }
        public int Count()
        {
            int count =0;
            Node<T> node = _startNode;
            while (node != null)
            {
                count++;
                node = node.NextNode;
            }
            return count;
        }
    }
}
