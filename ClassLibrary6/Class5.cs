using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library6Properties
{
    internal class Class5
    {
        int num;
        string text;

        public int Num
        {
            set
            {
                if (value >= 0)
                {
                    this.num = value;
                    this.text = Convert.ToString(value, 2);
                }
                else
                {
                    Console.Write("Введите неотрицательное число");
                }
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
        }
    }
}
