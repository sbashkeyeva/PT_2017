using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Far
{
	class Program
	{
		static void ShowInfo(DirectoryInfo directory, int cursor) //function to show folders and files
		{
			// Console.BackgroundColor = ConsoleColor.Black;
			int index = 0;
			foreach (FileSystemInfo finfo in directory.GetFileSystemInfos())
			{
				//Console.WriteLine(finfo.Name);
				if (index == cursor)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
				}
				index++;
				if (finfo.GetType() == typeof(FileInfo))
				{
					Console.Write("File:");
				}
				else
					// Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Directory:");
				Console.WriteLine(finfo.Name);
			}
		}
		static void Main(string[] args)
		{
			int cursor = 0;
			DirectoryInfo directory = new DirectoryInfo(@"/Users/symbatbashkeyeva/Documents");
			while (true)
			{
				Console.CursorVisible = false;
				Console.Clear();
				ShowInfo(directory, cursor);
				ConsoleKeyInfo pressed = Console.ReadKey();
				if (pressed.Key == ConsoleKey.UpArrow)
				{
					if (cursor > 0)
					{
						cursor--;
					}

				}
				if (pressed.Key == ConsoleKey.DownArrow)
				{
					if (cursor < directory.GetFileSystemInfos().Length - 1)
					{
						cursor++;
					}
				}
				if (pressed.Key == ConsoleKey.Enter)
				{
					FileSystemInfo file = directory.GetFileSystemInfos()[cursor];
					if (file.GetType() == typeof(DirectoryInfo))
					{
						directory = new DirectoryInfo(file.FullName);
					}
					else
					{
						Process.Start(file.FullName);
					}

				}

				if (pressed.Key == ConsoleKey.Backspace)
				{
					try
					{
						directory = Directory.GetParent(directory.FullName);
					}
					catch (Exception e)
					{
						Console.WriteLine("Error");
					}
					if (pressed.Key == ConsoleKey.Escape)
					{
						break;
					}
				}
			}
		}
	}
}