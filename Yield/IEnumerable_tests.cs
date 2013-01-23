using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;

namespace Yield
{
	[TestFixture]
	public class IEnumerable_tests
	{
		private Action _afterAllYields;
		private Action _finally;
		private Action<int> _beforeYield;
		private IEnumerable<int> _foo;

		[SetUp]
		public void SetUp()
		{
			_afterAllYields = MockRepository.GenerateStub<Action>();
			_finally = MockRepository.GenerateStub<Action>();
			_beforeYield = MockRepository.GenerateStub<Action<int>>();
			_foo = GetFoo(_afterAllYields, _finally, _beforeYield);
		}


		[Test]
		public void What_is_the_count()
		{
			var foo = _foo;
			var count = foo.Count();

			//Assert.That(count, Is.EqualTo(4));
			//Assert.That(count, Is.EqualTo(5));
			//Assert.That(count, Is.EqualTo(0));
		}

		[Test]
		public void What_element_is_retrieved()
		{
			var foo = _foo;
			var element = foo.ElementAt(4);

			//Assert.That(element, Is.EqualTo(3));
			//Assert.That(element, Is.EqualTo(4));
			//Assert.That(element, Is.EqualTo(5));
		}

		[Test]
		public void Does_it_continue_past_the_yield_when_accessing_an_element()
		{
			Console.WriteLine(_foo.ElementAt(2));

			//_beforeYield.AssertWasNotCalled(x => x(3));
			//_beforeYield.AssertWasCalled(x => x(3), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(3), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_accessing_element()
		{
			Console.WriteLine(_foo.ElementAt(2));

			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_accessing_element()
		{
			Console.WriteLine(_foo.ElementAt(2));

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_before_yield_when_accessing_two_elements()
		{
			Console.WriteLine(_foo.ElementAt(2));
			Console.WriteLine(_foo.ElementAt(3));

			//_beforeYield.AssertWasNotCalled(x => x(0));
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_accessing_two_elements()
		{
			Console.WriteLine(_foo.ElementAt(2));
			Console.WriteLine(_foo.ElementAt(3));

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_counting_elements()
		{
			Console.WriteLine(_foo.Count());

			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_counting_elements()
		{
			Console.WriteLine(_foo.Count());

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_looping_over_elements()
		{
			foreach (var item in _foo)
			{
				Console.WriteLine(item);
			}

			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_looping_over_elements()
		{
			foreach (var item in _foo)
			{
				Console.WriteLine(item);
			}

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_take_is_called()
		{
			foreach (var item in _foo.Take(3))
			{
				Console.WriteLine(item);
			}

			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_take_is_called()
		{
			var enumerable = _foo.Take(3);
			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_before_take_is_enumerated_over()
		{
			var enumerable = _foo.Take(3);
			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}
		}

		[Test]
		public void Does_it_reach_code_before_yield_when_take_is_called()
		{
			var enumerable = _foo.Take(3);
			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}
			//_beforeYield.AssertWasNotCalled(x => x(1));
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_before_yield_before_take_is_enumerated_over()
		{
			var enumerable = _foo.Take(3);
			//_beforeYield.AssertWasNotCalled(x => x(1));
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Times(2));
			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}
		}

		[Test]
		public void Does_it_reach_code_before_yield_when_skip_is_called()
		{
			var enumerable = _foo.Skip(2);
			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}
			//_beforeYield.AssertWasNotCalled(x => x(1));
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_before_yield_before_skip_is_enumerated_over()
		{
			var enumerable = _foo.Skip(2);
			//_beforeYield.AssertWasNotCalled(x => x(1));
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(1), options => options.Repeat.Times(2));
			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}
		}


		private static IEnumerable<int> GetFoo(Action afterAllYields, Action @finally, Action<int> beforeYield)
		{
			try
			{
				beforeYield(0);
				yield return 1;
				beforeYield(1);
				yield return 2;
				beforeYield(2);
				yield return 3;
				beforeYield(3);
				yield return 4;
				beforeYield(4);
				yield return 5;
				afterAllYields();
			}
			finally
			{
				@finally();
			}
		}
	}
}