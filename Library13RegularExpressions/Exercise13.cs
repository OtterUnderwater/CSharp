namespace Library13RegularExpressions
{
	public class Exercise13
	{
		public void Call()
		{
			int n, end;
			do
			{
				Console.WriteLine("\tВыберите задание:");
				Console.WriteLine("-----------------------------------------------------------------------------------");
				Console.WriteLine("1. Проверка почтового индекса");
				Console.WriteLine("2. Проверка серии и номера паспорта");
				Console.WriteLine("3. Проверка корректности ввода телефона");
				Console.WriteLine("4. Проверка корректности введенного времени в формате часы:минуты");
				Console.WriteLine("5. Проверка корректности ввода пароля");
				Console.WriteLine("------------------------------------------------------------------------------------");
				n = Convert.ToInt32(Console.ReadLine());
				switch (n)
				{
					case 1: break;
					case 2: break;
					case 3: break;
					case 4: RegularClass.TimeCheck(); break;
					case 5: break;
					default: Console.WriteLine("Такого задания нет"); break;
				}
				Console.WriteLine("1 - Выбрать другое задание, 0 - В меню.");
				end = Convert.ToInt32(Console.ReadLine());
			} while (end > 0);
		}
	}
}
