using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library6Properties
{
    internal class Class4
    {
        int dice1;
        int dice2;
        public int Dice1
        {
            set
            {
                if (value > 0 && value <= 6)
                {
                    this.dice1 = value;
                }
                else
                {
                    Console.Write("На кости может выпасть только число от 1 до 6");
                }
            }
        }
        public int Dice2
        {
            set
            {
                if (value > 0 && value <= 6)
                {
                    this.dice2 = value;
                }
                else
                {
                    Console.Write("На кости может выпасть только число от 1 до 6");
                }
            }
        }
        public string Result
        {
            get
            {
                if (dice1 == 0 || dice2 == 0)
                {
                    if (dice1 > dice2)
                    {
                        return "На первой кости выпало больше";
                    }
                    else if (dice1 < dice2)
                    {
                        return "На второй кости выпало больше";
                    }
                    else
                    {
                        return "Значения на костях равны";
                    }
                }
                else
                {
                    return "Заполните значение двух костей";
                }
            }
        }
    }
}
