using NUnit.Framework;

namespace VarsAndFields
{
	[TestFixture]
	public class Question_1_Class_members
	{
		private readonly Foo _foo = new Foo();
		private static readonly string ReplaceMe = string.Empty;
		
		// TODO: Fill in the expected values in the tests.
		// TODO: Which of these statements can you uncomment? Update the expected values in the tests.
		// TODO: Discuss when you might want to use each of these.

		[SetUp]
		public void SetUp()
		{
			//Foo.StaticReadonlyField = "Z";
			//Foo.StaticField = "Y";
			
			//Foo.ConstantField = "X";

			//Foo.StaticGetOnlyProperty = "W";
			//Foo.StaticProperty = "V";

			//_foo.ReadonlyField = "U";
			//_foo.NormalField = "T";

			//_foo.GetOnlyProperty = "S";
			//_foo.NormalProperty = "R";
		}
		
		[Test]
		public void Static_readonly_field()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(Foo.StaticReadonlyField == ReplaceMe);
		}

		[Test]
		public void Static_field()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(Foo.StaticField == ReplaceMe);
		}

		[Test]
		public void Constant_field()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(Foo.ConstantField == ReplaceMe);
		}

		[Test]
		public void Static_get_only_property()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(Foo.StaticGetOnlyProperty == ReplaceMe);
		}

		[Test]
		public void Static_property()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(Foo.StaticProperty == ReplaceMe);
		}

		[Test]
		public void Readonly_field()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(_foo.ReadonlyField == ReplaceMe);
		}

		[Test]
		public void Normal_field()
		{
			// TODO: fill in the expected value
			Assert.IsTrue(_foo.NormalField == ReplaceMe);
		}

		private class Foo
		{
			public static readonly string StaticReadonlyField;
			public static string StaticField;
			
			public const string ConstantField = "C";

			public static string StaticGetOnlyProperty { get; private set; }
			public static string StaticProperty { get; set; }

			public readonly string ReadonlyField;
			public string NormalField;

			public string GetOnlyProperty { get; private set; }
			public string NormalProperty { get; set; }

			static Foo()
			{
				StaticReadonlyField = "A";
				StaticField = "B";
				//C = "C";
				StaticGetOnlyProperty = "D";
				StaticProperty = "E";
			}
			
			public Foo()
			{
				ReadonlyField = "F";
				NormalField = "G";
				GetOnlyProperty = "H";
				NormalProperty = "I";
			}
		}
	}
}
