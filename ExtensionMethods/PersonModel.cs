using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	public class PersonModel
	{
		public string FirstName
		{
			get; set;
		}

		public string LastName
		{
			get; set;
		}

		public int Age
		{
			get; set;
		}

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public PersonModel()
		{
		}

		public PersonModel(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
