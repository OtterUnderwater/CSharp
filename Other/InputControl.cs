namespace Other
{
    public class InputControl
    {
        static void Zadanie1()
        {
            Console.WriteLine("Введите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ответ = {Math.Pow(a, b)}");
        }
        static void Zadanie2()
        {
            Console.WriteLine("Введите координаты начала гипотенузы: ");
            double x0 = Convert.ToInt32(Console.ReadLine());
            double y0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты конца гипотенузы: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double hypotenuse = Math.Sqrt(Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2));
            double kat1 = Math.Sqrt(Math.Pow((x0 - x0), 2) + Math.Pow((y0 - y1), 2));
            double kat2 = Math.Sqrt(Math.Pow((x0 - x1), 2) + Math.Pow((y0 - y0), 2));
            double P = hypotenuse + kat1 + kat2;
            double S = (kat1 * kat2) / 2;
            Console.WriteLine($"Периметр = {P}, площадь = {S}");
        }
        static void Zadanie3()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((a % 2) == (a % 3)) ? "Остаток одинаковый" : "Остаток разный");
        }
        static void Zadanie4()
        {
            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();
            var num = str.ToCharArray();
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
        static void Zadanie5()
        {
            Console.WriteLine("Введите x и y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4)));
        }
        static void Zadanie6()
        {
            Console.WriteLine("Введите количество чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 };
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }
        static void Zadanie7()
        {
            Console.WriteLine("Введите количество чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 1;
            double otv = 0;
            for (int i = 0; i < n; i++)
            {
                otv = otv + a / (a + 1);
                a++;
            }
            Console.WriteLine(otv);
        }
        static void Zadanie8()
        {
            Console.WriteLine("Введите результаты трех спортсменов: ");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int three = Convert.ToInt32(Console.ReadLine());
            if (one > two && one > three)
                Console.WriteLine($"Победил первый спортсмен: {one}");
            else if (two > one && two > three)
                Console.WriteLine($"Победил второй спортсмен: {two}");
            else if (three > one && three > two)
                Console.WriteLine($"Победил третий спортсмен: {three}");
            else Console.WriteLine("Результаты соревнований спорные");
        }
        static void Zadanie21()
        {
            Console.WriteLine("Введите два положительных числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a >= 0 && b >= 0)
                Console.WriteLine($"Логарифм {a} по основанию {b} = {Math.Log(a, b)}");
            else
                Console.WriteLine($"Числа не положительные");

        }
        static void Zadanie22()
        {
            Console.WriteLine("Введите координаты начала диагонали:");
            double x0 = Convert.ToInt32(Console.ReadLine());
            double y0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты конца диагонали:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x0 - x0), 2) + Math.Pow((y0 - y1), 2));
            double width = Math.Sqrt(Math.Pow((x0 - x1), 2) + Math.Pow((y0 - y0), 2));
            double P = 2 * (length + width);
            double S = length * width;
            Console.WriteLine($"Периметр = {P}, площадь = {S}");
        }
        static void Zadanie23()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((a % 3) == (a % 4)) ? "Остаток одинаковый" : "Остаток разный");
        }
        static void Zadanie24()
        {
            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();
            var num = str.ToCharArray();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
        static void Zadanie25()
        {
            Console.WriteLine("Введите x и y");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((Math.Log(Math.Abs(Math.Cos(x)), Math.E)) / (Math.Log((1 + Math.Pow(x, 2)), Math.E)));
        }
        static void Zadanie26()
        {
            Console.WriteLine("Введите количество чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 };
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }
        static void Zadanie27()
        {
            Console.WriteLine("Введите количество чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 1;
            double otv = 0;
            for (int i = 0; i < n; i++)
            {
                otv = otv - a / (a + 1);
                a++;
            }
            Console.WriteLine(otv);
        }
        static void Zadanie28()
        {
            Console.WriteLine("Введите три числа: ");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int three = Convert.ToInt32(Console.ReadLine());
            if (one + two < 0)
                Console.WriteLine($"Сумма {one} и {two} отрицательная");
            else if (one + three < 0)
                Console.WriteLine($"Сумма {one} и {three} отрицательная");
            else if (two + three < 0)
                Console.WriteLine($"Сумма {two} и {three} отрицательная");
            else Console.WriteLine("Сумма любых двух из введенных чисел положительная");
        }
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("Выберите задание входного контроля: ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------");               
                Console.WriteLine("1. Возведение первого числа в степень второго");
                Console.WriteLine("2. Вычисляет периметр и площадь треугольника по координатам начальной и конечной точек гипотенуз");
                Console.WriteLine("3. Проверяет, дает ли введенное число одинаковый остаток при делении на 2 и на 3");
                Console.WriteLine("4. Печатает в столбик все цифры введенного n-значного(n от 1 до 10) числа в порядке возрастания разрядов.");
                Console.WriteLine("5. Выводит значение выражения при данных х и y");
                Console.WriteLine("6. Выводит последовательность n первых чисел Фибоначчи, имеющих четные индексы");
                Console.WriteLine("7. Выводит сумму первых n членов последовательности");
                Console.WriteLine("8. Выводит результат победителя заплыва из 3 спортсменов");
                Console.WriteLine("21. Логарифм первого числа по основанию второго");
                Console.WriteLine("22. Вычисляет периметр и площадь прямоугольника по координатам начальной и конечной точек диагонали");
                Console.WriteLine("23. Проверяет, дает ли введенное число одинаковый остаток при делении на 3 и на 4");
                Console.WriteLine("24. Печатает в столбик все цифры введенного n-значного(n от 1 до 10) числа в порядке убывания разрядов.");
                Console.WriteLine("25. Выводит значение выражения при данных х");
                Console.WriteLine("26. Выводит последовательность n первых чисел Фибоначчи, имеющих нечетные индексы");
                Console.WriteLine("27. Выводит разность первых n членов последовательности");
                Console.WriteLine("28. Определяет является ли сумма двух из трех введенных чисел отрицательной");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Zadanie1(); break;
                    case 2: Zadanie2(); break;
                    case 3: Zadanie3(); break;
                    case 4: Zadanie4(); break;
                    case 5: Zadanie5(); break;
                    case 6: Zadanie6(); break;
                    case 7: Zadanie7(); break;
                    case 8: Zadanie8(); break;
                    case 21: Zadanie21(); break;
                    case 22: Zadanie22(); break;
                    case 23: Zadanie23(); break;
                    case 24: Zadanie24(); break;
                    case 25: Zadanie25(); break;
                    case 26: Zadanie26(); break;
                    case 27: Zadanie27(); break;
                    case 28: Zadanie28(); break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
