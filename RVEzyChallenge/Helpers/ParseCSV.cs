using CsvHelper;
using RVEzyChallenge.Models;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace RVEzyChallenge.Helpers
{
    public class ParseCSV
    {
        private static List<Listing> GetListingsList()
        {
            TextReader reader = new StreamReader("C:\\Users\\igora\\source\\repos\\RVEzyChallenge\\RVEzyChallenge\\CSV\\listings.csv");
            CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csvReader.GetRecords<Listing>().ToList();
        }

        public static Listing GetByID(long id)
        {
            return GetListingsList().Where(x => x.id == id).FirstOrDefault();
        }

        public static List<Listing> Get(ListingParameters listingParameters)
        {
            return GetListingsList()
                .Skip((listingParameters.PageNumber - 1) * listingParameters.PageSize)
                .Take(listingParameters.PageSize).ToList();
        }

        public static List<Listing> Get(ListingParameters listingParameters, string property_type)
        {
            return GetListingsList().Where(x => x.property_type.Equals(property_type)).Skip((listingParameters.PageNumber - 1) * listingParameters.PageSize).Take(listingParameters.PageSize).ToList();
        }
    }
}
