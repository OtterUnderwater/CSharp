using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library9Delegates
{
	delegate int SimbolInStr(char simbol, string str);
	internal class StringOperations
	{
		/// <summary>
		/// Количество вхождений символа в строку
		/// </summary>
		/// <param name="simbol"></param>
		/// <param name="str"></param>
		/// <returns></returns>
		public static int GetNumberSimbolInStr(char simbol, string str)
		{
			int count = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == simbol)
				{
					count++;
				}
			}
			return count;
		}

		/// <summary>
		/// Возвращает индекс первого вхождения в строку и -1, если в строке нет символа
		/// </summary>
		/// <param name="simbol"></param>
		/// <param name="str"></param>
		/// <returns></returns>
		public static int GetIndexSimbolInStr(char simbol, string str) => str.IndexOf(simbol);
	}
}
