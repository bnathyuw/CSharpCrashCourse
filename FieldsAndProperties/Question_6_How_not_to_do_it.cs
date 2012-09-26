using System.Linq;
using NUnit.Framework;

namespace FieldsAndProperties
{
	[TestFixture]
	public class Question_6_How_not_to_do_it
	{
		// TODO: Discuss

		[Test]
		public void Check_field_values()
		{
			IPerson jack = new Person("Jack", 30);
			Assert.IsTrue(jack.Name == "Jack");
			Assert.IsTrue(jack.Age == 30);
		}

		private interface IPerson
		{
			string Name { get; }
			int Age { get; }
		}

		private class Person : IPerson
		{
			private string _name;
			private int _age;

			public Person(string name, int age)
			{
				Name = name;
				Age = age;
			}

			public string Name
			{
				get { return _name + " is great"; }
				set { _name = value.Reverse().ToString(); }
			}

			public int Age
			{
				get { return _age + 12; }
				set { _age = value/2; }
			}
		}
	}

	
}