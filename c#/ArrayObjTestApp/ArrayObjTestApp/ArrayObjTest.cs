using System;


namespace ArrayObjTestApp
{
	class Student
	{
		//private data members
		private int rollno;
		private string name;
		private int age;

		//method to set student details
		public void SetInfo(string name, int rollno, int age)
		{
			this.rollno = rollno;
			this.age = age;
			this.name = name;
		}

		//method to print student details
		public void PrintInfo()
		{
			Console.WriteLine("Student Record: ");
			Console.WriteLine("\tName     : " + name);
			Console.WriteLine("\tRollNo   : " + rollno);
			Console.WriteLine("\tAge      : " + age);
		}

	}

	class Program
	{
		static void Main()
		{
			//creating array of objects
			Student[] S = new Student[2];
			//initlising objects by detauls/inbuilt constructors
			S[0] = new Student();
			S[1] = new Student();
			//reading and printing first object
			S[0].SetInfo("Kunal", 101, 22);
			S[0].PrintInfo();
			//reading and printing second object
			S[1].SetInfo("Sohan", 102, 20);
			S[1].PrintInfo();
			Console.ReadLine();
		}
	}
}
