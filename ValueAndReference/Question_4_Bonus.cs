using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ValueAndReference
{
	[TestFixture]
	public class Question_4_Bonus
	{
		private readonly List<Widget> _widgetRepository = new List<Widget>();

		[Test]
		public void When_I_process_a_widget_request_a_corresponding_widget_is_saved()
		{
			var widgetRequest = new WidgetRequest(3.99m);
			var machine = new Machine(_widgetRepository);

			machine.Process(widgetRequest);

			var savedWidget = _widgetRepository.First();

			// TODO: Why is this a useless assertion?
			// TODO: How could you make this assertion meaningful?
			Assert.IsTrue(savedWidget.Price == widgetRequest.Price);
		}
	}

	internal class Widget
	{
		public decimal Price { get; set; }
	}

	internal class Machine
	{
		private readonly List<Widget> _widgetRepository;

		public Machine(List<Widget> widgetRepository)
		{
			_widgetRepository = widgetRepository;
		}

		public void Process(WidgetRequest widgetRequest)
		{
			const decimal arbitraryPrice = 99.99m;
			widgetRequest.Price = arbitraryPrice;
			var widget = new Widget {Price = arbitraryPrice};
			_widgetRepository.Add(widget);
		}
	}

	internal class WidgetRequest
	{
		public WidgetRequest(decimal price)
		{
			Price = price;
		}

		public decimal Price { get; set; }
	}
}