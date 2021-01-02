using Algorithm.DataStructure;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
        static void DeleteKthElement(Node root, int k) // O(n)
        {
            // init pointers
            Node slowPointer = root;
            Node fastPointer = root;

            // move fastPointer to slowPointer + k
            while (k > 0)
            {
                fastPointer = fastPointer.next;
                k--;
            }
            if (fastPointer==null)
            {
                return;
            }
            while (fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
            }
            slowPointer.next = slowPointer.next.next;
        }
    }
}
