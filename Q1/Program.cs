using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool isOdd;
			bool isEven;

			Func<int, bool> isFuncOdd = n => n % 2 == 1;
			Func<int, bool> isFuncEven = n => n % 2 == 0;

			isOdd = number(55, isFuncOdd);
			isEven = number(55, isFuncEven);

			bool result = 55.isOdd();
			result = 55.isEven();
		}

		static bool number(int num, Func<int, bool> func)
		{
			return func(num);
		}
	}
	public static class Mymath
	{
		public static bool isOdd(this int num)
		{
			return num % 2 == 1;
		}
		public static bool isEven(this int num)
		{
			return num % 2 == 0;
		}
	}
}
