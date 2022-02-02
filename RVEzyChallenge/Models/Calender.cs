using System;

namespace RVEzyChallenge.Models
{
    public class Calender
    {
        public long listing_id { get; set; }
        public DateTime date { get; set; }
        public bool available { get; set; }
        public double price { get; set; }
    }
}
