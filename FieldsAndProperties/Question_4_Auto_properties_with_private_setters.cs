using NUnit.Framework;

namespace FieldsAndProperties
{
	[TestFixture]
	public class Question_4_Auto_properties_with_private_setters
	{
		// TODO: What happens when you uncomment the code?

		[Test]
		public void Check_field_values()
		{
			var jack = new Person("Jack", 30);
			//jack.Name = "Jill";
			//jack.Age = 50;
			Assert.IsTrue(jack.Name == "Jack");
			Assert.IsTrue(jack.Age == 30);
		}

		private class Person
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