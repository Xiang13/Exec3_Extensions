using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		/*
		* 寫擴充方法三步驟
		* 1. 宣告 static class, 名稱不重要
		* 2. 將 method 宣告成 static method (在 static class 裡, 其實也只能宣告 static)
		* 3. 針對第一個參數, 加 this
		*/
		static void Main(string[] args)
		{
			int defaultValue = -1;
			string msg = "1234";
			int result = msg.ToInt(defaultValue);
			Console.WriteLine(result);
			
		}
		
	}
	public static class MyInt
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool success = int.TryParse(value, out int number);
			int isInt = success ? number : defaultValue;
			return isInt;
		}

	}
}
