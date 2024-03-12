using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library5Class
{
    internal class Class1
    {
        private int sideSquare; //Сторона квадрата
        private int cathet1; //Катеты прямоугольного треугольника
        private int cathet2;

        //Конструктор 1
        public Class1()
        {
            Console.Write("Конструктор 1: ");
            Console.Write("Введите сторону квадрата: ");
            sideSquare = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1 катет прямоугольного треугольника: ");
            cathet1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 катет прямоугольного треугольника: ");
            cathet2 = Convert.ToInt32(Console.ReadLine());
        }
  
        //Конструктор 2
        public Class1(int side, int c1, int c2)
        {
            sideSquare = side;
            cathet1 = c1;
            cathet2 = c2;
        }

        //Конструктор 3
        public Class1(int c1, int c2)
        {
            cathet1 = c1;
            cathet2 = c2;
            if (c1 < c2)
            {
                sideSquare = c1;
            }
            else
            {
                sideSquare = c2;
            }
        }

        public double AreaTriangle()
        {
            double S = 0;
            S = (cathet1 * cathet2) / 2;
            return S;
        }

        public double AreaSquare()
        {
            double S = 0;
            S = Math.Pow(sideSquare, 2);
            return S;
        }
    }
}
