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

            Assert.IsTrue(argument == ReplaceMe);
        }

        private static void ActOnReferenceArgument(ref int argument)
        {
            argument++;
        }

        [Test]
        public void As_output_argument()
        {
            int argument;

            ActOnOutputArgument(out argument);

            Assert.IsTrue(argument == ReplaceMe);
        }

        private static void ActOnOutputArgument(out int argument)
        {
            argument = 0;
            argument++;
        }
    }
}