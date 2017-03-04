using System;
using System.IO;

namespace lab 
{
	class MainClass
	{
		static void emptySpace(int level)
		{
			for (int i = 0; i < 2 * level;i++)
			{
				Console.WriteLine("-");
			}
		}
		static void File(string path, int level)
		{
			try
			{
				DirectoryInfo directory = new DirectoryInfo(path);
				DirectoryInfo[] directories = directory.GetDirectories();
				FileInfo[] files = directory.GetFiles();
				Console.WriteLine("files:" + directory.GetFiles().Length);
				foreach (FileInfo file in files)
				{
					emptySpace(level);
					Console.WriteLine(file.Name);
				}
				foreach (DirectoryInfo dInfo in directories)
				{
					emptySpace(level);
					Console.WriteLine(dInfo.Name);
					//File(dInfo.FullName, level + 1);
				}

			}
			catch (Exception e)
			{
				Console.WriteLine("Error");
			}
		}
		public static void Main(string[] args)
		{
			File(@"/Users/symbatbashkeyeva/Documents",0);
			Console.ReadKey();
			
		}
	}
}
