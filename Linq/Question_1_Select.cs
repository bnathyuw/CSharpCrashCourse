using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Linq
{
	[TestFixture]
	public class Question_1_Select
	{
		private Member[] _collection;

		[TestFixtureSetUp]
		public void TestFixtureSetUp()
		{
			_collection = new Member[]
				              {
					              new Member(1, 1),
					              new Member(2, 1, 1),
					              new Member(3, 1, 1, 2),
					              new Member(4, 1, 1, 2, 3),
					              new Member(5, 1, 1, 2, 3, 5),
					              new Member(6, 1, 1, 2, 3, 5, 8),
					              new Member(7, 1, 1, 2, 3, 5, 8, 13),
					              new Member(8, 1, 1, 2, 3, 5, 8, 13, 21),
					              new Member(9, 1, 1, 2, 3, 5, 8, 13, 21, 34)
				              };
		}

		[Test]
		public void Select_a_value_with_extension_method()
		{
			// TODO: what type will foos have?
			var foos = _collection.Select(member => member.Foo);
			// TODO: substitute the correct value
			var expectedValue = new object();
			Assert.That(foos, Is.EqualTo(expectedValue));
		}

		[Test]
		public void Select_a_value_with_linq_syntax()
		{
			var foos = from member in _collection
			           select member.Foo;
			// TODO: substitute the correct value
			var expectedValue = new object();
			Assert.That(foos, Is.EqualTo(expectedValue));
		}

		[Test]
		public void Select_many_with_extension_method()
		{
			// TODO: what type will bars have?
			var bars = _collection.SelectMany(member => member.Bars);
			// TODO: substitute the correct value
			var expectedValue = new object();
			Assert.That(bars, Is.EqualTo(expectedValue));
		}

		[Test]
		public void Select_many_with_linq_syntax()
		{
			var bars = from member in _collection
			           from bar in member.Bars
			           select bar;
			// TODO: substitute the correct value
			var expectedValue = new object();
			Assert.That(bars, Is.EqualTo(expectedValue));
		}

		private class Member
		{
			public Member(int foo, params int[] bars)
			{
				Foo = foo;
				Bars = bars;
			}
			public int Foo { get; set; }
			public int[] Bars { get; set; }
		}
	}
}
