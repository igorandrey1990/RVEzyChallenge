using Microsoft.AspNetCore.Mvc;
using RVEzyChallenge.Helpers;
using RVEzyChallenge.Models;
using RVEzyChallenge.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace RVEzyChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingsRepository _listingsRepository;

        public ListingsController()
        {

        }

        public ListingsController(IListingsRepository listingsRepository)
        {
            _listingsRepository = listingsRepository;
        }

        [HttpGet]
        public Listing GetByID(long id)
        {
            return ParseCSV.GetByID(id);
        }

        [HttpGet]
        public IEnumerable<Listing> Get([FromQuery] ListingParameters listingParameters)
        {
            List<Listing> listings = ParseCSV.Get(listingParameters);

            return listings;
        }

        [HttpGet]
        public IEnumerable<Listing> Get([FromQuery] ListingParameters listingParameters, string property_type)
        {
            List<Listing> listings = ParseCSV.Get(listingParameters, property_type);

            return listings;
        }

        [HttpPost]
        public Listing Create(Listing listing)
        {
            try
            {
                return _listingsRepository.Create(listing);
            } catch (Exception ex)
            {
                // Treat Exception
                return null;
            }
        }

        [HttpPut]
        public Listing Update(Listing listing)
        {
            try
            {
                return _listingsRepository.Update(listing);
            }
            catch (Exception ex)
            {
                // Treat Exception
                return null;
            }
        }

        [HttpDelete]
        public void Delete(Listing listing)
        {
            try
            {
                _listingsRepository.Delete(listing);
            }
            catch (Exception ex)
            {
                // Treat Exception
            }
        }
    }
}
