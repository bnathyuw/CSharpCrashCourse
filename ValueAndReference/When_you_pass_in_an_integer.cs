using NUnit.Framework;

namespace ValueAndReference
{
    [TestFixture]
    public class When_you_pass_in_an_integer
    {
        private const int ReplaceMe = 0;

        [Test] 
        public void As_unqualified_argument()
        {
            var argument = 5;

            ActOnArgument(argument);

            // TODO: fill in the expected value
            Assert.IsTrue(argument == ReplaceMe);
        }

        private static void ActOnArgument(int argument)
        {
            argument++;
        }

        [Test]
        public void As_reference_argument()
        {
            var argument = 5;

            ActOnReferenceArgument(ref argument);

            // TODO: fill in the expected value
            Assert.IsTrue(argument == ReplaceMe);
        }

        private static void ActOnReferenceArgument(ref int argument)
        {
            argument++;
        }

        [Test]
        public void As_output_argument()
        {
            var argument = 5;

            ActOnOutputArgument(out argument);

            // TODO: fill in the expected value
            Assert.IsTrue(argument == ReplaceMe);
        }

        private static void ActOnOutputArgument(out int argument)
        {
            argument = 8;
            argument++;
        }
    }
}