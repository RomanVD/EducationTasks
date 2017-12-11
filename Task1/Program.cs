using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationTasks.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Почему статический конструктор не может иметь параметров?

            //Какие действия выполняет оператор new?

            //В каком порядке инициализируются свойства и поля?

            //Чему будет равно SpecialMoney, DefaultMoney и PublicKey?

            //Чему равно this в конструкторе экземпляра и в статическом конструкторе?
            
            var child = new MyChildClass("text", 1);

            //* Изменится ли порядок инициализации статических свойст DefaultMoney и SpecialMoney, если раскомментировать строку 59?            

            //* Нарисуй примерную схему того, что будет находиться в оперативной памяти после вызова new MyChildClass("text", 1)

            //* Можно ли объявить такое поле public const MyChildClass = new MyChildClass(); в каком нибудь другом классе?
        }
    }

    internal class MyParentClass
    {
        protected static decimal DefaultMoney { get; set; } = 5m;

        public const long Identificator = 123456789012345;
        static MyParentClass()
        {
            DefaultMoney = 10m;
        }

        protected MyParentClass(int number)
        {
            Number = number;
        }

        public int Number { get; set; }
    }

    internal class MyChildClass : MyParentClass
    {
        internal readonly double PublicKey = 99.9999999d;

        public static readonly decimal SpecialMoney = 20m;

        static MyChildClass()
        {
            //DefaultMoney = 15m;
            SpecialMoney = 30m;            
        }

        public MyChildClass(string text, int number) : base(number)
        {
            PublicKey = 100.1111111d;
            Text = text;
        }

        public string Text { get; set; }
    }

    class test
    {

    }
}
