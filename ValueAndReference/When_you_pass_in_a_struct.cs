using NUnit.Framework;

namespace ValueAndReference
{
    [TestFixture]
    public class When_you_pass_in_a_struct
    {
        private const int ReplaceMe = 0;

        [Test]
        public void As_an_unqualified_argument()
        {
            var argument = new Baz(5);

            ActOnArgument(argument);

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

            Assert.IsTrue(argument.Bar == ReplaceMe);
        }

        private static void ActOnReferenceArgument(ref Baz argument)
        {
            argument.Bar++;
        }

        [Test]
        public void As_an_output_argument()
        {
            Baz argument;

            ActOnOutputArgument(out argument);

            Assert.IsTrue(argument.Bar == ReplaceMe);
        }

        private static void ActOnOutputArgument(out Baz argument)
        {
            argument = new Baz(5);
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