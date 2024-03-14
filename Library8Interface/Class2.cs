using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library8Interface
{
    internal abstract class AbstrClass2
    {
        public abstract int SetNum();
    }

    internal class Class21 : AbstrClass2
    {
        int sumChet;

        /// <summary>
        ///  Возвращает сумму натуральных четных чисел
        /// </summary>
        /// <returns></returns>
        public override int SetNum()
        {
            return sumChet;
        }
    }
    internal class Class22 : AbstrClass2
    {
        //В первом классе метод результатом возвращает сумму натуральных четных чисел,
        //во втором классе метод возвращает результатом сумму натуральных нечетных чисел.
        //Количество слагаемых в сумме определяется полем объекта,
        //из которого вызывается метод.

        int sumNeChet;

        /// <summary>
        ///  Возвращает сумму натуральных нечетных чисел
        /// </summary>
        /// <returns></returns>
        public override int SetNum()
        {
            return sumNeChet;
        }
    }
}
