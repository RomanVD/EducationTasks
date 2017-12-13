using System;
using System.Collections.Generic;
using System.Text;

namespace EducationTasks.Task2
{
    public class MyIList<T> : MyICollection<T>,IList<T>
    {
        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
