using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EducationTasks.Task2.sets
{
    public class MyHashSet<T> : MyISet<T>, IReadOnlyCollection<T>
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
