using ConsoleApp1;

namespace Library7Inheritance
{
    public class Exercise7
    {
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("\tВыберите задание:");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1. Замещение метода");
                Console.WriteLine("2. Переопределение метода");
                Console.WriteLine("3. Переопределение поиска макс. эл.");
                Console.WriteLine("4. Замещение Числа Фиббоначи");
                Console.WriteLine("5. Переопределение со строками");
                Console.WriteLine("6. Доп. задание");
                Console.WriteLine("---------------------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Введите строку:");
                        string str = Console.ReadLine();
                        Console.WriteLine("Введите число:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        NewClass newClass = new NewClass(str, num);
                        newClass.Show();
                        break;
                    case 2:
                        Console.WriteLine("Введите строку:");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Введите число:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите вторую строку:");
                        char ch = Convert.ToChar(Console.ReadLine());
                        BaseClass2 baseClass2 = new BaseClass2(str2);
                        baseClass2.Show();
                        NewClass1 newClass1 = new NewClass1(str2, num2);
                        newClass1.Show();
                        NewClass2 newClass2 = new NewClass2(str2, ch);
                        newClass2.Show();
                        break;
                    case 3:
                        Console.WriteLine("Введите число:");
                        int lenArray = Convert.ToInt32(Console.ReadLine());
                        BaseClass3 baseClass3 = new BaseClass3(lenArray);
                        baseClass3.FindEl();
                        NewClass3 newClass3 = new NewClass3(lenArray);
                        newClass3.FindEl();
                        break;
                    case 4:
                        Console.WriteLine("Введите 2 числа:");
                        int baseNum = Convert.ToInt32(Console.ReadLine());
                        int newNum = Convert.ToInt32(Console.ReadLine());
                        BaseClass4 baseClass4 = new BaseClass4(baseNum);
                        baseClass4.FibonacciNumber();
                        NewClass4 newClass4 = new NewClass4(baseNum, newNum);
                        newClass4.FibonacciNumber();
                        break;
                    case 5:
                        Console.WriteLine("Введите 3 строки:");
                        string text1 = Console.ReadLine();
                        string text2 = Console.ReadLine();
                        string text3 = Console.ReadLine();
                        BaseClass5 baseClass5 = new BaseClass5(text1);
                        Console.WriteLine(baseClass5.GetText());
                        NewClass5 newClass5 = new NewClass5(text1, text2);
                        Console.WriteLine(newClass5.GetText());
                        newClass5.SplitText(text3);
                        Console.WriteLine(newClass5.GetText());
                        Console.WriteLine(newClass5);
                        break;
                    case 6:
                        Console.WriteLine("Введите число и разряд:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int discharge = Convert.ToInt32(Console.ReadLine());
                        BaseClass6 baseClass6 = new BaseClass6();
                        baseClass6.ReadNumber();
                        Console.WriteLine($"Базовый класс: {baseClass6.number}");

                        NewClass6 newClass6 = new NewClass6();
                        newClass6.ReadNumber(number, discharge);
                        Console.WriteLine("Производный класс:");
                        Console.WriteLine($"Число базового: {newClass6.number} ");
                        Console.WriteLine($"Число производного: {newClass6.number2} ");
                        newClass6.ReadNumber();
                        Console.WriteLine("Производный класс:");
                        Console.WriteLine($"Число базового: {newClass6.number} ");
                        Console.WriteLine($"Число производного: {newClass6.number2} ");
                        break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
