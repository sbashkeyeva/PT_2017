using System;

namespace PrimeNumber
{
	class MainClass
	{
		//function for checking a number to determine whether a number is a prime or not
		static bool isPrime(int n)
		{
			//to define whether 'n' is divided into 'i'
			for (int i = 2; i < n; i++)
			{
				//it is not a prime number, a program has to finish cycle
				if (n % i == 0) return false;
			}
			if (n == 1) return false;
			if (n == 2) return true;
			return true;
		}
		public static void Main(string[] args)
		{
			//enter data
			string b = Console.ReadLine();
			//rewrite elements from string b to array arr
			string[] arr = b.Split();
			for (int i = 0; i < arr.Length; i++)
			{
				//to assign each element of the array to a string
				string a = arr[i];
				//to cinvert string to integer
				int r = int.Parse(a);
				//check it whether it is a prime number or not
				if (isPrime(r) == true)
					//display it
					Console.WriteLine(r);
			}
			//program will not finish until we press any key
			Console.ReadKey();
		}
	}
}
