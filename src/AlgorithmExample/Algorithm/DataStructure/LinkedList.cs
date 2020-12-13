using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithm.DataStructure
{
    public class LinkedList<T>
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void Add(Object data)
        {
            Node newNode = new Node(data, null);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        public void Delete()
        {
            head = head.next;
        }
        public void Display()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data.ToString());
                node = node.next;
            }
        }
    }
    public class Node
    {
        public Object data;
        public Node next;
        public Node(Object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
