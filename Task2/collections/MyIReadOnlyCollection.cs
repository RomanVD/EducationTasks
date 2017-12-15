using System.Collections.Generic;

namespace EducationTasks.Task2.collections
{
    public class MyIReadOnlyCollection<T> : MyIEnumerable<T>, IReadOnlyCollection<T>
    {
        public int Count { get; }
    }
}
