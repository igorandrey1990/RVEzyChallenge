using RVEzyChallenge.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVEzyChalengeTests.Comparer
{
    public class ListingComparer : IEqualityComparer<Listing>
    {
        public bool Equals(Listing x, Listing y)
        {
            if (x == null && y == null) { return true; }
            else if (x == null || y == null) { return false; }
            else if (object.ReferenceEquals(x, y)) { return true; }

            return x.id == y.id
                && x.property_type == y.property_type
                && x.description == y.description
                && x.listing_url == y.listing_url
                && x.name == y.name;
        }

        public int GetHashCode([DisallowNull] Listing obj)
        {
            return $"{obj.id}{obj.property_type}{obj.description}{obj.listing_url}{obj.name}".GetHashCode();
        }
    }
}
