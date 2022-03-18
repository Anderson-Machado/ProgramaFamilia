using Familia.Domain.Kernel.Entities;

namespace Familia.Domain.Entities
{
    public class Dependent : Entity
    {
        public int Age { get; set; }

        public int IdFamily { get; set; }

        public double Income { get; set; }
    }
}
