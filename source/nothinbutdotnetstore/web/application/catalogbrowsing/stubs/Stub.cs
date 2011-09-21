namespace nothinbutdotnetstore.web.application.catalogbrowsing.stubs
{
	public class Stub
	{
		public static TypeOfStub with<TypeOfStub>() 
			where TypeOfStub : new()
		{
			return new TypeOfStub();
		}
	}
}