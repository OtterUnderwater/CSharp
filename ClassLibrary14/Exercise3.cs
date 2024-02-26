using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary14
{
    public class Exercise3
    {
        static void Zadanie1()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int yes = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ':')
                {
                    yes = 1;
                }
            }
            if (yes == 1)
            {
                Console.WriteLine($"Двоеточие есть. Индекс первого вхождения = {str.IndexOf(':')}\nДвоеточию предшествует {str.IndexOf(':')} символов.");
            }
            else
            {
                Console.WriteLine("Двоеточия нет.");
            }
        }
        static void Zadanie2()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            int max = words[0].Length;
            int min = words[0].Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                }
                if (words[i].Length < min)
                {
                    min = words[i].Length;
                }
            }
            Console.WriteLine($"Размер максимального слова в строке = {max} букв");
            Console.WriteLine($"Размер минимального слова в строке = {min} букв");
        }
        static void Zadanie3()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int simbol = 0;
            str = str.Replace(" ", "").ToLower(); //удаление пробелов и смена регистра
            string str2 = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += str[i];
            }
            if (str == str2)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }
        static void Zadanie4()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            char[] simvol = new char[10] { 'а', 'у', 'о', 'и', 'э', 'ы', 'я', 'ю', 'е', 'ё' };
            int[] col = new int[10];
            int Sum = 0;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < simvol.Length; j++)
                {
                    if (str[i] == simvol[j])
                    {
                        col[j]++;
                    }
                }
            }
            for (int i = 0; i < col.Length; i++)
            {
                Sum += col[i];
            }
            Console.WriteLine($"В данной строке {Sum} гласных букв:");
            for (int i = 0; i < simvol.Length; i++)
            {
                if (col[i] != 0)
                {
                    Console.WriteLine($"{simvol[i]} = {col[i]}");
                }
            }
        }
        static void Zadanie5()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            str = str.ToLower().Replace(" ", "");
            str = new string(str.Distinct().ToArray());
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                if (i < str.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("   Выберите задание: ");
                Console.WriteLine("1. Определяет есть ли \":\" в строке и сколько символов ему предшествует");
                Console.WriteLine("2. Определяет размер максимального и минимального слов в строке");
                Console.WriteLine("3. Проверка является ли строка палиндромом");
                Console.WriteLine("4. Cколько в введенной строке гласных русских букв и количество каждой гласной буквы по-отдельности");
                Console.WriteLine("5. Вывести из каких символов состоит введенная пользователем строка");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Zadanie1(); break;
                    case 2: Zadanie2(); break;
                    case 3: Zadanie3(); break;
                    case 4: Zadanie4(); break;
                    case 5: Zadanie5(); break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
