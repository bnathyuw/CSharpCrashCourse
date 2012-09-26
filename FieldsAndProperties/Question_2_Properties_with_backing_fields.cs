using NUnit.Framework;

namespace FieldsAndProperties
{
	[TestFixture]
	public class Question_2_Properties_with_backing_fields
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
			private string _name;
			private int _age;

			public Person(string name, int age)
			{
				_name = name;
				_age = age;
			}

			public string Name
			{
				get { return _name; }
			}

			public int Age
			{
				get { return _age; }
			}
		}
	}
}