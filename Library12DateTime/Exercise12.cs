namespace Library12DateTime
{
    public class Exercise12
    {
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("\tВыберите задание:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Проверка является ли день выходным");
                Console.WriteLine("2. Дата начала недели");
                Console.WriteLine("3. Прошло дней с начала года");
                Console.WriteLine("----------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: DateClass.GetWeekendOrWorkingDay(); break;
                    case 2: DateClass.GetStartDateWeek(); break;
                    case 3: DateClass.GetCountDay(); break;
                    case 4:
                        Console.Write("Введите первый год: ");
                        int year1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второй год: ");
                        int year2 = Convert.ToInt32(Console.ReadLine());
                        DateClass.GetDayInYear(year1, year2);
                        break;
                    case 5: DateClass.GetDaysРassed(); break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("1 - Выбрать другое задание, 0 - В меню.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }

    }
}