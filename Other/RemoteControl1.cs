using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    public class RemoteControl1
    {
        static double CalculateRating(double averageScore, int experience)
        {
            double coefficient;
            if (experience == 0)
            {
                coefficient = 1;
            }
            else if (experience < 2)
            {
                coefficient = 13;
            }
            else if (experience >= 2 && experience <= 5)
            {
                coefficient = 16;
            }
            else
            {
                coefficient = 0;
            }
            return averageScore * coefficient;
        }
        static void FindDayOfWeek(ref int n, int k)
        {
            n = (n + k - 1) % 7 + 1;
        }
        static bool Step(int x1, int y1, int x2, int y2)
        {
            // Проверка по вертикали, горизонтали или диагонали
            return x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
        static void Zadanie1()
        {
            Console.Write("Введите средний балл по диплому (от 3 до 5): ");
            double avgScore = Convert.ToDouble(Console.ReadLine());
            while (avgScore < 3 || avgScore > 5)
            {
                Console.Write("Cредний балл должен быть в диапазоне от 3 до 5, введите заново: ");
                avgScore = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Введите стаж: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            double rating = CalculateRating(avgScore, experience);
            if (rating >= 45)
            {
                Console.WriteLine("Вы приняты в магистратуру!");
            }
            else
            {
                Console.WriteLine("Ваш рейтинг недостаточен для поступления в магистратуру.");
            }
        }
        static void Zadanie2()
        {
            Console.Write("Введите номер дня недели 1 января (1 - понедельник, 7 - воскресенье): ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 1 || n > 7)
            {
                Console.Write("Номер дня недели должен быть в диапазоне от 1 до 7, введите заново: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());
            while (k < 1 || k > 365)
            {
                Console.Write("Номер дня в году должен быть в диапазоне от 1 до 365, введите заново: ");
                k = Convert.ToInt32(Console.ReadLine());
            }
            FindDayOfWeek(ref n, k);
            Console.WriteLine($"Номер дня недели для {k} дня года = {n}");
        }
        static void Zadanie3()
        {
            Console.WriteLine("Введите координаты первого поля:");
            Console.Write("x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второго поля:");
            Console.Write("x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            if (Step(x1, y1, x2, y2))
            {
                Console.WriteLine("Ферзь за один ход может перейти с одного поля на другое.");
            }
            else
            {
                Console.WriteLine("Ферзь не может перейти с одного поля на другое!");
            }

        }
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("   Выберите задание: ");
                Console.WriteLine("1. Сообщение о приеме в магистратуру");
                Console.WriteLine("2. Определить номер дня недели");
                Console.WriteLine("3. Может ли ферзь за один ход перейти с одного поля на другое");
                Console.WriteLine("--------------------------------------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Zadanie1(); break;
                    case 2: Zadanie2(); break;
                    case 3: Zadanie3(); break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }

    }
}
