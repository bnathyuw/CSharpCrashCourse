using System;
using NUnit.Framework;

namespace DelegatesFuncsLambdas
{
    [TestFixture]
    class FuncTests
    {
        [Test]
        public void Func_constructor()
        {
            Func<int,int> dble = new Func<int, int>(Double);

            Assert.That(dble(2), Is.EqualTo(4));
        }

        private static int Double(int arg)
        {
            return 2*arg;
        }

        [Test]
        public void Assigning_a_method_to_a_func()
        {
            Func<int, int> triple = Triple;

            Assert.That(triple(2), Is.EqualTo(6));
        }

        private static int Triple(int arg)
        {
            return 3*arg;
        }

        [Test]
        public void Anonymous_function()
        {
            Func<int, int> quadrupal = delegate(int i) { return 4*i; };

            Assert.That(quadrupal(2), Is.EqualTo(8));
        }

        [Test]
        public void Lambda()
        {
            Func<int, int> quintuple = i => 5*i;

            Assert.That(quintuple(2), Is.EqualTo(10));
        }
    }
}
