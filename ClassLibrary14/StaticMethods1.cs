
namespace Library1_4Basics
{
    public class StaticMethods1
    {
        static void Square(int start, int end)
        {
            Console.Write("Числа, которые являются квадратами других чисел: ");
            for (int i = start; i <= end; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    //Проверяем, является ли число квадратом другого числа
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static double Area(double r)
        {
            //круг
            return Math.PI * Math.Pow(r, 2);
        }
        static double Area(double a, double h)
        {
            //параллелограмм
            return a * h;
        }
        static double Area(double a, double b, double h)
        {
            //трапеция
            return (a + b) * h;
        }
        static void MinNum(ref int a)
        {
            //Наименьшая цифра целого десятичного числа
            int min = 9;
            while (a > 0)
            {
                if (min > a % 10)
                {
                    min = a % 10;
                }
                a /= 10;
            }
            Console.WriteLine($"Наименьшая цифра = {min}");
        }
        static void Quotient(ref int a)
        {
            int evenProduct = 1;
            int oddProduct = 1;
            int num = a;
            int quotient;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    evenProduct *= digit;
                }
                else
                {
                    oddProduct *= digit;
                }

                num /= 10;
            }
            quotient = evenProduct / oddProduct; //частное от произведения четных на нечетные числа
            if (quotient >= 1)
            {
                a = a / 2;  //исходное число уменьшается в два раза
            }
            else
            {
                a = a * 2; //увеличивается в два раза
            }
        }
        static void Roots(ref double a, ref double b, ref double c, out double sum)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            double root1, root2;
            if (d > 0)
            {
                root1 = (-b + Math.Sqrt(d)) / (2 * a);
                root2 = (-b - Math.Sqrt(d)) / (2 * a);
                sum = root1 + root2;
            }
            else if (d == 0)
            {
                sum = -b / (2 * a);
            }
            else
            {
                sum = a = b = c = 0;
            }
        }
        static void Zadanie1()
        {
            Console.WriteLine("Введите начало диапазона: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Square(a, b);
        }
        static void Zadanie2()
        {
            double a1, a2, a3;
            Console.WriteLine("Площадь какой фигуры вы хотели бы найти?");
            Console.WriteLine("1. Площадь круга.");
            Console.WriteLine("2. Площадь параллелограмма.");
            Console.WriteLine("3. Площадь трапеции.");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Введите радиус круга: ");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"S = {Area(a1)}");
                    break;
                case 2:
                    Console.Write("Введите длину параллелограмма: ");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту параллелограмма: ");
                    a2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"S = {Area(a1, a2)}");
                    break;
                case 3:
                    Console.Write("Введите первую сторону трапеции: ");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите вторую сторону трапеции: ");
                    a2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту трапеции: ");
                    a3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"S = {Area(a1, a2, a3)}");
                    break;
                default: Console.WriteLine("Такой фигуры нет"); break;
            }

        }
        static void Zadanie3()
        {
            Console.WriteLine("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            MinNum(ref a);
        }
        static void Zadanie4()
        {
            Console.WriteLine("Введите четырехзное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 9999 || a < 1000)
            {
                Console.WriteLine("Данное число не четырехзначное, попробуйте еще раз: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Quotient(ref a);
            Console.WriteLine($"Измененное число = {a}");
        }
        static void Zadanie5()
        {
            Console.WriteLine("Введите коэффициенты a, b и c квадратного уравнения ax^2+bx+c=0: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double sum;
            Roots(ref a, ref b, ref c, out sum);
            Console.WriteLine($"Cумма корней = {sum}");
            Console.WriteLine($"Корни {a}, {b}, {c}");
        }
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("   Выберите задание: ");
                Console.WriteLine("1. Находит во введенном диапазоне натуральных чисел те, которые являются квадратами других чисел");
                Console.WriteLine("2. Статические методы для подсчета площадей фигур с одинаковым именем");
                Console.WriteLine("3. Функция должна находить наименьшую цифру целого десятичного числа");
                Console.WriteLine("4. Частное от деления произведений четных и нечетных цифр четырехзначного натурального числа");
                Console.WriteLine("5. Cумма корней квадратного уравнения");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
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
                Console.WriteLine("1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
