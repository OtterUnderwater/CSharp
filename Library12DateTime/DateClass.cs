using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library12DateTime
{
    internal class DateClass
    {

        /// <summary>
        /// Проверка является ли день выходным
        /// </summary>
        static public void GetWeekendOrWorkingDay()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateOnly dateOnly = new DateOnly(year, month, day);
            if (dateOnly.DayOfWeek == DayOfWeek.Saturday || dateOnly.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Данный день - выходной");
            }
            else
            {
                Console.WriteLine("Данный день - рабочий");
            }
        }

        /// <summary>
        /// Выводит дату начала недели
        /// </summary>
        static public void GetStartDateWeek()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            int newday = day - 6;
            if (date.DayOfWeek != DayOfWeek.Sunday)
            {
                newday = day - (int)date.DayOfWeek - 1;
            }
            DateTime newDate = new DateTime(year, month, newday);
            Console.WriteLine("Дата начала недели:" + newDate.ToString("dd MMMM yyyy года"));
        }

        /// <summary>
        /// Подсчета количества дней, прошедших с начала года
        /// </summary>
        static public void GetCountDay()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            Console.WriteLine($"С начала года прошло {date.DayOfYear - 1} дней");
        }

        /// <summary>
        /// Для указанного интервала времени определяются годы, первый день которых (1 января) попадает на понедельник
        /// </summary>
        static public void GetDayInYear(int year1, int year2)
        {
            for (int year = year1; year <= year2; year++)
            {
                DateOnly date = new DateOnly(year, 1, 1);
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine($"1 Января {date.Year} года - понедельник");
                }
            }
        }

        /// <summary>
        /// Сколько лет, месяцев и дней прошло от указанной даты ДР до текущей
        /// </summary>
        static public void GetDaysРassed()
        {
            Console.Write("Введите год рождения: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц рождения: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день рождения: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            DateTime dateNow = DateTime.Now;
            TimeSpan dateRezult = date.Subtract(dateNow);
            DateTime dt = new DateTime(1, 1, 1) + dateRezult;
            Console.WriteLine("От указанной даты до текущей:" + dateRezult.ToString("dd MMMM yyyy года"));
        }
    }
}
