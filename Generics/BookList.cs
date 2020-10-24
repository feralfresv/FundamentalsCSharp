using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }    
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    
//It's not recommended, becouse the performance affect
#region Method but the performance affect
    public class ObjectList
    {
        public void Add(object value)
        {
            throw new NotImplementedException();
        }
        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
# endregion
}
