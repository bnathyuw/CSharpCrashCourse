using NUnit.Framework;

namespace ValueAndReference
{
	[TestFixture]
	public class Question_3_Struct
	{
		private const int ReplaceMe = 0;

		[Test]
		public void As_an_unqualified_argument()
		{
			var argument = new Baz(5);

			ActOnArgument(argument);

			// TODO: fill in the expected value
			Assert.IsTrue(argument.Bar == ReplaceMe);
		}

		private static void ActOnArgument(Baz argument)
		{
			argument.Bar++;
		}

		[Test]
		public void As_a_reference_argument()
		{
			var argument = new Baz(5);

			ActOnReferenceArgument(ref argument);

			// TODO: fill in the expected value
			Assert.IsTrue(argument.Bar == ReplaceMe);
		}

		private static void ActOnReferenceArgument(ref Baz argument)
		{
			argument.Bar++;
		}

		[Test]
		public void As_an_output_argument()
		{
			var argument = new Baz(5);

			ActOnOutputArgument(out argument);

			// TODO: fill in the expected value
			Assert.IsTrue(argument.Bar == ReplaceMe);
		}

		private static void ActOnOutputArgument(out Baz argument)
		{
			argument = new Baz(8);
			argument.Bar++;
		}

		private struct Baz
		{
			public int Bar { get; set; }

			public Baz(int bar) : this()
			{
				Bar = bar;
			}
		}
	}
}