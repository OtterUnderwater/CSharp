using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BaseClass3
    {
        protected int[] nums;
        public BaseClass3(int n)
        {
            Random random = new Random();
            nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = random.Next(0, 50);
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }

        public virtual void FindEl()
        {
            int maxEl = 0;
            int count = 0;
            foreach (int num in nums)
            {
                if (num > maxEl)
                { 
                    maxEl = num;
                }
            }
            foreach (int num in nums)
            {
                if (num == maxEl)
                {
                    count++;
                }
            }
            Console.WriteLine($"Максимальный элемент: {maxEl} - встречается {count} раз");
        }
    }

    internal class NewClass3 : BaseClass3
    {
        public NewClass3(int n): base(n){}

        public override void FindEl()
        {
            int minEl = nums[0];
            int count = 0;
            foreach (int num in nums)
            {
                if (num < minEl)
                {
                    minEl = num;
                }
            }
            foreach (int num in nums)
            {
                if (num == minEl)
                {
                    count++;
                }
            }
            Console.WriteLine($"Минимальный элемент: {minEl} - встречается {count} раз");
        }
    }
}
