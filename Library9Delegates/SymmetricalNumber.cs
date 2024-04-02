using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library9Delegates
{
	delegate bool Symmetrical(int num);
	internal class SymmetricalNumber
	{
		// Создание экземпляра делегата и присваивание ему лямбда-выражения для проверки на симметричность числа
		public Symmetrical isSymmetric = num =>
		{
			string numStr = num.ToString();
			for (int i = 0, j = numStr.Length - 1; i < numStr.Length; i++, j--)
			{
				if (numStr[i] != numStr[j])
				{
					return false;
				}
			}
			return true;
		};
	}
}
