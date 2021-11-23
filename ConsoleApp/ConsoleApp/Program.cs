using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ВВедите строку");
			string str = Console.ReadLine();
			Console.WriteLine("ВВедите символ");
			string simbol = Console.ReadLine();
			
			float counter_char = 0;
			foreach ( char ch in str) {
		
				if (ch == Convert.ToChar(simbol)){
					counter_char++;
                }
            }
			float result = counter_char / str.Length * 100;
			Console.WriteLine("Процент вхождения символа " + simbol + " в строку " + str + " - " + result);
		}
	}
}
