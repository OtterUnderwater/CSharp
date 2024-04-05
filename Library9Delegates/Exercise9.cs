using System;
using static Library9Delegates.NewSimbol;

namespace Library9Delegates
{
	public class Exercise9
	{
		public void Call()
		{
			int n, end;
			do
			{
				Console.WriteLine("\tВыберите задание:");
				Console.WriteLine("-----------------------------------------------------------------------------------------");
				Console.WriteLine("1. Запись символа с помощью делегата");
				Console.WriteLine("2. Сумма корней квадратного уравнения");
				Console.WriteLine("3. Проверка числа на симметричность (одинаково читается слева направо и справа налево)");
				Console.WriteLine("4. Вхождение символа в строку (индекс первого и количество всех вхождений) ");
				Console.WriteLine("-----------------------------------------------------------------------------------------");
				n = Convert.ToInt32(Console.ReadLine());
				switch (n)
				{
					case 1:
						NewSimbol obj = new NewSimbol();
						СharDelegate charDelegate = new СharDelegate(obj.SetChar); // Создание экземпляра делегата
						Console.WriteLine("Введите букву:");
						char c = Convert.ToChar(Console.ReadLine());
						charDelegate(c);  // Вызов экземпляра делегата 
						Console.WriteLine($"Метод записал букву: {obj.simbol}");
						break;
					case 2:
						QuadraticEquation obj2 = new QuadraticEquation();
						Console.WriteLine($"Сумма корней квадратного уравнения = {obj2.getSumRoots(1, -3, 2)}"); //3
						Console.WriteLine($"Сумма корней квадратного уравнения = {obj2.getSumRootsLambda(1, -3, 2)}");
						break;
					case 3:
						SymmetricalNumber obj3 = new SymmetricalNumber();
						Console.WriteLine("Введите число для проверки на симметрию:");
						int num = Convert.ToInt32(Console.ReadLine());
						string answer = obj3.isSymmetric(num) == true ? "симметрично" : "не симметрично";
						Console.WriteLine($"Число {num} - {answer}");
						break;
					case 4:
						SimbolInStr getEntry = StringOperations.GetNumberSimbolInStr; // Создание экземпляра делегата
						Console.WriteLine("Введите символ:");
						char simbol = Convert.ToChar(Console.ReadLine());
						Console.WriteLine("Введите строку:");
						string str = Console.ReadLine();
						Console.WriteLine($"Количество вхождений '{simbol}' в строке: {getEntry(simbol, str)}");
						getEntry = StringOperations.GetIndexSimbolInStr;
						Console.WriteLine($"Индекс первого вхождения '{simbol}' в строке: {getEntry(simbol, str)}");
						break;
					default: Console.WriteLine("Такого задания нет"); break;
				}
				Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
				end = Convert.ToInt32(Console.ReadLine());
			} while (end > 0);
		}
	}
}
