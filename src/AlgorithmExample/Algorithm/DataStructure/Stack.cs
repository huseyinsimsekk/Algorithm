using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DataStructure
{
    public class Stack
    {
        private Object[] items;
        private int top;
        private int size;
        public Stack(int size)
        {
            this.size = size;
            items = new Object[size];
            top = -1;
        }
        public void Push(Object item)
        {
            top = top + 1;
            if (IsFull())
            {
                Console.WriteLine("Stack is overflow");
                return;
            }
            items[top] = item;

        }
        public Object Pop()
        {
            top = top - 1;
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            var popItem = items[top];
            return popItem;
        }
        private bool IsEmpty()
        {
            return top <= -1;
        }
        private bool IsFull()
        {
            return size == top;
        }
    }
}
