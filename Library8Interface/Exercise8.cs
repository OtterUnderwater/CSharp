using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Xml.Linq;
using static Library8Interface.Tourism;
using System.Drawing;

namespace Library8Interface
{
    public class Exercise8
    {
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("\tВыберите задание:");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. Содержимое массива - aбстрактный класс");
                Console.WriteLine("2. Сумма чисел - aбстрактный класс");
                Console.WriteLine("3. Электронный журнал с оценками - интерфейс");
                Console.WriteLine("4. Туризм - интерфейс");
                Console.WriteLine("5. Спорт - интерфейс");
                Console.WriteLine("--------------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("Введите размер массива: ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        ArrayNum obj = new ArrayNum(size);
                        obj.arrayОutput();
                        break;
                    case 2: break;
                    case 3:
                        Console.Write("Введите имя студента: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите его оценку: ");
                        int evaluation = Convert.ToInt32(Console.ReadLine());
                        Journal record = new Journal(name, evaluation);
                        Console.Write("Введите оценку: ");
                        int evaluation2 = Convert.ToInt32(Console.ReadLine());
                        if (record.getStudents(evaluation2) != null)
                        {
                            Console.WriteLine($"Имя студента с такой оценкой: {record.getStudents(evaluation2)}");
                        }
                        else
                        {
                            Console.WriteLine("Студента с такой оценкой нет");
                        }
                        Console.Write("Введите имя студента: ");
                        string name2 = Console.ReadLine();
                        if (record.getEvaluations(name2) != 0)
                        {
                            Console.WriteLine($"Оценка у студента: {record.getEvaluations(name2)}");
                        }
                        else
                        {
                            Console.WriteLine("Оценка данного студента неизвестна");
                        }
                        break;
                    case 4:
                        Console.Write("Введите Cтрану: ");
                        string country = Console.ReadLine();
                        Console.Write("Введите количество билетов: ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите стоимость билета: ");
                        int price = Convert.ToInt32(Console.ReadLine());
                        Trip trip = new Trip(country, count, price);
                        trip.PrintInfo();
                        break;
                    case 5:
                        Console.Write("Хотите сыграть новую игру? Укажите ваш возраст: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Volleyball game = new Volleyball(age);
                        break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
