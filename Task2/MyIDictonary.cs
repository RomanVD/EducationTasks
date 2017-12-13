using System;
using System.Collections.Generic;
using System.Text;

namespace EducationTasks.Task2
{
    public class MyIDictonary<TKey,TValue> : MyICollection<KeyValuePair<TKey, TValue>>,IDictionary<TKey,TValue>
    {
        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ICollection<TKey> Keys { get; }
        public ICollection<TValue> Values { get; }
    }
}
