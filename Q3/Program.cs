using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		// 針對 string 寫一個擴充方法 ToInt(this string value, int defaultValue)
		// 可以將 string 轉換成 int 型別, 如果無法轉型成功, 傳回 defaultValue
		static void Main(string[] args)
		{
			int defaultValue = -1;
			string msg = "1234";
			msg = "ASD";
			int result = msg.Toint(defaultValue);
			Console.WriteLine(result);
		}
	}
	public static class MyString
	{
		public static int Toint(this string value, int defaultValue)
		{
			int number;
			bool success = int.TryParse(value, out number);
			int isInt = success ? number : defaultValue;
			return isInt;
		}
	}
}
