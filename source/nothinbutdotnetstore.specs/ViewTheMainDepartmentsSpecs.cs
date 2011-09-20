using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartments))]
    public class ViewTheMainDepartmentsSpecs
    {
        public abstract class concern : Observes<IOrchestrateAnApplicationFeature,
                                            ViewTheMainDepartments>
        {
        }

        public class when_run : concern
        {
            //Arrange
            Establish c = () =>
            {
                request = fake.an<IContainRequestInformation>();
            	department_list = depends.on<IListDepartments>();
            };

            //Act
            Because b = () =>
                sut.process(request);

            //Assert
        	private It should_list_the_main_departments = () => department_list.received(x => x.list_the_main_departments());

            static IContainRequestInformation request; 
            static IListDepartments department_list; 
        }
    }
}