using NUnit.Framework;

namespace Inheritance
{
	[TestFixture]
	public class Question_3_Inheritance
	{
		public static readonly string ReplaceMe = string.Empty;

		// TODO: Discuss why you might want to do this

		[Test]
		public void On_class()
		{
			var person = new Person();

			var greeting = person.GreetMe();

			// TODO: fill in the expected value
			Assert.IsTrue(greeting == ReplaceMe);
		}

		[Test]
		public void On_interface()
		{
			IFriend friend = new Person();

			var greeting = friend.GreetMe();

			// TODO: fill in the expected value
			Assert.IsTrue(greeting == ReplaceMe);
		}

		private class Person:IFriend
		{
			public string GreetMe()
			{
				return "Hello!";
			}

			string IFriend.GreetMe()
			{
				return "Hello! How lovely to see you!";
			}
		}

		private interface IFriend
		{
			string GreetMe();
		}
	}
}