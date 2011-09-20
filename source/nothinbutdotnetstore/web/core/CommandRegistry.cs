using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.web.core
{
    public class CommandRegistry : IFindCommands
    {
    	IEnumerable<IProcessOneRequest> all_commands;

    	public CommandRegistry(IEnumerable<IProcessOneRequest> all_commands)
    	{
    		this.all_commands = all_commands;
    	}

        public IProcessOneRequest get_the_command_that_can_process(IContainRequestInformation request)
        {
        	return all_commands.FirstOrDefault(c => c.can_process(request)) ?? new NoOpCommand();
        }
    }
}