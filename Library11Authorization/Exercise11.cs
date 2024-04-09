namespace Library11Authorization
{
    public class Exercise11
    {
        public void Call()
        {
            int n, end;
            do
            {
                Console.WriteLine("\tВыберите функцию:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Регистрация администратора");
                Console.WriteLine("2. Регистрация пользователя");
                Console.WriteLine("3. Авторизация");
                Console.WriteLine("----------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: AuthReg.RegistrationAdmin(); break;
                    case 2: AuthReg.RegistrationUser(); break;
                    case 3: AuthReg.Authorization(); break;
                    default: Console.WriteLine("Такого задания нет"); break;
                }
                Console.WriteLine("1 - Выбрать другую функцию, 0 - В меню.");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end > 0);
        }
    }
}