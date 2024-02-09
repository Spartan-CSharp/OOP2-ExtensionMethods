using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PersonModel person = new PersonModel("Tim", "Corey");

			_ = person.SetDefaultAge().PrintInfo();

			_ = Console.ReadLine();
		}
	}
}
