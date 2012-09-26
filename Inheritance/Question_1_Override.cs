using NUnit.Framework;

namespace Inheritance
{
	[TestFixture]
	public class Question_1_Override
	{
		private static readonly string ReplaceMe = string.Empty;

		[Test]
		public void Method_on_base_class()
		{
			var person = new Person();

			var greeting = person.GreetMe();

			// TODO: fill in the expected value
			Assert.IsTrue(greeting == ReplaceMe);
		}

		[Test]
		public void Override_method()
		{
			var enemy = new Enemy();

			var greeting = enemy.GreetMe();

			// TODO: fill in the expected value
			Assert.IsTrue(greeting == ReplaceMe);
		}

		[Test]
		public void Overridden_method_on_base_class() {
			Person enemy = new Enemy();

			var greeting = enemy.GreetMe();

			// TODO: fill in the expected value
			Assert.IsTrue(greeting == ReplaceMe);
		}

		private class Person
		{
			public virtual string GreetMe()
			{
				return "Hello!";
			}
		}

		private class Enemy:Person
		{
			public override string GreetMe()
			{
				return "Bugger off and leave me alone!";
			}
		}
	}
}
