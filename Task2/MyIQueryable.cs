﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace EducationTasks.Task2
{
    public class MyIQueryable<T> : MyIEnumerable<T>, IQueryable<T>
    {
        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();
    }
}