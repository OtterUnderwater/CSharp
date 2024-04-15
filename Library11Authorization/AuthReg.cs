using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library11Authorization
{
    struct User //структура пользователей
    {
        public int id;
        public string surname;
        public string name;
        public int age;
        public string login;
        public string password;
        public int role; //1 - администратор или 2 - пользователь
        public User(int id, string surname, string name, int age, string login, string password, int role)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.age = age;
            this.login = login;
            this.password = password;
            this.role = role;
        }
    }

	internal class AuthReg
    {
        static internal List<User> ListUser { get => listUser; set => listUser = value; }
        static List<User> listUser = new List<User>();

        static string directory = @"files\";
        static string path = directory + "User.csv";
        static User newUser = new User();
        static int id => CountList();

        /// <summary>
        /// Возвращает количество строк + 1
        /// </summary>
        /// <returns></returns>
        static public int CountList()
        {
            int count = 1;
            if (File.Exists(path))
            {
				ReadFileCsv();
				count = ListUser.Count + 1;
			}
			return count;
        }

        /// <summary>
        /// Регистрация администратора
        /// </summary>
        static public void RegistrationAdmin()
        {
            Registration(1);
            Console.WriteLine("Администратор добавлен в систему!");
        }

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        static public void RegistrationUser()
        {
            Registration(2);
            Console.WriteLine("Пользователь добавлен в систему!");
        }

        /// <summary>
        /// Регистрация в системе
        /// </summary>
        /// <param name="role"></param>
        static public void Registration(int role)
        {
            try
            {
                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                newUser = new User(id, surname, name, age, login, password, role);
                WriteFileCsv();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.GetType().Name}");
                Console.WriteLine($"Описание: {e.Source}");
                Console.WriteLine($"Строка: {e.StackTrace}");
            }
        }

        /// <summary>
        /// Запись в файл
        /// </summary>
        static public void WriteFileCsv()
        {
            Directory.CreateDirectory(directory); //создаем папку
            using (StreamWriter write = new StreamWriter(path, true, Encoding.UTF8))
            {
                write.WriteLine($"{newUser.id};{newUser.surname};{newUser.name};{newUser.age};{newUser.login};{newUser.password};{newUser.role}");
            }
        }

        /// <summary>
        /// Чтение из файла
        /// </summary>
        static public void ReadFileCsv()
		{
			ListUser.Clear();
			using (StreamReader read = new StreamReader(path, Encoding.UTF8))
            {
                while (!read.EndOfStream) // Чтение файла до конца
                {
                    string line = read.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] values = line.Split(";");
                        User user = new User()
                        {
                            id = Convert.ToInt32(values[0]),
                            surname = values[1],
                            name = values[2],
                            age = Convert.ToInt32(values[3]),
                            login = values[4],
                            password = values[5],
                            role = Convert.ToInt32(values[6]),
                        };
                        ListUser.Add(user);
                    }
                }
            }
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        static public void Authorization()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            User user = GetUserCheck(login, password);
            if (user.role == 1) //Администратор
            {
                int n, end;
                do
                {
                    Console.WriteLine("\tВыберите действие:");
                    Console.WriteLine("1. Просмотр своей учетной записи");
                    Console.WriteLine("2. Просмотр учетных записей всех пользователей");
                    Console.WriteLine("3. Просмотр данных совершеннолетних пользователей");
                    Console.WriteLine("4. Просмотр данных об определенном пользователе");
                    Console.WriteLine("5. Регистрация нового пользователя");
                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1: PrintDateUser(user); break;
                        case 2: PrintListUser(); break;
                        case 3: PrintListUserS(); break;
                        case 4:
                            Console.WriteLine("Введите имя:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите фамилию:");
                            string surname = Console.ReadLine();
                            PrintUserId(name, surname);
                            break;
                        case 5: RegistrationUser(); break;
                        default: Console.WriteLine("Такого задания нет"); break;
                    }
                    Console.WriteLine("1 - выбрать другое действие, 0 - выйти.");
                    end = Convert.ToInt32(Console.ReadLine());
                } while (end > 0);
            }
            else
            {
                PrintDateUser(user);
            }
        }

        /// <summary>
        /// Показывает всех совершеннолетних пользователей
        /// </summary>
        static public void PrintListUserS()
        {
            ReadFileCsv();
            Console.Write("Совершеннолетние пользователели:");
            for (int i = 0; i < ListUser.Count; i++)
            {
                if (ListUser[i].age >= 18)
                {
                    Console.WriteLine($"Фамилия: {ListUser[i].surname}");
                    Console.WriteLine($"Имя: {ListUser[i].name}");
                    Console.WriteLine($"Возраст: {ListUser[i].age}");
                    Console.WriteLine($"Логин: {ListUser[i].login}");
                    Console.WriteLine($"Пароль: {ListUser[i].password}");
                    Console.WriteLine($"Роль: {ListUser[i].password}");
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Показывает пользователя по фамилии и имени
        /// </summary>
        /// <param name="id"></param>
        static public void PrintUserId(string name, string surname)
        {
            ReadFileCsv();
            User user = ListUser.FirstOrDefault(u => u.name == name && u.surname == surname);
            Console.WriteLine($"Фамилия: {user.surname}");
            Console.WriteLine($"Имя: {user.name}");
            Console.WriteLine($"Возраст: {user.age}");
            Console.WriteLine($"Логин: {user.login}");
            Console.WriteLine($"Пароль: {user.password}");
        }

        /// <summary>
        /// Показывает лист пользователей
        /// </summary>
        static public void PrintListUser()
        {
            ReadFileCsv();
            Console.Write("Список пользователей:");
            for (int i = 0; i < ListUser.Count; i++)
            {
                Console.WriteLine($"Фамилия: {ListUser[i].surname}");
                Console.WriteLine($"Имя: {ListUser[i].name}");
                Console.WriteLine($"Возраст: {ListUser[i].age}");
                Console.WriteLine($"Логин: {ListUser[i].login}");
                Console.WriteLine($"Пароль: {ListUser[i].password}");
                Console.WriteLine($"Роль: {ListUser[i].password}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод информации пользователя
        /// </summary>
        /// <param name="user"></param>
        static public void PrintDateUser(User user)
        {
            Console.WriteLine($"Фамилия: {user.surname}");
            Console.WriteLine($"Имя: {user.name}");
            Console.WriteLine($"Возраст: {user.age}");
            Console.WriteLine($"Логин: {user.login}");
            Console.WriteLine($"Пароль: {user.password}");
        }

        /// <summary>
        /// Проверка существования пользователя в БД
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public User GetUserCheck(string login, string password)
        {
            ReadFileCsv();
            User user = ListUser.FirstOrDefault(u => u.login == login && u.password == password);
            return user;
        }
    }
}
