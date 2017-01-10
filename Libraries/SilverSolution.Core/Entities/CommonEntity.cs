using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverSolution.Core.Entities
{
    public abstract class CommonEntity<T>
    {
        public T Id { get; set; }

    }
}
