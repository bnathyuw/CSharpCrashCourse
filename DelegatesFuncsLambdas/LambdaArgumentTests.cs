using System;
using NUnit.Framework;

namespace DelegatesFuncsLambdas
{
    [TestFixture]
    public class LambdaArgumentTests
    {
        [Test]
        public void Explicitly_typed()
        {
            Func<double,double> halve = (double input) => input/2;

            Assert.That(halve(5), Is.EqualTo(2.5));
        }

        [Test]
        public void Lots_of_explicit_arguments()
        {
            Func<double, double, double> multiply = (double a, double b) => a*b;

            Assert.That(multiply(2,3), Is.EqualTo(6));
        }

        [Test]
        public void Impliticly_typed()
        {
            Func<double, double> third = (input) => input/3;

            Assert.That(third(6), Is.EqualTo(2));
        }

        [Test]
        public void Logs_of_Implicit_arguments()
        {
            Func<double, double, double, double> multiply = (a, b, c) => a*b*c;

            Assert.That(multiply(2,3,4), Is.EqualTo(24));
        }

        [Test]
        public void No_brackets()
        {
            Func<double, double> quarter = input => input/4;

            Assert.That(quarter(9), Is.EqualTo(2.25));
        }

        [Test]
        public void No_arguments()
        {
            Func<double> fifth = () => 0.2;

            Assert.That(fifth(), Is.EqualTo(0.2));
        }
    }
}