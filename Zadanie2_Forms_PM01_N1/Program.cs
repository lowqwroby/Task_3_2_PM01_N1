using System;

namespace Variant10
{
	class Program
	{
		static double f(double x)
		{
			double y;
			if ((x + 2) <= 1) y = x * x;
			else if (1 < (x + 2) && (x + 2) < 10) y = 1 / (x + 2);
			else if ((x + 2) >= 10) y = x + 2;
			else return 0.0;
			return y;
		}

		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите а: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите b: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите шаг h: ");
				double h = Convert.ToDouble(Console.ReadLine());

				for(double i = a; i <= b; i += h)
				{
					Console.WriteLine("f({0:f2}) = {1:f4}", i, f(i));
				}
			}
			catch
			{
				Console.WriteLine("Введены некорректные данные.");
			}
		}
	}
}