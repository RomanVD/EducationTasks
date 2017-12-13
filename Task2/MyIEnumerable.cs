using System;
using System.Collections;
using System.Collections.Generic;

namespace EducationTasks.Task2
{
    //Создаем свою реализацию базового интерфейса коллекции (имплементировать методы не обязательно)
    public class MyIEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    //Потом создадим свою реализацию-пустышку для следующего в цепочке наследования интерфейса-коллекции
    //Наследуем его от нашего класса и реализуем следующий в цепочке интерфейс.
    public class MyIEnumerable<T> : MyIEnumerable, IEnumerable<T>
    {
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
