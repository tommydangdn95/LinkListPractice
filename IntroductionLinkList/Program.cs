using System;

namespace IntroductionLinkList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkList
    {
        public Node head;
        public void Print()
        {
            while (this.head != null)
            {
                Console.Write(head.data);
                if (head.next != null)
                {
                    Console.Write("->");
                }
                head = head.next;
            }
        }

        public void PrintReverse()
        {
            if (head != null)
            {
                Console.Write(head.data);
                if (head.next != null)
                {
                    Console.Write("->");
                }
                head = head.next;
                PrintReverse();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkList linkList = new LinkList();
            var first = new Node(1);
            var second = new Node(2);
            var third = new Node(3);

            linkList.head = first;
            first.next = second;
            second.next = third;

            // traversal

            //linkList.Print();
            linkList.PrintReverse();
        }
    }
}
