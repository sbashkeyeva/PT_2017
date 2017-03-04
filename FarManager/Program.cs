using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FarManager
{
	class MainClass
	{
		static void GettingInfo(DirectoryInfo directory, int cursor)
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			int index = 0;
			foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos())
			{
				if (index == cursor)
					Console.ForegroundColor = ConsoleColor.Red;
				else
					Console.ForegroundColor = ConsoleColor.Yellow;
				index++;
				if (fInfo.GetType() == typeof(FileInfo))
					Console.Write("File: ");
				else 
					Console.Write("Directory: ");
				Console.WriteLine(fInfo.Name);
			}
		}
		public static void Main(string[] args)
		{
			//initialixe the datas
			int cursor = 0;
			DirectoryInfo directory = new DirectoryInfo("@/Users/symbatbashkeyeva/Documents");
			while (true)
			{
				Console.Clear(); //to clear a window when another folder was opened
				GettingInfo(directory, cursor); //call function to display folders and files
				ConsoleKeyInfo pressedKey = Console.ReadKey();
				if (pressedKey.Key == ConsoleKey.UpArrow)
					if (cursor > 0)
						cursor--;
				if (pressedKey.Key == ConsoleKey.DownArrow)
					if (cursor < directory.GetFileSystemInfos().Length - 1)
						cursor++;
				if (pressedKey.Key == ConsoleKey.Enter)
				{
					FileSystemInfo fi = directory.GetFileSystemInfos()[cursor]; //create a FileSystemInfo cause we are not informed which type of element is it
					//if it is a folder, open folders in this folder
					if (fi.GetType() == typeof(DirectoryInfo)) //function GetType() is used to identify type of the element 
						directory = new DirectoryInfo(fi.FullName);
					else
					{
						//read from this file datas 
						StreamReader sr = new StreamReader(fi.FullName);
						Console.Clear(); //to clear a window with another folder was opened
						Console.WriteLine(sr.ReadToEnd()); //display this datas on console
						sr.Close();
						Console.ReadKey();
					}
				}
				if (pressedKey.Key == ConsoleKey.Backspace)
				{
					try
					{
						directory = Directory.GetParent(directory.FullName); //go back to the previous folder
					}
					catch (Exception e)
					{
						Console.WriteLine("Error");
					}
				}
				if (pressedKey.Key == ConsoleKey.Escape)
					break;
			}
		}
	}
}
