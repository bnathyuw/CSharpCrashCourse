using NUnit.Framework;

namespace FieldsAndProperties
{
	[TestFixture]
	public class Question_5_Properties_in_an_interface
	{
		// TODO: What happens when you uncomment the code?

		[Test]
		public void Check_field_values()
		{
			IPerson jack = new Person("Jack", 30);
			//jack.Name = "Jill";
			//jack.Age = 50;
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
			public Person(string name, int age)
			{
				Name = name;
				Age = age;
			}

			public string Name { get; private set; }

			public int Age { get; private set; }
		}
	}

	
}