using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary5
{
    internal class Class5
    {
        public int decimal10;
        public string? decimal16;

        public Class5(int decimal10)
        {
            this.decimal10 = decimal10;         
        }

        public void Result()
        {
            int ost;
            int decimal1 = decimal10;
            while (decimal1 > 0)
            {
                ost = decimal1 % 16;
                if (ost < 10)
                {
                    decimal16 += ost;
                }
                else
                {
                    switch (ost)
                    {
                        case 10: decimal16 += 'A'; break;
                        case 11: decimal16 += 'B'; break;
                        case 12: decimal16 += 'C'; break;
                        case 13: decimal16 += 'D'; break;
                        case 14: decimal16 += 'E'; break;
                        case 15: decimal16 += 'F'; break;
                    }
                }
                decimal1 = decimal1 / 16;
            }
            char[] mass = decimal16.ToCharArray();
            Array.Reverse(mass);
            decimal16 = new string(mass);
            Console.WriteLine($"{decimal10} (10) = {decimal16} (16)");
        }
    }
}
