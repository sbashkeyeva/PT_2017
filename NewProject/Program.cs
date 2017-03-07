using System;
using System.IO;
namespace NewProject
{
	class MainClass
	{
		public static bool isPrime(int n)
		{
			for (int i = 2; i < n; i++)
			{
				if (n % i == 0) return false;
			}
			if (n == 1) return false;
			if (n == 2) return true;
			return true;
		}
		public static void File()
		{
			StreamReader sr = new StreamReader(@"/Users/symbatbashkeyeva/Documents/in/input.txt");
			StreamWriter sw = new StreamWriter(@"/Users/symbatbashkeyeva/Documents/in/output.txt");
			string[] arr = sr.ReadLine().Split();
			int min = 320000;
			foreach (string p in arr)
			{
				int a = int.Parse(p);
				if (a < min && isPrime(a))
					min = a;
			}
			sw.WriteLine("The smallest prime number is " + min);
			sr.Close();
			sw.Close();

		}
		public static void Main(string[] args)
		{
			File();
			Console.ReadKey();
		}
	}
}
