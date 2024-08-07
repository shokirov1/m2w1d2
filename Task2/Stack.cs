using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d2.Task2
{
    public class Stack<T>
    {
        private List<T> list = new List<T>();

        public void Push(T item)
        {
            list.Add(item);
        }
        public T Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Пустой");
            }
            T item = list[list.Count-1];
            list.RemoveAt(list.Count-1);
            return item;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Пустой");
            }
            return list[list.Count - 1];
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
