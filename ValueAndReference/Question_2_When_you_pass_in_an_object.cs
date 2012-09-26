using NUnit.Framework;

namespace ValueAndReference
{
	[TestFixture]
	public class Question_2_When_you_pass_in_an_object
	{
		private const int ReplaceMe = 0;

		[Test]
		public void As_an_unqualified_argument()
		{
			var argument = new Foo(5);

			ActOnArgument(argument);

			// TODO: fill in the expected value
			Assert.IsTrue(argument.Bar == ReplaceMe);
		}

		private static void ActOnArgument(Foo argument)
		{
			argument.Bar++;
		}

		[Test]
		public void As_a_reference_argument()
		{
			var argument = new Foo(5);

			ActOnReferenceArgument(ref argument);

			// TODO: fill in the expected value
			Assert.IsTrue(argument.Bar == ReplaceMe);
		}

		private static void ActOnReferenceArgument(ref Foo argument)
		{
			argument.Bar++;
		}

		[Test]
		public void As_an_output_argument()
		{
			var argument = new Foo(5);

			ActOnOutputArgument(out argument);

			// TODO: fill in the expected value
			Assert.IsTrue(argument.Bar == ReplaceMe);
		}

		private static void ActOnOutputArgument(out Foo argument)
		{
			argument = new Foo(8);
			argument.Bar++;
		}

		private class Foo
		{
			public int Bar { get; set; }

			public Foo(int bar)
			{
				Bar = bar;
			}
		}
	}
}