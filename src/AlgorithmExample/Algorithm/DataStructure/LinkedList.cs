using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithm.DataStructure
{
    public class LinkedList<T>
    {
        Node _head;
        public LinkedList()
        {
            _head = null;
        }
        public void Add(Object data)
        {
            Node newNode = new Node(data, null);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                newNode.next = _head;
                _head = newNode;
            }
        }
        public void Delete()
        {
            _head = _head.next;
        }
        public void Display()
        {
            Node node = _head;
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
