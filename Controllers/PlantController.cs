using Microsoft.AspNetCore.Mvc;
using Plants_Api;
using System.Drawing;
using System.Xml.Linq;

namespace Plants_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantController : ControllerBase
    {
        PlantDetails[] plantDetails = new PlantDetails[] 
        { 
            new PlantDetails {
                id = 0,
                name = "Bozo",
                city = "Chicago",
                state = "IL",
                photo = "./../assets/samplePlants/begoniaPolkaDot.jpg",
                availableUnits = 4,
                wifi = true,
                laundry = true
            },
            new PlantDetails {
                id = 1,
                name = "Mr. Swan",
                city = "Santa MonicaChicago",
                state = "CA",
                photo = "./../assets/samplePlants/birdsOfParadise.jpg",
                availableUnits = 0,
                wifi = false,
                laundry = true
            },
            new PlantDetails {
                id = 2,
                name = "Johnny",
                city = "Juneau",
                state = "AK",
                photo = "./../assets/samplePlants/fiddleLeafFig.jpeg",
                availableUnits = 1,
                wifi = false,
                laundry = false
            },
             new PlantDetails {
                id = 3,
                name = "St. Chill",
                city = "Chicago",
                state = "IL",
                photo = "./../assets/samplePlants/norfolkIslandPine.jpg",
                availableUnits = 1,
                wifi = true,
                laundry = false
            },
             new PlantDetails {
                id = 4,
                name = "Willy",
                city = "Gary",
                state = "IN",
                photo = "./../assets/samplePlants/redPineapple.jpg",
                availableUnits = 1,
                wifi = true,
                laundry = false
            }
        };


        private readonly ILogger<PlantController> _logger;

        public PlantController(ILogger<PlantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPlants")]
        public IEnumerable<PlantDetails> Get()
        {
            return plantDetails;
        }
    }
}
