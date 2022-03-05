using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> Head;
        public T Data{get; set;}
        public Node<T> Next { get; set; }

        public Node()
        {
            Data = default;
            Next = null;
        }
        public Node(T element)
        {
            Data = element;
            Next= null;
        }

        public void printLinkedList()
        {
            Node<T> n = Head;
            while (n != null)
            {
                Console.Write(n.Data + " -> ");
                n = n.Next;
            }
        }
        public void Append(Node<T> node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node<T> p = Head;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = node;
            }
        }
        public void Delete(T nodedata)
        {
            Node<T> n = Head;
            Node<T> node = Head;
            while (!node.Data.Equals(nodedata))
            {
                node = node.Next;
            }
            if (node==n ) {

                Head = n.Next;
                
            }

            else
            {
                while (n.Next != node && n.Next!=null)
                {
                    n = n.Next;
                }
                n.Next = n.Next.Next;
               
            }
            
        }
        public Node<T> cloneLinkedList(Node<T> headnode) 
        {
            Node<T> p = headnode;
            Node<T> clonelist = new Node<T>();
            Node<T> tail=null;

            while (p != null)
            {
                if (clonelist == null)
                {
                    clonelist = p;
                    tail = clonelist;
                }

                tail.Next = new Node<T>();


            }

        }

    }
}
