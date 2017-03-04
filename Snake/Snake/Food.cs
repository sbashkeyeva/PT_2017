using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week5_Snake
{
	public class Food
	{
		public Point location;
		List<Point> body;
		public char sign = '♠';
		public ConsoleColor color;

		public Food()
		{
			body = new List<Point>();
			color = ConsoleColor.DarkRed;
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