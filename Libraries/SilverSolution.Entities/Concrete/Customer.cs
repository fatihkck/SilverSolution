using SilverSolution.Core.Entities;

namespace SilverSolution.Entities.Concrete
{
    public class Customer: AuditableEntity<int>, IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
