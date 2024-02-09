using System;

namespace ExtensionMethods
{
	public static class PersonExtensions
	{
		public static PersonModel SetDefaultAge(this PersonModel person)
		{
			person.Age = 25;
			return person;
		}

		public static PersonModel PrintInfo(this PersonModel person)
		{
			Console.WriteLine($"{person.FullName} is {person.Age} years old.");
			return person;
		}
	}
}
