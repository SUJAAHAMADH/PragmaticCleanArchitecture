using BookiFy.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookiFy.Domain.Apartments
{
    public sealed class Apartment : Entity
    {
        public Apartment(Guid id)
            : base(id)
        {
            
        }

        public Name Name { get; private set; }

        public Description Description { get; private set; }

        public Address Address { get; private set; }

        public double PriceAmount { get; private set; }

        public string PriceCurrency { get; private set; }

        public double CleaningFeeAmount { get; private set; }

        public string CleaningFeeCurrency { get; private set; }

        public DateTime? LastBookOnUtc { get; private set; }

        public List<Amenity> Amenities { get; private set; } = new();
    }
}
