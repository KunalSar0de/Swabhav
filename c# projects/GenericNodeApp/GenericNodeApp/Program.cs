using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp
{
    class Program
    {
        static void Main()
        {
            Node<string> n1 = new Node<string>();
            Node<string> n2 = new Node<string>();
            Node<string> n3 = new Node<string>();
            n1.SetData = "Mumbai";
            n2.SetData = "Pune";
            n3.SetData = "Nashik";

            n1.SetNext(n2);
            n2.SetNext(n3);
            Console.WriteLine("nodes from n1->n3");
            PrintDetails(n1);
            Console.WriteLine("\nnodes from n2->n3");
            PrintDetails(n2);
            Console.ReadKey();
        }

        public static void PrintDetails(Node<string> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.GetData);
                PrintDetails(node.GetNext());
            }
        }
    }
}
