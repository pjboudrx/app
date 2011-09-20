namespace nothinbutdotnetstore.web.core
{
	public class NoOpCommand: IProcessOneRequest
	{
		public void process(IContainRequestInformation request)
		{
			
		}

		public bool can_process(IContainRequestInformation request)
		{
			return false;
		}
	}
}