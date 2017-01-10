using SilverSolution.Core.Entities;

namespace SilverSolution.Entities.Concrete
{
    public class CustomerAddress:AuditableEntity<int>, IEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Address{ get; set; }
    }
}
