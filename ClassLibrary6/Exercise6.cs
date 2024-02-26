

namespace ClassLibrary6
{
    public class Exercise6
    {
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("\tВыберите задание:");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Символ");
                Console.WriteLine("2. Массив");
                Console.WriteLine("3. Тюльпаны");
                Console.WriteLine("4. Кости");
                Console.WriteLine("5. Двоичная система");
                Console.WriteLine("6. Доп. задание");
                Console.WriteLine("----------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("Введите символ: ");
                        char c = Convert.ToChar(Console.ReadLine());
                        Class1 obj1 = new Class1();
                        obj1.Symbol = c;
                        Console.WriteLine($"Символ = {obj1.Symbol}");
                        break;
                    case 2:
                        Console.Write("Введите количество элементов массива: ");
                        Class2 obj2 = new Class2(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"Сумма всех элементов массива = {obj2.Sum}");
                        break;
                    case 3:
                        Class3 obj3 = new Class3();
                        Console.Write("Введите цену одного тюльпана: ");
                        obj3.Сost = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите количество тюльпанов: ");
                        obj3.Tulip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Стоимость тюльпанов = {obj3.Price}");
                        break;
                    case 4:
                        Class4 obj4 = new Class4();
                        Console.Write("Введите сколько выпало на 1 кости: ");
                        obj4.Dice1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите сколько выпало на 2 кости: ");
                        obj4.Dice2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(obj4.Result);
                        break;
                    case 5:
                        Class5 obj5 = new Class5();
                        Console.Write("Введите неотрицательное целое число: ");
                        obj5.Num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Бинарный код данного числа = {obj5.Text}");
                        break;
                    case 6:
                        Console.WriteLine($"Вызов 1: Число = {Class6.NumGet}");
                        Console.WriteLine($"Вызов 2: Число = {Class6.NumGet}");
                        Console.WriteLine($"Вызов 3: Число = {Class6.NumGet}");
                        Console.Write("Введите число: ");
                        Class6.Num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Вызов 1: Число = {Class6.NumGet}");
                        Console.WriteLine($"Вызов 2: Число = {Class6.NumGet}");
                        Console.WriteLine($"Вызов 3: Число = {Class6.NumGet}");
                        break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("\n1 - Выбрать другое задание, 0 - Назад.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}
