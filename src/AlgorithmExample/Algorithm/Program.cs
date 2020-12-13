using Algorithm.DataStructure;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DynamicArray<int>();
            Console.WriteLine(data.GetSize());  // 1
            data.Add(1);
            Console.WriteLine(data.GetSize()); // 1
            data.Add(2);
            Console.WriteLine(data.GetSize()); // 2
            data.Add(3);
            Console.WriteLine(data.GetSize()); // 4
            data.Add(4);
          
            Console.WriteLine(data.GetSize()); // 8
            Console.WriteLine("*********************");
            for (int i = 0; i < data.GetSize(); i++)
            {
                Console.WriteLine(data.GetT(i).ToString());
            }

            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);
            Console.WriteLine("*************");
            linkedList.Display();

            DeleteKthElement(linkedList.head, 3);
            Console.WriteLine("*************");
            linkedList.Display();
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
            while (fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
            }
            slowPointer.next = slowPointer.next.next;
        }
    }
}
