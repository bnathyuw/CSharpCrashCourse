using NUnit.Framework;

namespace VarsAndFields
{
	[TestFixture]
	public class Question_1
	{
		private Foo foo = new Foo();
		private static readonly string ReplaceMe = string.Empty;

		[SetUp]
		public void SetUp()
		{
			//Foo.A = "Z";
			//foo.B = "Y";
			//foo.C = "X";
		}
		
		[Test]
		public void Static_field()
		{
			Assert.IsTrue(Foo.A == ReplaceMe);
		}

		[Test]
		public void TestMethodName()
		{
			
		}

		[Test]
		public void TestMethodName()
		{
		}

		private class Foo
		{
			public static string A = "A";
			public const string B = "B";
			public readonly string C = "C";
		}
	}
}
