using System;

namespace ExtensionMethods
{
	internal class Program
	{
		private static void Main()
		{
			PersonModel person = new PersonModel("Tim", "Corey");

			_ = person.SetDefaultAge().PrintInfo();

			_ = Console.ReadLine();
		}
	}
}
