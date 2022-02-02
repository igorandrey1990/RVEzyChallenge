using RVEzyChallenge.DAL;
using RVEzyChallenge.Models;
using RVEzyChallenge.Repository.Interfaces;
using System.Collections.Generic;

namespace RVEzyChallenge.Repository
{
    public class ListingsRepository : IListingsRepository
    {
        private readonly RVEzyContext _RVEzyContext;

        public ListingsRepository(RVEzyContext RVEzyContext)
        {
            _RVEzyContext = RVEzyContext;
        }

        public Listing Create(Listing listing)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Listing listing)
        {
            throw new System.NotImplementedException();
        }

        public List<Listing> Get()
        {
            throw new System.NotImplementedException();
        }

        public Listing Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public Listing Get(string property_type)
        {
            throw new System.NotImplementedException();
        }

        public Listing Update(Listing listing)
        {
            throw new System.NotImplementedException();
        }
    }
}
