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
            Console.WriteLine(data.GetSize()); // 4
            data.Add(4);
            Console.WriteLine(data.GetSize()); // 8
            Console.WriteLine("*********************");
            for (int i = 0; i < 4; i++)
            {
            Console.WriteLine(data.GetT(i));
            }
        }
    }
}
