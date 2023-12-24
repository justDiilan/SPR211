using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStack
{
    public class Stack<T>
    {
        private List<T> elements;

        public Stack() 
        { 
            elements = new List<T>();
        }

        public int Count { get { return elements.Count; } }

        public void Push(T item)
        {
            if (item == null)
                throw new ArgumentNullException("Item cannot be null.");

            elements.Add(item);
        }

        public T Pop()
        {
            if (elements.Count == 0)
                throw new ArgumentNullException("The stack is empty.");

            int lastIndex = elements.Count - 1;
            T item = elements[lastIndex];
            elements.RemoveAt(lastIndex);

            return item;
        }

        public T Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return elements[elements.Count - 1];
        }

        public void Clear()
        {
            elements.Clear();
        }
    }
}
