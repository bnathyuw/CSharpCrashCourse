using System;
using NUnit.Framework;

namespace VarsAndFields
{
	[TestFixture]
	public class Question_3_Numeric_types
	{
		[Test]
		public void Implicitly_typed()
		{
			var a = 1;
			var b = 2.3;

			// TODO: fill in the expected type
			Assert.That(a, Is.TypeOf<Object>());
			Assert.That(b, Is.TypeOf<Object>());
		}

		[Test]
		public void Converted()
		{
			var a = (int) 1;
			var b = (uint) 2;
			var c = (float) 3;
			var d = (double) 4;
			var e = (long) 5;
			var f = (ulong) 6;
			var g = (decimal) 7;

			// TODO: fill in the expected type
			Assert.That(a, Is.TypeOf<Object>());
			Assert.That(b, Is.TypeOf<Object>());
			Assert.That(c, Is.TypeOf<Object>());
			Assert.That(d, Is.TypeOf<Object>());
			Assert.That(e, Is.TypeOf<Object>());
			Assert.That(f, Is.TypeOf<Object>());
			Assert.That(g, Is.TypeOf<Object>());
		}

		[Test]
		public void Suffixed() {
			var a = 1;
			var b = 2u;
			var c = 3f;
			var d = 4d;
			var e = 5L;
			var f = 6UL;
			var g = 7m;

			// TODO: fill in the expected type
			Assert.That(a, Is.TypeOf<Object>());
			Assert.That(b, Is.TypeOf<Object>());
			Assert.That(c, Is.TypeOf<Object>());
			Assert.That(d, Is.TypeOf<Object>());
			Assert.That(e, Is.TypeOf<Object>());
			Assert.That(f, Is.TypeOf<Object>());
			Assert.That(g, Is.TypeOf<Object>());
		}
	}
}