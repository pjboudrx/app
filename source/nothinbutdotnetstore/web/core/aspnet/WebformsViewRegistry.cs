namespace nothinbutdotnetstore.web.core.aspnet
{
	public class WebformsViewRegistry : IFindViewForModel
	{
		public IDisplayAReport get_view_for<ReportModel>(ReportModel report_model)
		{
			throw new System.NotImplementedException();
		}
	}
}