using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using System;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace Library10TextFiles
{
	struct Participants //структура участников
	{
		public string name;
		public int quantity;
		public int min;
		public int sec;
		public int top;
	}

	public class AssociationSALUT
	{
		List<string>? listPerson = new List<string>();
		List<Participants> listP = new List<Participants>();

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
					listP.Add(P); //Добавляем в коллекцию
				}
			}
		}

		/// <summary>
		/// Сортирует и записывает результаты в файл
		/// </summary>
		private void WriteFile(string pathTop)
		{
			List<Participants> temp2 = listP.OrderByDescending(p => p.quantity).ThenBy(p => p.min).ThenBy(p => p.sec).ToList<Participants>();
			int index = 0;
			List<Participants> temp = temp2.Select(p =>
			{
				p.top = index + 1;
				index++;
				return p;
			}).ToList<Participants>();
			Console.WriteLine("Рейтинг участников САЛюТ:");
			for (int i = 0; i < temp.Count; i++)
			{
				Console.WriteLine($"{temp[i].name} {temp[i].quantity} {temp[i].min}:{temp[i].sec} - {temp[i].top}");
			}
			Console.WriteLine("Результаты соревнований были запиисаны в файл top.txt\n");
			using (StreamWriter writer = new StreamWriter(pathTop, false))
			{
				//false перезаписывает файл а не добавляет, true добавляет
				foreach (Participants P in temp)
				{
					writer.WriteLine($"{P.name} {P.quantity} {P.min}:{P.sec} - {P.top}");
				}
			}
		}
	}
}