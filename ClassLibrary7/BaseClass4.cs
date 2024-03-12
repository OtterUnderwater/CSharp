using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library7Inheritance
{
    internal class BaseClass4
    {
        protected int num;
        public BaseClass4(int num) {
            this.num = num;
        }

        /// <summary>
        /// первое число Фибоначчи, которое больше целочисленного поля
        /// </summary>
        public void FibonacciNumber() {
            int x1 = 0;
            int x2 = 1;
            int x3 = x1 + x2;
            while (x3 <= num)
            {
                x1 = x2;
                x2 = x3;
                x3 = x1 + x2;
            }
            Console.WriteLine($"Первое число Фибоначчи больше {num} это: {x3}");
        }   
    }

    internal class NewClass4 : BaseClass4
    {
        protected int num2;
        public NewClass4(int num, int num2) : base(num)
        {
            this.num2 = num2;
        }

        /// <summary>
        /// первое число Фибоначчи, которое меньше целочисленного поля производного класса
        /// </summary>
        public new void FibonacciNumber()
        {
            int x1 = 0;
            int x2 = 1;
            int x3 = x1 + x2; int end = 1;
            while (end == 1)
            {
                if (num2 > x1 && num2 < x2)
                {
                    end = 0;
                }
                else
                {
                    x1 = x2;
                    x2 = x3;
                    x3 = x1 + x2;
                }
            }
            Console.WriteLine($"Первое число Фибоначчи меньше {num2} это: {x1}");
        }
    }
}
