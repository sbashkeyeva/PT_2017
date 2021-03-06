﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Week5_Snake
{
	public class Wall
	{
		List<Point> body;
		public char sign = 'o';
		public ConsoleColor color;

		public Wall(int level)
		{
			body = new List<Point>();
			color = ConsoleColor.Blue;
			DirectoryInfo d = new DirectoryInfo("");
			StreamReader sr = new StreamReader("wall.txt");
			int n = int.Parse(sr.ReadLine());
			for (int i = 0; i < n; i++)
			{
				String s = sr.ReadLine();
				for (int j = 0; j < s.Length; j++)
				{
					if (s[j] == '*')
						body.Add(new Point(j, i));
				}
			}
			sr.Close();
		}
		public void Draw()
		{
			Console.ForegroundColor = color;
			foreach (Point p in body)
			{
				Console.SetCursorPosition(p.x, p.y);
				Console.Write(sign);
			}
		}
	}
}