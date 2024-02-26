using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    internal class Class3
    {
        int cost; //цена одного тюльпана
        int count; //количество тюльпанов в букете
        public int Сost
        {
            set
            {
                this.cost = value;
            }
        }
        public int Tulip
        {
            set
            {
                if (value % 2 != 0)
                {
                    this.count = value;
                }
                else
                {
                    Console.Write("Нельзя заказать нечетное количество тюльпанов");
                }
            }
        }
        public int Price
        {
            get
            {
                return cost * count;
            }
        }
    }
}
