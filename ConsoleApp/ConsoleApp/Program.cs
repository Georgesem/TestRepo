using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "qwe qwe qwe qwe qwe qwe qew qwe qwe qew qew qwe qwe qwe qwe qwe qe";
			string[] words = str.Split(' ');
			Console.WriteLine("колличество слов в стоке " + str + " - " + words.Length);
		}
	}
}
