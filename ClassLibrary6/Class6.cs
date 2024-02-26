using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    internal class Class6
    {
        static int num = 1;
        static public int NumGet
        {
            get
            {
                int print = num;
                num = num + 2;
                return print;
            }
        }

        static public int Num
        {
            set
            {
                int count = 1;
                for (int i = 1; count <= value; i = i + 2, count++)
                {
                    if (count == value)
                    {
                        num = i;
                        break;
                    }
                }
            }
        }
    }
}
