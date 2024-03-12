using Other;
using Library1_4Basics;
using Library5Class;
using Library6Properties;
using Library7Inheritance;

namespace ConsoleCSharp
{
    class MainClass
    {
        static void Main()
        {
            Other.InputControl IC = new InputControl();
            Other.RemoteControl1 RC1 = new RemoteControl1();
            Library1_4Basics.StaticMethods1 E1 = new StaticMethods1();
            Library1_4Basics.Arrays2 E2 = new Arrays2();
            Library1_4Basics.Strings3 E3 = new Strings3();
            Library1_4Basics.ExceptionHandling4 E4 = new ExceptionHandling4();
            Library5Class.Exercise5 E5 = new Exercise5();
            Library6Properties.Exercise6 E6 = new Exercise6();
            Library7Inheritance.Exercise7 E7 = new Exercise7();
            int n, end;
            do
            {
                Console.WriteLine("\tВыберите тему:");
                Console.WriteLine("---------------------------");
                Console.WriteLine("0. Входной контроль");
                Console.WriteLine("1. Статические методы");
                Console.WriteLine("2. Массивы");
                Console.WriteLine("3. Работа со строками");
                Console.WriteLine("4. Обработка исключений");
                Console.WriteLine("5. Классы и объекты");
                Console.WriteLine("6. Свойства");
                Console.WriteLine("7. Наследование");
                Console.WriteLine("8. Абстрактные классы и интерфейсы");
                Console.WriteLine("9. ???");
                Console.WriteLine("101. Задачи Дистант");
                Console.WriteLine("---------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0: IC.Call(); break;
                    case 1: E1.Call(); break;
                    case 2: E2.Call(); break;
                    case 3: E3.Call(); break;
                    case 4: E4.Call(); break;
                    case 5: E5.Call(); break;
                    case 6: E6.Call(); break;
                    case 7: E7.Call(); break;
                    case 101: RC1.Call(); break;
                    default: Console.WriteLine("Такой темы нет"); break;
                }
                Console.WriteLine("Поменять тему? (1 - да, 0 - нет).");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}