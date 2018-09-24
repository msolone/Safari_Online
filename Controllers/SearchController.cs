using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Safari_Online.Controllers {
    [Route ("api/search")]
    [ApiController]
    public class SearchController : ControllerBase {
        private SafariVacationContext db { get; set; }

        public SearchController () {
            this.db = new SafariVacationContext ();
        }

        // Shows all Animals that contain a specific species name
        [HttpGet]
        public ActionResult<SeenAnimal> Get ([FromQuery] string species)
        {
            var searched = this.db.SeenAnimals.FirstOrDefault(animal => animal.Species.ToLower() == species.ToLower());
            return searched; 
        }
    }

}