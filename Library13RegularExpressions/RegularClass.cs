using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library13RegularExpressions
{
	internal class RegularClass
	{
		public static void TimeCheck() {
			string date = "15:00";
			//Создание регулярного выражения
			//00-19 или 20-23
			Regex reg = new Regex(@"^([01]?[0-9]|2[0-3]):[0 - 5][0 - 9]$");
			//Проверка на совпадение строки шаблону
			bool check = reg.IsMatch(date);
		}


	}
}
