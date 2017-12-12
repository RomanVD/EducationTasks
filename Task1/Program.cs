using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EducationTasks.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Почему статический конструктор не может иметь параметров?
            //(Тут вроде очень просто было)
            //Потому что он вызывается автоматически, при инициализации данного класса в runtime

            //Какие действия выполняет оператор new?
            //И тут просто
            //Оператор new говорит о том, что создаётся новый экземпляр класса либо структуры. Разница в том, то ссылочная переменная хранит в себе лишь ссылку на облась в памяти где находится объект класса. А переменная структуры хранит сам объект

            //В каком порядке инициализируются свойства и поля в приведенном примере?
            // Не задавался таким вопросом ранее, гуглится легко вроде бы
            // 1) Вызывается статический конструктор child, перед его вызовом инициализируются статические поля и свойства, для кторых указано какое либо значение при объявлении
            // 2) Вызывается статический конструктор parent, перед его вызовом инициализируются поля и свойства, для кторых указано какое либо значение при объявлении
            // 3) Вызывается конструктор parent, перед его вызовом инициализируются не статические поля и свойства, для кторых указано какое либо значение при объявлении
            // 4) Вызывается конструктор child, перед его вызовом инициализируются не статические поля и свйства, для кторых указано какое либо значение при объявлении
            //Под фразоый вызывается конструктор я так же понимаю, что выполняетс всё то, что внутри его, инициализация полей ли там, или другое что-то.

            //Чему будет равно SpecialMoney, DefaultMoney и PublicKey?
            //Они будт равны значениям выставленным в конструкторах, потому что инициализация свойства через равенства прям при определении свойства в классе вызовется раньше, его инициализация в конструкторе. Такая инициализация имеет смысл, если в каком либо конструкторе инициализация свойства отсутствует

            //Чему равно this в конструкторе экземпляра и в статическом конструкторе?
            //this в конструкторе экземпляра равно экзепляру
            //this в статическом конструкторе не существует
            var child = new MyChildClass("text", 1);

            //* Как статические поля/методы/свойства/классы влияют на потокобезопасность?
            // https://stackoverflow.com/questions/1090650/are-static-methods-thread-safe
            //Тут я очень плохо разбераюсь.
            //Как мне показалось ответ примерно такой, что статика априри не потоко безопасная, и если по какму либо полю планируется долбить из нескольких потоков и при этом не только на чтение, то необходимо сдлеать подобно тому как тут:
            //https://habrahabr.ru/post/147373/
            //Или просто при изменении объекта использовать Lock
            lock (Test.test)
            {
                Test.test = new MyChildClass("dfg",5);
            }
            //Либо внутри сетера сделать lock
            Test.test2 = new MyChildClass("dfg", 5);

            //* Можно ли объявить такое поле "public const MyChildClass = new MyChildClass();" в каком нибудь другом классе?
            // Показал на классе Test. На сколько я понял константа должна быть известна уже на момент компиляции программы. Поэтому она не может быть объявлена через new

            //Полезная инфа:
            //https://habrahabr.ru/post/206082/
        }
    }

    internal class MyParentClass
    {
        
        protected static decimal DefaultMoney { get; set; } = 5m; 

        public const long Identificator = 123456789012345;
        static MyParentClass()
        {
            Console.WriteLine("Called static parent constructor");
            DefaultMoney = 10m;
        }

        protected MyParentClass(int number)
        {
            Console.WriteLine("Called parent constructor");
            Number = number;
        }

        public int Number { get; set; } = 123;
    }

    internal class MyChildClass : MyParentClass
    {
        internal readonly double PublicKey = 99.9999999d;

        public static readonly decimal SpecialMoney = 20m;

        static MyChildClass()
        {
            //this - такого нет
            Console.WriteLine("Called static child constructor");
            SpecialMoney = 30m;
        }

        public MyChildClass(string text, int number) : base(number)
        {
            Console.WriteLine("Called child constructor");
            PublicKey = 100.1111111d;
            Text = text;
        }

        public string Text { get; set; }
    }

    internal class Test
    {
        private static MyChildClass _test2 = new MyChildClass("qwe",12);

        public MyChildClass child = new MyChildClass("", 5);

        public const MyChildClass child2 = null;

        public static readonly MyChildClass child4 = new MyChildClass("", 5);

        public static MyChildClass test { get; set; }

        public static MyChildClass test2
        {
            get { return _test2; }
            set {
                lock (_test2)
                {
                    _test2 = value;
                }
            }
        }

        //public const MyChildClass child3 = new MyChildClass("",5);
    }
}
