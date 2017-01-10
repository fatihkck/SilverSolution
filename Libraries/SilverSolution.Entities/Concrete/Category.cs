using SilverSolution.Core.Entities;

namespace SilverSolution.Entities.Concrete
{
    public class Category: AuditableEntity<int>,IEntity
    {
        public string Name { get; set; }
    }
}
