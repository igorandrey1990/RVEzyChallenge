using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RVEzyChallenge.Helpers;
using RVEzyChallenge.Models;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace RVEzyChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        [HttpGet]
        public Review GetByID(long id)
        {
            // TODO
            return null;
        }

        [HttpGet]
        public IEnumerable<Review> Get([FromQuery] ListingParameters listingParameters)
        {
            // TODO
            return null;
        }

        [HttpPost]
        public Listing Create()
        {
            // TODO
            return null;
        }

        [HttpPut]
        public Listing Update()
        {
            // TODO
            return null;
        }

        [HttpDelete]
        public void Delete()
        {
            // TODO
        }
    }
}
