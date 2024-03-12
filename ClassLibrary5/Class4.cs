using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library5Class
{
    internal class Class4
    {
        private static int year;

        public static void MetodSet(int n)
        {
            year = n;
        }

        public static void DayYear()
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    //Не високосный
                    Console.WriteLine("В этом году 365 дней");
                }
                else
                {
                    //Високосный
                    Console.WriteLine("В этом году 366 дней");
                }
            }
            else
            {
                //Не високосный
                Console.WriteLine("В этом году 365 дней");
            }
        }
}
}
