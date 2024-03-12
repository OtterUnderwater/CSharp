
namespace Library5Class
{
    public class Exercise5
    {
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1. Площади");
                Console.WriteLine("2. Массив");
                Console.WriteLine("3. Числа");
                Console.WriteLine("4. Годы");
                Console.WriteLine("5. Перевод из 10 в 16 систему счисления");
                Console.WriteLine("----------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("Введите сторону квадрата: ");
                        int side = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите 1 катет прямоугольного треугольника: ");
                        int c1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите 2 катет прямоугольного треугольника: ");
                        int c2 = Convert.ToInt32(Console.ReadLine());
                        Class1 obj1 = new Class1();
                        Class1 obj2 = new Class1(side, c1, c2);
                        Class1 obj3 = new Class1(c1, c2);
                        //Подсчет площадей
                        Console.WriteLine("Конструктор 1: ");
                        Console.WriteLine($"Площадь прямоугольного треугольника = {obj1.AreaTriangle()}");
                        Console.WriteLine($"Площадь квадрата = {obj1.AreaSquare()}");
                        Console.WriteLine("Конструктор 2: ");
                        Console.WriteLine($"Площадь прямоугольного треугольника = {obj2.AreaTriangle()}");
                        Console.WriteLine($"Площадь квадрата = {obj2.AreaSquare()}");
                        Console.WriteLine("Конструктор 3: ");
                        Console.WriteLine($"Площадь прямоугольного треугольника = {obj3.AreaTriangle()}");
                        Console.WriteLine($"Площадь квадрата = {obj3.AreaSquare()}");
                        break;
                    case 2:
                        Console.Write("Введите количество элементов массива: ");
                        Class2 mass = new Class2(Convert.ToInt32(Console.ReadLine()));
                        mass.Min();
                        mass.Max();
                        mass.Аvg();
                        break;
                    case 3:
                        Console.Write("Введите символ: ");
                        char simbol = Convert.ToChar(Console.ReadLine());
                        Console.Write("Введите целое число: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите дробное число: ");
                        double dr = Convert.ToDouble(Console.ReadLine());
                        Class3 objOk = new Class3(simbol, num);
                        Class3 objOk2 = new Class3(dr);
                        Console.WriteLine("Значение полей 1 конструктора:");
                        Console.WriteLine($"Символ = {objOk.simbol}, число = {objOk.num}");
                        Console.WriteLine("Значение полей 2 конструктора:");
                        Console.WriteLine($"Символ = {objOk2.simbol}, число = {objOk2.num}");
                        break;
                    case 4:
                        Console.Write("Введите год: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Class4.MetodSet(year);
                        Class4.DayYear();
                        break;
                    case 5:
                        Console.Write("Введите десятичное число: ");
                        int decimal10 = Convert.ToInt32(Console.ReadLine());
                        Class5 obj5 = new Class5(decimal10);                   
                        obj5.Result();
                        break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
