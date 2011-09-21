namespace nothinbutdotnetstore.web.core
{
    public interface IDisplayAReport
    {
        void render();
    	bool can_display(object reportModel);
    }
}