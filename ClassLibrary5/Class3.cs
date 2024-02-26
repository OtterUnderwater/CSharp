using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    internal class Class3
    {
        public char simbol;
        public int num;
        public Class3(char simbol, int num)
        {
            this.simbol = simbol;
            this.num = num;
        }
        public Class3(double n)
        {
            //целая часть числа определяет код символа
            simbol = (char)Math.Round(n);
            //дробная часть (с учетом десятых и сотых)
            num = (int)Math.Round((n - Math.Round(n)) * 100);
        }
    }
}
