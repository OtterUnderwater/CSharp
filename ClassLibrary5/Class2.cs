using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library5Class
{
    internal class Class2
    {
        private int[] array = new int[0];
        Random rand = new Random();
        public Class2(int n)
        {
            Array.Resize(ref array, n);
            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(11); //от 1 до 10
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void Min()
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Минимальный элемент массива = {min}");
        }
        public void Max()
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Максимальный элемент массива = {max}");
        }
        public void Аvg()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Среднее значение элементов массива = {sum / array.Length}");
        }
    }
}
