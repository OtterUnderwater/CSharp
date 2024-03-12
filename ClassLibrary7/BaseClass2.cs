using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BaseClass2
    {
        protected string str;

        public BaseClass2(string str)
        {
            this.str = str;
        }

        //virtual - разрешение на переопределение метода
        public virtual void Show()
        {
            Console.WriteLine("Базовый класс");
            Console.WriteLine($"Строка: {str}");
        }

    }
    internal class NewClass1 : BaseClass2
    {
        protected int num;

        public NewClass1(string str, int num) : base(str)
        {
            this.num = num;
        } 
        
        //Переопределение метода
        public override void Show()
        {
            Console.WriteLine("Производный класс 1");
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Число: {num}");
        }
    }

    internal class NewClass2 : BaseClass2
    {
        protected char ch;

        public NewClass2(string str, char ch) : base(str)
        {
            this.ch = ch;
        }
        public override void Show()
        {
            Console.WriteLine("Производный класс 2");
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Символ: {ch}");
        }
    }

}
