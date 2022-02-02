using System;

namespace RVEzyChallenge.Models
{
    public class Review
    {
        public long listing_id { get; set; }
        public long id { get; set; }
        public DateTime date { get; set; }
        public long reviewer_id { get; set; }
        public string reviewer_name { get; set; }
        public string comments { get; set; }
    }
}
