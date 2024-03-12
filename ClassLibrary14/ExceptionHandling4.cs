using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1_4Basics
{
    public class ExceptionHandling4
    {
        static void Zadanie1()
        {
            try
            {
                int N;
                double SumCh = 0;
                double SumNeCh = 0;
                Console.WriteLine("Введите число N: ");
                N = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0) //Квадраты четных чисел
                    {
                        SumCh += Math.Pow(i, 2);
                    }
                    else //Кубы нечетных чисел
                    {
                        SumNeCh += Math.Pow(i, 3);
                    }
                }
                Console.WriteLine($"Сумма квадратов четных чисел: {SumCh}");
                Console.WriteLine($"Сумма кубов нечетных чисел: {SumNeCh}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенные данные не являются числами");
            }
        }
        static void Zadanie2()
        {
            try
            {
                int N, height;
                int Sum = 0;
                Console.Write("Введите количество учащихся в классе: ");
                N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Введите рост {i} учащегося: ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Sum = Sum + height;
                }
                Console.WriteLine($"Средний рост учащихся = {Sum / N} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Тип ошибки: {e.GetType().Name}");
                Console.WriteLine($"Описание: {e.Source}");
                Console.WriteLine($"Строка: {e.StackTrace}");
            }
        }
        static void Zadanie3()
        {
            try
            {
                int N;
                int size = 0;
                int CountChet = 0; //колич четных чисел
                Console.Write("Введите число: ");
                N = Convert.ToInt32(Console.ReadLine());
                int temp = N;
                //определение размера массива
                while (temp > 0)
                {
                    temp = temp / 10;
                    size++;
                }
                int[] Num = new int[size];
                temp = N;
                string str = Convert.ToString(N);
                for (int i = 0; i < size; i++)
                {
                    Num[i] = str[i] - '0';
                }
                for (int i = 0; i < size; i++)
                {
                    if (Num[i] % 2 == 0) //четное
                    {
                        CountChet++;
                    }
                }
                Console.WriteLine(N / CountChet);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенные данные не являются числами");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль невозможно");
            }
        }
        static void Zadanie4()
        {
            try
            {
                Random random = new Random();
                Console.Write("Введите количество элементов в массиве: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                int[] array = new int[n];
                int[] sumArray = new int[n];
                Console.Write("Исходный массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(10, 100); //[10; 99]
                    Console.Write(array[i] + " ");
                }
                Console.Write("\nМассив из суммы чисел исходного: ");
                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = (array[i] / 10) + (array[i] % 10);
                    sum += sumArray[i];
                    Console.Write(sumArray[i] + " ");
                }
                Console.WriteLine($"\nСумма элементов массива = {sum}");
            }
            catch
            {
                Console.WriteLine("Упс, возникла ошибка");
            }
        }
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("1. Квадраты четных чисел и кубы нечетных от 1 до N");
                Console.WriteLine("2. Средний рост всех учащихся");
                Console.WriteLine("3. Частное от деления введенного числа на количество четных цифр этого числа");
                Console.WriteLine("4. Массив из суммы цифр элементов исходного массива и сумма всех элементов полученного массива");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
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
