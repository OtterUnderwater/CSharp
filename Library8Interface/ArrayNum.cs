using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library8Interface
{
    internal abstract class AbstrClass1
    {
        protected int[] aNums;

        public AbstrClass1(int n)
        {
            Random random = new Random();
            aNums = new int[n];
            for (int i = 0; i < aNums.Length; i++)
            {
                aNums[i] = random.Next(100);
            }
        }
        public abstract void arrayОutput();

    }
    internal class ArrayNum : AbstrClass1
    {
        public ArrayNum(int n) : base(n) { }
        public override void arrayОutput()
        {
            Console.Write("Содержимое массива: ");
            foreach (int aNum in aNums)
            {
                Console.Write(aNum + " ");
            }
            Console.WriteLine();
        }
    }
}
