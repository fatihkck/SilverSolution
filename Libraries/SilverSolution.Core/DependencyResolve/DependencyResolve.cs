namespace SilverSolution.Core.DependencyResolve
{
    public class DependencyResolve : IDependencyResolve
    {
        IDependencyResolve _dependencyResolve;

        public DependencyResolve(IDependencyResolve dependencyResolve)
        {
            _dependencyResolve = dependencyResolve;
        }
        public void Bootstrap()
        {
            _dependencyResolve.Bootstrap();
        }
    }
}
