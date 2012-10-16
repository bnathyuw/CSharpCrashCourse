using System;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace DelegatesFuncsLambdas
{
    [TestFixture]
    public class MulticastDelegates
    {
        public void WriteBackwards(string input)
        {
            Console.Write(new string(input.Reverse().ToArray()));
        }

        [Test]
        public void Delegate_can_hold_more_than_one_method()
        {
            using (var outputInterceptor = new OutputInterceptor())
            {
                StringDelegate forwards = Console.Write;
                StringDelegate backwards = WriteBackwards;
                StringDelegate multicast = forwards + backwards;

                multicast("abc");

                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

                var output = outputInterceptor.Output;
                Assert.That(output, Is.StringContaining("abc"));
                Assert.That(output, Is.StringContaining("cba"));
            }
        }

        private delegate void StringDelegate(string input);

        [Test]
        public void Action_can_hold_more_than_one_method()
        {
            using (var outputInterceptor = new OutputInterceptor())
            {
                Action<string> forwards = Console.Write;
                Action<string> backwards = WriteBackwards;
                Action<string> multicast = forwards + backwards;

                multicast("abc");

                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

                var output = outputInterceptor.Output;
                Assert.That(output, Is.StringContaining("abc"));
                Assert.That(output, Is.StringContaining("cba"));
            }
        }

        public string ToUpper(string input)
        {
            Console.WriteLine("Converting {0} to uppercase", input);
            return input.ToUpperInvariant();
        }

        public string ToLower(string input)
        {
            Console.WriteLine("Converting {0} to lowercase", input);
            return input.ToLowerInvariant();
        }

        [Test]
        public void Function_can_hold_more_than_one_method()
        {
            Func<string, string> upper = ToUpper;
            Func<string, string> lower = ToLower;
            Func<string, string> multicast = upper + lower;

            var result = multicast("abc");

            Console.WriteLine(result);
        }
    }
}