
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class MainClass
	{
		//create class
		class Student
		{
			//added data
			public string name;
			public string surname;
			public int age;
			public double GPA;
			//create a constuctor with the same name as the class to initialize the data members of the new object
			public Student(string name, string surname, int age)
			{
				//"this." to qualify members hidden by similiar names
				this.name = name;
				this.surname = surname;
				this.age = age;
			}
			//create a constructor for two data members
			public Student(string name, double GPA)
			{
				this.name = name;
				this.GPA = GPA;
			}
			//this method use to return a string representation of object
			public override string ToString()
			{
				//return as a string 
				return name + " " + surname + " " + age+" "+GPA;  
			}
		}
		public static void Main(string[] args)
		{
			//create a new variables
			Student a = new Student("Abylay", "Batyrbek", 18);
			a.GPA =4.0;
			Student b = new Student("Malika", 4.0);
			b.surname = "Batyrbek";
			b.age = 17;
			//display it with method ToString()
			Console.WriteLine(a);
			Console.WriteLine(b);
			//window will not close until we press any key
			Console.ReadKey();
		}
	}
}
