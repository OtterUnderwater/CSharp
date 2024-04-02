using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library9Delegates
{
	delegate double SumRoots(double a, double b, double c);
	internal class QuadraticEquation
	{
		/// <summary>
		///  Экземпляр делегата с анонимным методом
		/// </summary>
		public SumRoots getSumRoots = delegate (double a, double b, double c)
		{
			double D = Math.Pow(b,2) - 4 * a * c;
			if (D < 0)
			{
				return 0; // Нет корней
			}
			else
			{
				double root1 = (-b + Math.Sqrt(D)) / (2 * a);
				double root2 = (-b - Math.Sqrt(D)) / (2 * a);
				return root1 + root2;
			}
		};

		/// <summary>
		/// Экземпляр делегата с лямда-выражением
		/// </summary>
		public SumRoots getSumRootsLambda = (a, b, c) =>
		{
			double D = Math.Pow(b, 2) - 4 * a * c;
			if (D < 0)
			{
				return 0; // Нет корней
			}
			else
			{
				double root1 = (-b + Math.Sqrt(D)) / (2 * a);
				double root2 = (-b - Math.Sqrt(D)) / (2 * a);
				return root1 + root2;
			}
		};
	}
}
