using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Safari_Online.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase {
        private SafariVacationContext db { get; set; }

        public AnimalController () {
            this.db = new SafariVacationContext ();
        }
        // Shows all Animals in Database
        [HttpGet]
        public ActionResult<IEnumerable<SeenAnimal>> Get () {
            return this.db.SeenAnimals;
        }
        // Adds an Animal with based on Species to Database
        [HttpPost]
        public SeenAnimal Post ([FromBody] SeenAnimal species) {

            this.db.SeenAnimals.Add (species);

            this.db.SaveChanges ();

            return species;
        }
        // Shows all Animals based on Location
        [HttpGet ("{location}")]
        public IEnumerable<SeenAnimal> Get (string location) {
            var located = this.db.SeenAnimals.Where (animal => animal.Location.ToLower () == location.ToLower ());
            return located;
        }
        // Add One to the number of times you have seen an Animal
        [HttpPut ("{species}")]
        public SeenAnimal Put(string species) {
            var updated = this.db.SeenAnimals.FirstOrDefault(animal => animal.Species.ToLower() == species.ToLower());
            updated.CountOfTimesSeen = updated.CountOfTimesSeen + 1;
            this.db.SaveChanges();
            return updated;
        }
        // Delete an animal from the database by species
        [HttpDelete ("{species}")]
        public SeenAnimal Delete(string species) {
            var deleted = this.db.SeenAnimals.FirstOrDefault(animal => animal.Species.ToLower() == species.ToLower());
            this.db.Remove(deleted);
            this.db.SaveChanges();
            return deleted;
       }

    }
}