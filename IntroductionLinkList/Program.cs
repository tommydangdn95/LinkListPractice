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
            Node node = this.head;
            while (node != null)
            {
                Console.Write(node.data);
                if (node.next != null)
                {
                    Console.Write("->");
                }
                node = node.next;
            }
        }

        public void PrintReverse(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data);
                if (node.next != null)
                {
                    Console.Write("->");
                }
                node = node.next;
                PrintReverse(node);
            }
        }

        public void InsertHeadNode(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.head;
            head = newNode;
        }

        public void InsertAfter(int searchData, int data)
        {
            // search for data
            Node node = this.head;
            while(node != null)
            {
                if(node.data == searchData)
                {
                    break;
                }
                node = node.next;
            }

            if(head == null)
            {
                Console.WriteLine("Not Found data to insert after!");
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = node.next;
                node.next = newNode;
            }
        }

        public void InsertLastNode(int data)
        {
            Node node = this.head;
            Node newNode = new Node(data);
            if (node == null)
            {
                this.head = newNode;
            }
            else
            {
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = newNode;
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

            linkList.InsertHeadNode(0);
            linkList.InsertAfter(3, 4);
            linkList.InsertLastNode(5);

            // traversal
            linkList.Print();
            Console.WriteLine();
            Node node = linkList.head;
            linkList.PrintReverse(node);
        }
    }
}
