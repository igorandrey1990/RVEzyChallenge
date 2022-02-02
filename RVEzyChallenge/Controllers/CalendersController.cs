using Microsoft.AspNetCore.Mvc;
using RVEzyChallenge.Helpers;
using RVEzyChallenge.Models;
using System.Collections.Generic;

namespace RVEzyChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendersController : ControllerBase
    {
        [HttpGet]
        public Calender GetByID(long id)
        {
            // TODO
            return null;
        }

        [HttpGet]
        public IEnumerable<Calender> Get([FromQuery] ListingParameters listingParameters)
        {
            // TODO
            return null;
        }

        [HttpPost]
        public Calender Create()
        {
            // TODO
            return null;
        }

        [HttpPut]
        public Calender Update()
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
