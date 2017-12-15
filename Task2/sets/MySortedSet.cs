using System;
using System.Collections;
using System.Collections.Generic;

namespace EducationTasks.Task2.sets
{
    public class MySortedSet<T> : MyISet<T>, ICollection, IReadOnlyCollection<T>
    {
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
    }
}
