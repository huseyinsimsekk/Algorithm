using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DataStructure
{
    public class DynamicArray<T>
    {
        int Size;
        Object[] Data;
        public DynamicArray()
        {
            Size = 0;
            Data = new Object[1];
        }
        public int GetSize()
        {
            return Data.Length;
        }
        public T GetT(int index)
        {
            return (T)Data[index];
        }
        public void Add(Object data)
        {
            EnsureCapacity(Size + 1);
            Data[Size++] = data;
        }
        public void EnsureCapacity(int minCapacity)
        {
            int oldCapacity = GetSize();
            if (minCapacity > oldCapacity)
            {
                int newCapacity = oldCapacity * 2;
                if (newCapacity < minCapacity)
                {
                    newCapacity = minCapacity;
                }
                Array.Resize(ref Data, newCapacity);              
            }
        }
    }
}
