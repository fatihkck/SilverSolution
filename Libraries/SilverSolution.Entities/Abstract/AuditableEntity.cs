using SilverSolution.Core.Entities;
using SilverSolution.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverSolution.Entities
{
    public abstract class AuditableEntity<T> : CommonEntity<T>, IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }
        
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public AuditableEntity()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
