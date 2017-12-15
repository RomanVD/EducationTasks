using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EducationTasks.Task2.collections;

namespace EducationTasks.Task2.lists
{
    public class MyLinkedList<T> : MyICollection<T>, IReadOnlyCollection<T>
    {
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
