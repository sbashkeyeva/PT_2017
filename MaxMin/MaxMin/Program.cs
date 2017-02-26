
using System;
using System.IO;

namespace MaxMin
{
	class MainClass
	{
		public static bool isPrime(int n)
		{
			for (int i = 2; i < n; i++)
			{
				if (n % 2 == 0) return false;
				if (n == 1) return false;
				if (n == 2) return true;
				return true;
			}
		}
		public static void file()
		{
			StreamReader sr = new StreamReader(@"/Users/symbatbashkeyeva/Documents/s");
			StreamWriter sw = new StreamWriter(@"/Users/symbatbashkeyeva/Documents/b");
			string[] arr = sr.ReadLine().Split();
			int min = 320000000;
			foreach (string p in arr)
			{
				int a = int.Parse(p);
				if (isPrime(a) && a < min)
					min = a;
			}
			sw.WriteLine("The smallest prime number:" + min);
			sw.Close();
			sr.Close();
		}
		public static void Main(string[] args)
		{
			file();
			Console.ReadKey();	
		}
	}
}
