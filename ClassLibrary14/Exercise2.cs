using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary14
{
    public class Exercise2
    {
        static void Zadanie1()
        {
            Console.WriteLine("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int even = 0;
            int odd = 0;
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-100, 101);
                if (array[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                if (array[i] > 0)
                {
                    Console.WriteLine($"Число {array[i]} - положительное");
                }
                else if (array[i] < 0)
                {
                    Console.WriteLine($"Число {array[i]} - отрицательное");
                }
                else if (array[i] == 0)
                {
                    Console.WriteLine($"Число {array[i]} - не является ни положительным, ни отрицательным");
                }
            }
            Console.WriteLine($"Количество четных чисел: {even}");
            Console.WriteLine($"Количество нечетных чисел: {odd}");
        }
        static void Zadanie2()
        {
            Console.WriteLine("Введите количество строк массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] Array = new int[n, m];
            int[,] NewArray = new int[m, n];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = rnd.Next(-10, 11);
                    NewArray[j, i] = Array[i, j];
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Транспонированая матрица: ");
            for (int i = 0; i < NewArray.GetLength(0); i++)
            {
                for (int j = 0; j < NewArray.GetLength(1); j++)
                {
                    Console.Write(NewArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Zadanie3()
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = (char)rnd.Next('а', 'я' + 1);
            }
            foreach (char c in array)
            {
                if (Convert.ToInt32(c) % 2 == 0)
                {
                    Console.WriteLine($"Элемент {c}, его номер {Convert.ToInt32(c)} и он четный");
                }
                else
                {
                    Console.WriteLine($"Элемент {c}, его номер {Convert.ToInt32(c)} и он нечетный");
                }
            }
        }
        static void Zadanie4()
        {
            Console.WriteLine("Введите размерность двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] Array = new int[n, n];
            int Sum = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = rnd.Next(-10, 11);
                    Console.Write(Array[i, j] + "\t");
                    if (i > j)  //элементы под главной диагональю
                    {
                        if (Array[i, j] > 0)
                        {
                            Sum += Array[i, j];
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма положительных элементов под главной диагональю = {Sum}");
        }
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("   Выберите задание: ");
                Console.WriteLine("1. Выводит на экран массив из n случайных целых чисел (от -100 до 100)");
                Console.WriteLine("2. Выводит транспонированая матрицу");
                Console.WriteLine("3. Выводит массив букв и говорит про четность каждого номера буквы");
                Console.WriteLine("4. Сумма положительных элементов под главной диагональю");
                Console.WriteLine("---------------------------------------------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Zadanie1(); break;
                    case 2: Zadanie2(); break;
                    case 3: Zadanie3(); break;
                    case 4: Zadanie4(); break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
