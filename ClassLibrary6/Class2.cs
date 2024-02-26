using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    internal class Class2
    {
        int[] numbers = new int[0];
        Random rand = new Random();
        public Class2(int n)
        {
            Array.Resize(ref numbers, n);
            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rand.Next(101); //от 1 до 100
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                return sum;
            }
        }
    }
}
