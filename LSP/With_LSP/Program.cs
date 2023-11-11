using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_LSP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IFruit fruit = new Orange();
			Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
			fruit = new Apple();
			Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
			Console.ReadKey();
		}
	}
}
