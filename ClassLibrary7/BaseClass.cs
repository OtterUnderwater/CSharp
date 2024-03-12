using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BaseClass
    {
        // Защищенное поле доступно из любого места в своем классе или в производных классах
        protected string str;

        public BaseClass(string str)
        {
            this.str = str;
        }
        public void Show()
        { 
            Console.WriteLine("Базовый класс");
            Console.WriteLine($"Строка: {str}");
        }
    }

    internal class NewClass : BaseClass
    {
        protected int num;

        public NewClass(string str, int num): base(str)
        {
            this.num = num;
        }

        //Замещение/сокрытие метода
        public new void Show()
        {
            Console.WriteLine("Производный класс");
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Число: {num}");
        }
    }
}
