using System;
using System.Xml.Serialization;
using System.IO;
namespace Complex
{
	class MainClass
	{
		public class Complex
		{
			public int x;
			public int y;
			public Complex(int x, int y) //constructor that initializes info
			{
				this.x = x;
				this.y = y;
			}
			public Complex() { }
			public static int gcd(int x, int y) //function that calculates gcd of two complex numbers
			{
				if (x == 0)
					return y;
				return gcd(y % x, x);
			}
			public override string ToString() //function that outputs data as a string 
			{
				return this.x + "/" + this.y;
				//return this.x / gcd(this.x, this.y) + "/" + this.y / gcd(this.x, this.y);
			}
			public static Complex operator +(Complex x, Complex y) // function overloading +
			{
				Complex c = new Complex(x.x * y.y + y.x * x.y, x.y * y.y);
				c = new Complex(c.x / gcd(c.x, c.y), c.y / gcd(c.x, c.y));
				return c;
			}
			public static Complex operator -(Complex x, Complex y) //function overloading -
			{
				Complex c = new Complex(x.x * y.y - y.x * x.y, x.y * y.y);
				c = new Complex(c.x / gcd(c.x, c.y), c.y / gcd(c.x, c.y));
				return c;
			}
			public static Complex operator *(Complex x, Complex y) //function overloading *
			{
				Complex c = new Complex(x.x * y.x, x.y * y.y);
				c = new Complex(c.x / gcd(c.x, c.y), c.y / gcd(c.x, c.y));
				return c;
			}
			public static Complex operator /(Complex x, Complex y) //function overloading /
			{
				Complex c = new Complex(x.x * y.y, y.x * x.y);
				c = new Complex(c.x / gcd(c.x, c.y), c.y / gcd(c.x, c.y));
				return c;
			}
		}
		public static void Main(string[] args)
		{
			Complex a = new Complex(1, 2);
			Complex b = new Complex(3, 4);
			Complex sum = a + b;
			FileStream fs = new FileStream("sum.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer xs = new XmlSerializer(typeof(Complex));
			xs.Serialize(fs, sum);
			fs.Close();                         
			Complex dif = a - b;
			FileStream fy = new FileStream("dif.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer xy = new XmlSerializer(typeof(Complex));
			xy.Serialize(fy, dif);
			fy.Close();
			Complex pro = a * b;
			FileStream ft = new FileStream("pro.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer xt = new XmlSerializer(typeof(Complex));
			xt.Serialize(ft, pro);
			fs.Close();
			Complex div = a / b;
			FileStream fr = new FileStream("div.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer xr = new XmlSerializer(typeof(Complex));
			xr.Serialize(fr, div);
			fr.Close();
			Console.WriteLine(sum.x + " " + sum.y);
			//show results
			//we rewrited ToString, so we can just write variables we want to output
			Console.WriteLine("Sum=" + sum);
			Console.WriteLine("Dif=" + dif);
			Console.WriteLine("Pro=" + pro);
			Console.WriteLine("Div=" + div);
			Console.ReadKey();

		}
	}
}
