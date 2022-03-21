using System;

namespace Familia.Domain.Entities
{
    public class Points : IEquatable<Points>
    {
        public string Name { get; set; }
        public int PointsFamily { get; set; }
        public string Type { get; set; }

        public bool Equals(Points other)
        {
            return other.Type == this.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
