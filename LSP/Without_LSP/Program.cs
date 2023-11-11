using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_LSP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Apple apple = new Orange();
			Console.WriteLine(apple.GetColor());
			Console.ReadKey();
		}
	}
}
