using System;
using System.Collections;
using System.Collections.Generic;

namespace EducationTasks.Task2.collections
{
    //И дальше в таком же духе.
    public class MyICollection<T> : MyIEnumerable<T>, ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }

    //Замени строку (35) "class MyICollection<T> : MyIEnumerable<T>, ICollection<T>" на "class MyICollection<T> : ICollection<T>", посмотри что получится.

}
