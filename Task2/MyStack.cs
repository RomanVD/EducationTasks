using System;
using System.Collections;
using System.Collections.Generic;

namespace EducationTasks.Task2
{
    public class MyStack<T> : MyIEnumerable<T>, ICollection, IReadOnlyCollection<T>
    {
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSynchronized { get; }
        public object SyncRoot { get; }

        int IReadOnlyCollection<T>.Count
        {
            get { throw new NotImplementedException(); }
        }
    }
}
