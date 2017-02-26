using System;
using System.IO;
namespace Recursion
{
	class MainClass
	{
		static void emptySpace(int level) //function that displays 2*spaces where you apply it 
		{
			for (int i = 0; i < level * 2; i++)
			{
				Console.WriteLine("-");
			}
		}
		static void Ex2(string path, int level) //function that opens directories and files recursively 
		{
			if (level > 2)
				return; //outputing only with 2 empty space 
			try
			{
				//Getting directories 
				DirectoryInfo directory = new DirectoryInfo(path);
				DirectoryInfo[] directories = directory.GetDirectories();
				//Getting files 
				FileInfo[] files = directory.GetFiles();
				Console.WriteLine("Files:" + directory.GetFiles().Length); //showing number of files in directories
				foreach (FileInfo file in files)
				{
					emptySpace(level); //getting names of files 
					Console.WriteLine(file.Name);
				}
				Console.WriteLine("Directories:" + directories.Length); //showing number of directories in directories
				foreach (DirectoryInfo dInfo in directories)
				{
					//getting the fullname
					emptySpace(level);
					Console.WriteLine(dInfo.Name);
					Ex2(dInfo.FullName, level + 1); //applying func to open directories in directories
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error");
			}
		}
		public static void Main(string[] args)
		{
			Ex2(@"/Users/symbatbashkeyeva/Documents",0);
			Console.ReadKey();
		}
	}
}
