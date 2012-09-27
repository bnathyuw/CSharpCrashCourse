using NUnit.Framework;

namespace VarsAndFields
{
	[TestFixture]
	public class Question_2_Variables
	{
		private const int ReplaceMe = 100;

		[Test]
		public void Explicitly_typed_variable()
		{
			int variable = 12;

			// TODO: try uncommenting this line; what happens?
			//variable = 2;

			// TODO: what about this line?
			//variable = 2.3;

			// TODO: Fill in the expected value
			Assert.IsTrue(variable == ReplaceMe);
		}

		[Test]
		public void Implicitly_typed_variable()
		{
			// TODO: Check the type of this variable
			var variable = 13;

			// TODO: try uncommenting this line; what happens?
			//variable = 2;

			// TODO: what about this line?
			//variable = 2.3;

			// TODO: Fill in the expected value
			Assert.IsTrue(variable == ReplaceMe);

			// TODO: Discuss why you might want to do this
		}

		[Test]
		public void Dynamic_variable()
		{
			dynamic variable = 13;

			// TODO: try uncommenting this line; what happens?
			//variable = 2;

			// TODO: what about this line?
			//variable = 2.3;

			// TODO: Fill in the expected value
			Assert.IsTrue(variable == ReplaceMe);

			// TODO: Discuss why you might want to do this
		}

		[Test]
		public void Local_constant()
		{
			const int constant = 14;
			
			// TODO: try uncommenting this line; what happens?
			//constant = 2;

			// TODO: Fill in the expected value
			Assert.IsTrue(constant == ReplaceMe);

			// TODO: Discuss why you might want to do this
		}

	}
}