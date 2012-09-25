using NUnit.Framework;

namespace ValueAndReference
{
    [TestFixture]
    public class When_you_pass_in_an_object
    {
        private const int ReplaceMe = 0;

        [Test]
        public void As_an_unqualified_argument()
        {
            var argument = new Foo(5);

            ActOnArgument(argument);

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

            Assert.IsTrue(argument.Bar == ReplaceMe);
        }

        private static void ActOnReferenceArgument(ref Foo argument)
        {
            argument.Bar++;
        }

        [Test]
        public void As_an_output_argument()
        {
            Foo argument;

            ActOnOutputArgument(out argument);

            Assert.IsTrue(argument.Bar == ReplaceMe);
        }

        private static void ActOnOutputArgument(out Foo argument)
        {
            argument = new Foo(5);
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