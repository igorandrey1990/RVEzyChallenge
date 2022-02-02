using RVEzyChallenge.Models;
using System.Collections.Generic;

namespace RVEzyChallenge.Repository.Interfaces
{
    public interface IListingsRepository
    {
        public List<Listing> Get();
        public Listing Get(long id);
        public Listing Get(string property_type);
        public Listing Create(Listing listing);
        public Listing Update(Listing listing);
        public void Delete(Listing listing);
    }
}
