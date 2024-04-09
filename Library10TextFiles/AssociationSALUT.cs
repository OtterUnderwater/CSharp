using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using System;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Library10TextFiles
{
    struct Participants //структура участников
    {
        public string name;
        public int quantity;
        public int min;
        public int sec;
        public int top;
        public Participants(string name, int quantity, int min, int sec, int top)
        {
            this.name = name;
            this.quantity = quantity;
            this.min = min;
            this.sec = sec;
            this.top = top;
        }
    }
    public class AssociationSALUT
    {
        List<string>? listPerson = new List<string>();
        internal List<Participants> ListP { get => listP; set => listP = value; }
        List<Participants> listP = new List<Participants>();
        internal List<Participants> Person { get => person; set => person = value; }
        List<Participants> person = new List<Participants>();
        public void TopParticipants()
        {
            string path = @"files/result.txt";
            string pathTop = @"files/top.txt";
            ReadFiles(path);
            GetParticipants();
            WriteFile(pathTop);
        }

        /// <summary>
        /// Считывает данные из файла в массив строк
        /// </summary>
        /// <param name="path"></param>
        private void ReadFiles(string path)
        {
            // Чтение в потоке. using закроет файл после считывания
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    listPerson.Add(line);
                }
            }
        }

        /// <summary>
        /// Парсит полученные данные в коллекцию структур
        /// </summary>
        private void GetParticipants()
        {
            Participants P = new Participants();
            for (int i = 0; i < listPerson.Count; i++)
            {
                if (i % 2 == 0) //четные строки имена
                {
                    int index = listPerson[i].Length - 1;
                    P.name = listPerson[i].Remove(index);
                }
                else
                {
                    P.quantity = 0;
                    P.min = 0;
                    P.sec = 0;
                    List<int> tempData = new List<int>();
                    char[] splitter = { ' ', ':' };
                    string[] parts = listPerson[i].Split(splitter); //парсим данные в лист
                    for (int j = 0; j < parts.Length; j++)
                    {
                        tempData.Add(Convert.ToInt32(parts[j]));
                    }
                    for (int j = 0, position = 1; j < tempData.Count; j++, position++)
                    {
                        if (position == 1)
                        {
                            P.quantity += tempData[j];
                        }
                        else if (position == 2)
                        {
                            P.min += tempData[j];
                        }
                        else
                        {
                            P.sec += tempData[j];
                            position = 0;
                        }
                    }
                    P.min = P.min + (P.sec) / 60;
                    P.sec = P.sec % 60;
                    ListP.Add(P); //Добавляем в коллекцию
                }
            }
        }

        /// <summary>
        /// Сортирует и записывает результаты в файл
        /// </summary>
        private void WriteFile(string pathTop)
        {
            Person = ListP.OrderByDescending(p => p.quantity).ThenBy(p => p.min).ThenBy(p => p.sec).ToList<Participants>();
            int t = 1;
            for (int p = 0; p < Person.Count - 1; p++, t++)
            {
                //cравниваем участников прошедших условие отбора и присваиваем места
                if (Person[p].quantity == Person[p + 1].quantity)
                {
                    if (Person[p].min == Person[p + 1].min)
                    {
                        while (Person[p].sec == Person[p + 1].sec)
                        {
                            SetPerson(p, t); p++;
                            SetPerson(p, t);
                        }
                        if (person[p].sec != person[p + 1].sec)
                        {
                            SetPerson(p, t);
                        }
                    }
                    else SetPerson(p, t);
                }
                else SetPerson(p, t);
            }
            SetPerson(Person.Count - 1, t);
            Console.WriteLine("Рейтинг участников САЛюТ:");
            for (int i = 0; i < Person.Count; i++)
            {
                Console.WriteLine($"{Person[i].name} {Person[i].quantity} {Person[i].min}:{Person[i].sec} - {Person[i].top}");
            }
            Console.WriteLine("Результаты соревнований были запиисаны в файл top.txt\n");
            using (StreamWriter writer = new StreamWriter(pathTop, false))
            {
                //false перезаписывает файл, true добавляет
                foreach (Participants p in Person)
                {
                    writer.WriteLine($"{p.name} {p.quantity} {p.min}:{p.sec} - {p.top}");
                }
            }
        }

        /// <summary>
        /// Присваивание значения листу person
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        public void SetPerson(int p, int t)
        {
            Person[p] = new Participants(Person[p].name, Person[p].quantity, Person[p].min, Person[p].sec, t);
        }
    }
}