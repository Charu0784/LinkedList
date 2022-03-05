using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> list=new Node<int>();
            list.Head = new Node<int>(7);
            list.Append(new Node<int>(4));
            list.Append(new Node<int>(3));
            list.Append(new Node<int>(2));
            list.Append(new Node<int>(5));
            list.printLinkedList();
            Console.WriteLine();
            list.Delete(5);
            list.printLinkedList();

        }
    }
}
