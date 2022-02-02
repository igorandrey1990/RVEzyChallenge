using RVEzyChalengeTests.Comparer;
using RVEzyChallenge.Controllers;
using RVEzyChallenge.Helpers;
using RVEzyChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RVEzyChalengeTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetByID()
        {
            Listing expected = new Listing()
            {
                id = 1,
                name = "Queen Anne Apartment",
                description = "Enjoy Queen Anne Living",
                listing_url = "https://www.airbnb.com/rooms/241032,20160104002432,2016-01-04,Stylish Queen Anne Apartment",
                property_type = "apartment"
            };

            ListingsController listingsController = new ListingsController();
            Listing actual = listingsController.GetByID(1);
            ListingComparer listingComparer = new ListingComparer();

            Assert.True(listingComparer.Equals(actual, expected));
        }

        [Fact]
        public void GetPaging()
        {
            List<Listing> expected = new List<Listing>() {
                new Listing()
                {
                    id = 1,
                    name = "Queen Anne Apartment",
                    description = "Enjoy Queen Anne Living",
                    listing_url = "https://www.airbnb.com/rooms/241032,20160104002432,2016-01-04,Stylish Queen Anne Apartment",
                    property_type = "apartment"
                },
                new Listing()
                {
                    id = 2,
                    name = "Charming craftsman",
                    description = "Enjoy craftmanship",
                    listing_url = "https://www.airbnb.com/rooms/278830,20160104002432,2016-01-04,Charming craftsman 3 bdm house",
                    property_type = "apartment"
                }
        };

            ListingsController listingsController = new ListingsController();

            ListingParameters listingParameters = new ListingParameters() { PageNumber = 1, PageSize = 2 };
            ListingComparer listingComparer = new ListingComparer();
            List<Listing> actual = listingsController.Get(listingParameters).ToList();

            foreach (Listing listing in actual)
            {
                Listing item = expected.Find(x => x.id == listing.id);

                if (item == null)
                    Assert.True(listingComparer.Equals(item, listing));
            }
        }
    }
}
