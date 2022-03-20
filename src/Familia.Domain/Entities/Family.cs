using Familia.Domain.Kernel.Entities;
using System.Collections.Generic;

namespace Familia.Domain.Entities
{
    public class Family : Entity
    {
        public Family()
        {
            Dependents = new();
        }
        public string Name { get; set; }
        public virtual List<Dependent> Dependents { get; set; }
    }
}
