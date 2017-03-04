using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week5_Snake
{
	public class Snake
	{
		public List<Point> body;
		public char sign = '*';
		public ConsoleColor color;
		public int cnt;

		public Snake()
		{
			body = new List<Point>();
			body.Add(new Point(10, 10));
			color = ConsoleColor.Yellow;
			cnt = 0;

		}

		public void Move(int dx, int dy)
		{
			cnt++;
			if (cnt % 10 == 0)
			{
				body.Add(new Point(0, 0));
			}
			for (int i = body.Count - 1; i > 0; i--)
			{
				body[i].x = body[i - 1].x;
				body[i].y = body[i - 1].y;
			}
			body[0].x += dx;
			body[0].y += dy;
			if (body[0].x > Console.WindowWidth - 5)
				body[0].x = 1;
			if (body[0].x < 1)
				body[0].x = Console.WindowWidth - 5;

			if (body[0].y > Console.WindowHeight - 5)
				body[0].y = 1;
			if (body[0].y < 1)
				body[0].y = Console.WindowHeight - 5;

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