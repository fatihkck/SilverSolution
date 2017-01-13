using SilverSolution.Core.DependencyResolve;
using System;
using System.Reflection;

namespace SilverSolution.AutofacIoC
{
    public class AutofacWebApi : IDependencyResolve
    {

        private readonly Assembly _assembly;
        public AutofacWebApi(Assembly assembly)
        {
            _assembly = assembly;
        }

        public void Bootstrap()
        {
            throw new NotImplementedException();
        }
    }
}
