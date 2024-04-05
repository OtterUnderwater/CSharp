using Other;
using Library1_4Basics;
using Library5Class;
using Library6Properties;
using Library7Inheritance;
using Library8Interface;
using Library9Delegates;
using Library10TextFiles;

namespace ConsoleCSharp
{
	class MainClass
	{
		static void Main()
		{
			InputControl IC = new InputControl();
			RemoteControl1 RC1 = new RemoteControl1();
			StaticMethods1 E1 = new StaticMethods1();
			Arrays2 E2 = new Arrays2();
			Strings3 E3 = new Strings3();
			ExceptionHandling4 E4 = new ExceptionHandling4();
			Exercise5 E5 = new Exercise5();
			Exercise6 E6 = new Exercise6();
			Exercise7 E7 = new Exercise7();
			Exercise8 E8 = new Exercise8();
			Exercise9 E9 = new Exercise9();
			Exercise10 E10 = new Exercise10();
			int n, end;
			do
			{
				Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
				Console.WriteLine("\tВыберите тему:");
				Console.WriteLine("---------------------------");
				Console.WriteLine("0. Входной контроль");
				Console.WriteLine("1. Статические методы");
				Console.WriteLine("2. Массивы");
				Console.WriteLine("3. Работа со строками");
				Console.WriteLine("4. Обработка исключений");
				Console.WriteLine("5. Классы и объекты");
				Console.WriteLine("6. Свойства");
				Console.WriteLine("7. Наследование");
				Console.WriteLine("8. Абстрактные классы и интерфейсы");
				Console.WriteLine("9. Делегаты");
				Console.WriteLine("10. Работа с текстовыми файлами");
				Console.WriteLine("101. Задачи Дистант");
				Console.WriteLine("---------------------------");
				Console.ResetColor(); // сбрасываем в стандартный
				n = Convert.ToInt32(Console.ReadLine());
				switch (n)
				{
					case 0: IC.Call(); break;
					case 1: E1.Call(); break;
					case 2: E2.Call(); break;
					case 3: E3.Call(); break;
					case 4: E4.Call(); break;
					case 5: E5.Call(); break;
					case 6: E6.Call(); break;
					case 7: E7.Call(); break;
					case 8: E8.Call(); break;
					case 9: E9.Call(); break;
					case 10: E10.Call(); break;
					case 101: RC1.Call(); break;
					default: Console.WriteLine("Такой темы нет"); break;
				}
				Console.WriteLine("Поменять тему? (1 - да, 0 - нет).");
				end = Convert.ToInt32(Console.ReadLine());
			} while (end > 0);
		}
	}
}