using System.Linq;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.aspnet;

namespace nothinbutdotnetstore.specs
{
	public class WebformsViewRegistrySpecs
	{
		public class concern : Observes<IFindViewForModel, WebformsViewRegistry> { }

		public class when_displaying_a_report_model : concern
		{
			Establish c = () =>
			{
				var all_views = Enumerable.Range(1, 100).Select(x => fake.an<IDisplayAReport>()).ToList();
				the_view = fake.an<IDisplayAReport>();
				the_view.setup(x => x.can_display(report_model)).Return(true);
			};

			private Because b = () => result = sut.get_view_for(report_model);

			private It should_return_the_view_that_can_display = () => result.ShouldEqual(the_view);

			private static object report_model;
			private static IDisplayAReport result;
			private static IDisplayAReport the_view;
		}
	}
}