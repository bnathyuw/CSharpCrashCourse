using System;
using System.IO;
using NUnit.Framework;

namespace DelegatesFuncsLambdas
{
    [TestFixture]
    public class LambdaBodyTests
    {
        [Test]
        public void Action_body()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Action<string> hello = input =>
                                       {
                                           var message = "Hello, " + input + "!";
                                           Console.Write(message);
                                       };

            hello("world");

            Assert.That(stringWriter.ToString(), Is.EqualTo("Hello, world!"));
        }

        [Test]
        public void Action_without_body()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Action<string> greetings = input => Console.Write("Greetings, " + input + "!");

            greetings("earthlings");

            Assert.That(stringWriter.ToString(), Is.EqualTo("Greetings, earthlings!"));
        }

        [Test]
        public void Func_body()
        {
            Func<string, string> goodbye = input =>
                                               {
                                                   var message = "Goodbye, " + input + "!";
                                                   return message;
                                               };

            Assert.That(goodbye("cruel world"), Is.EqualTo("Goodbye, cruel world!"));
        }

        [Test]
        public void Func_without_body()
        {
            Func<string, string> farewell = input => "Farewell, " + input + "!";

            Assert.That(farewell("Spanish ladies"), Is.EqualTo("Farewell, Spanish ladies!"));
        }
    }
}