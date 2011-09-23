using System;

namespace nothinbutdotnetstore.utility.containers.simple
{
    public class SimpleDependencyFactory : ICreateADependency
    {
    	private readonly Func<object> _creator;

    	public SimpleDependencyFactory(Func<object> creator)
    	{
    		_creator = creator;
    	}

    	public object create()
    	{
    		return _creator();
    	}
    }
}