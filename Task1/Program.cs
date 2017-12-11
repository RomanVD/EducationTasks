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

            //В каком порядке инициализируются свойства и поля в приведенном примере?

            //Чему будет равно SpecialMoney, DefaultMoney и PublicKey?

            //Чему равно this в конструкторе экземпляра и в статическом конструкторе?
            
            var child = new MyChildClass("text", 1);

            //* Как статические поля/методы/свойства/классы влияют на потокобезопасность?
			// https://stackoverflow.com/questions/1090650/are-static-methods-thread-safe

            //* Можно ли объявить такое поле "public const MyChildClass = new MyChildClass();" в каком нибудь другом классе?
			
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
