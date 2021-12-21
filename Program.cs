
using System;
using System.Collections.Generic;

namespace f_test_zone_csharp
{
	public class Person
	{
		public Person(int age, string name, DateTime bDate, double height) {
			this.Age = age;
			this.Name = name;
			this.Bdate = bDate;
			this.Height = height;
		}
		public int Age { get; set; }
		public string Name { get; set; }
		public DateTime Bdate { get; set; }
		public double Height { get; set; }
	}

	public class Lists
	{
		public List<Person> MenList { get; set; }
	}


	class Program
	{
		static void Main(string[] args)
		{
			string dateString = "Wed Dec 30, 2015";
			DateTime dateTime = DateTime.Parse(dateString);
			
			string dateString1 = "Wed Dec 30, 2015";
			DateTime dateTime1 = DateTime.Parse(dateString1);
			
			string dateString2 = "Wed Dec 30, 2015";
			DateTime dateTime2 = DateTime.Parse(dateString2);

			Person person1 = new Person(23, "Clara", dateTime, 1.85);
			Person Person2 = new Person(52, "Mike", dateTime1, 1.9);
			Person Person3 = new Person(16, "Jen", dateTime2, 1.75);

			Console.WriteLine(person1.Age);

		}
	}
}
