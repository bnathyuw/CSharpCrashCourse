using System;
using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;

namespace Yield
{
	[TestFixture]
	public class IEnumerator_tests
	{
		private Action _afterAllYields;
		private Action _finally;
		private Action<int> _beforeYield;
		private IEnumerator<int> _foo;

		[SetUp]
		public void SetUp()
		{
			_afterAllYields = MockRepository.GenerateStub<Action>();
			_finally = MockRepository.GenerateStub<Action>();
			_beforeYield = MockRepository.GenerateStub<Action<int>>();
			_foo = GetFoo(_afterAllYields, _finally, _beforeYield);
		}
		
		[Test]
		public void Does_it_reach_code_before_yield_when_calling_current()
		{
			Console.Write(_foo.Current);

			//_beforeYield.AssertWasNotCalled(x => x(0));
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_calling_current()
		{
			Console.Write(_foo.Current);

			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_calling_current()
		{
			Console.Write(_foo.Current);

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_before_yield_when_calling_move_next()
		{
			_foo.MoveNext();
			
			//_beforeYield.AssertWasNotCalled(x => x(0));
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_calling_move_next()
		{
			_foo.MoveNext();
			
			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_calling_move_next()
		{
			_foo.MoveNext();

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_code_after_all_yields_when_looping_to_end()
		{
			while (_foo.MoveNext())
			{
			}

			//_afterAllYields.AssertWasNotCalled(x => x());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_afterAllYields.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_reach_finally_block_when_lopping_to_end()
		{
			while (_foo.MoveNext())
			{
			}

			//_finally.AssertWasNotCalled(x => x());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Once());
			//_finally.AssertWasCalled(x => x(), options => options.Repeat.Times(2));
		}

		[Test]
		public void Does_it_replay_code_before_yield_when_resetting()
		{
			_foo.MoveNext();
			_foo.MoveNext();
			_foo.Reset();

			//_beforeYield.AssertWasNotCalled(x => x(0));
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Once());
			//_beforeYield.AssertWasCalled(x => x(0), options => options.Repeat.Times(2));
		}

		private static IEnumerator<int> GetFoo(Action afterAllYields, Action @finally, Action<int> beforeYield)
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