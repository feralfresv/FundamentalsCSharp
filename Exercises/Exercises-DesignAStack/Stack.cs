using System.Collections.Generic;
using System.Linq;
using System;

namespace Exercises_DesignAStack
{
    public class Stack
    {
        public List<int> list = new List<int>();

        public void Push(object obj)
        {
            if (obj is int)
            {
                int number = (int)obj;
                list.Add(number);
            }
            else
                throw new ArgumentException("**Only NUmbers**__Push()");
        }
        public object Pop()
        {
            if (list.Count == 0)
                throw new ArgumentException("**Only NUmbers**__POP()");
            var item = list.Last();
            list.Remove(item);
            return item;
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
