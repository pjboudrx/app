using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application.catalogbrowsing.stubs;
using nothinbutdotnetstore.web.core;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(Stub))]
    public class StubSpecs
    {
		public abstract class concern : Observes<Stub>
        {
        }

        public class when_creating_a_stub : concern
        {
			public class and_the_concrete_type_is_known : concern
			{
				Establish c = () =>
				{
					stub = Stub.with<StubDepartmentRepository>();
				};

				private It should_create_an_instance_of_the_specified_type = () =>
											stub.ShouldBeAn<StubDepartmentRepository>().
											ShouldNotBeNull();

				private static object stub;
			}
        }
    }
}