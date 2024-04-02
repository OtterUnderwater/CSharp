using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library9Delegates
{
	delegate void СharDelegate(char simbol); //Объявление делегата
	internal class NewSimbol
	{
		public char simbol;
		public void SetChar(char simbol)
		{
			this.simbol = simbol;
		}
	}
}