using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library7Inheritance
{
    internal class BaseClass6
    {
        public int number;

        /// <summary>
        /// Считывает цифры в десятичном представлении числа (значение поля). 
        /// </summary>
        public virtual void ReadNumber()
        {
            Console.WriteLine("Введите число базового класса:");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal class NewClass6 : BaseClass6
    {
        public int number2;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"> поле, значение которого используется</param>
        /// <param name="discharge"> разряд, для которого считывается цифра</param>
        public new void ReadNumber(int num, int discharge)
        {
            if (discharge == 1)
            {
                number = num;
            }
            else if (discharge == 2)
            {
                number2 = num;
            }
        }

        /// <summary>
        /// Метод без аргументов 
        /// </summary>
        public override void ReadNumber()
        {
            int sum = number + number2;
            number2 = sum;
        }

    }
}
