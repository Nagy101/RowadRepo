using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay09.Classes
{
    public class GenericStack<T>
    {
        private T[] elements;
        private int top = -1;
        private int capacity;

        public GenericStack(int size)
        {
            capacity = size;
            elements = new T[capacity];
        }

        public void Push(T item)
        {
            if (top >= capacity - 1)
                throw new InvalidOperationException("Stack overflow");
            elements[++top] = item;
        }

        public T Pop()
        {
            if (top < 0)
                throw new InvalidOperationException("Stack underflow");
            return elements[top--];
        }

        public T Peek()
        {
            if (top < 0)
                throw new InvalidOperationException("Stack is empty");
            return elements[top];
        }

        public bool IsEmpty() => top < 0;
    }

}
