using System.Linq;
using NUnit.Framework;

namespace DelegatesFuncsLambdas
{
    [TestFixture]
    public class DelegateTests
    {
        private delegate string ProcessString(string input);

        [Test]
        public void Delegate_constructor()
        {
            ProcessString allAs = new ProcessString(AllAs);

            Assert.That(allAs("abc"), Is.EqualTo("aaa"));
        }

        private static string AllAs(string input)
        {
            return new string('a', input.Length);
        }

        [Test]
        public void Named_method()
        {
            ProcessString reverse = Reverse;

            Assert.That(reverse("abc"), Is.EqualTo("cba"));
        }

        private static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        [Test]
        public void Anonymous_function()
        {
            ProcessString capitalise = delegate(string input) { return input.ToUpperInvariant(); };

            Assert.That(capitalise("abc"), Is.EqualTo("ABC"));
        }

        [Test]
        public void Lambda()
        {
            ProcessString minusculise = input => input.ToLowerInvariant();

            Assert.That(minusculise("ABC"), Is.EqualTo("abc"));
        }
    }
}
