using System;
using System.Collections;
using System.Collections.Generic;

//Что находится в каждой из этих сборок?

namespace EducationTasks.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проиллюстрируй в коде иерархию наследования коллекций, как показано ниже.
			//Продолжи цепочку наследования классов коллекций.
			//Цель - запомнить иерархию наследования коллекций, какой интерфейс какие методы содержит.
        }
    }

	//Создаем свою реализацию базового интерфейса коллекции (имплементировать методы не обязательно)
    class MyIEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

	//Потом создадим свою реализацию-пустышку для следующего в цепочке наследования интерфейса-коллекции
	//Наследуем его от нашего класса и реализуем следующий в цепочке интерфейс.
    class MyIEnumerable<T> : MyIEnumerable, IEnumerable<T>
    {
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

	//И дальше в таком же духе.
    class MyICollection<T> : MyIEnumerable<T>, ICollection<T>
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
    //Продолжай, их не так уж много. Гугл в помощь.
    //Что бы не терять читаемость, переноси классы в отдельные файлы или используй регионы (#region   #endregion)
}