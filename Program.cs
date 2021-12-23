
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

		// This one writes to the console
		public override string ToString()
		{
			return 
			"Age: " + Age +
			"\nName: " + Name +
			"\nBirthdate: " + Bdate + 
			"\nHeight: " + Height;
		}
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
			Person person2 = new Person(52, "Mike", dateTime1, 1.9);
			Person person3 = new Person(16, "Jen", dateTime2, 1.75);

			List<Person> personas = new List<Person>();

			personas.Add(person1);
			personas.Add(person2);
			personas.Add(person3);

			foreach (Person individual in personas)
			{
				Console.WriteLine(individual + "\n");
			}

			Console.WriteLine("{0}", sizeof(int));


		}
	}
}
