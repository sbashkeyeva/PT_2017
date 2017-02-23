
using System;
using System.IO;

namespace MaxMin
{
	class MainClass
	{
		//create a function to find min and max in array
		public static void File()
		{
			//read from input.txt the datas
			StreamReader sr = new StreamReader(@"/Users/symbatbashkeyeva/Documents/s");
			//a string array that contains the substring of this intance, separated by "_"
			string[] arr = sr.ReadLine().Split();
			int min = 1000000;//giving large number to check min
			int max = 0;//giving small number to check min
			foreach (string s in arr) //converting array to string
			{
				int a = int.Parse(s); //converting string to integer
				//checks every number in array
				if (a < min)
				{
					min = a;
				}
				//checks every number in array for maximum
				if (a > max)
				{
					max = a;
				}
			}
			Console.WriteLine("minimum number is " + min);
			Console.WriteLine("maximum number is" + max);
			sr.Close();
		}
		public static void Main(string[] args)
		{
			//call a function 
			File();
			//window will not close until we don't press any key 
			Console.ReadKey();	
		}
	}
}
