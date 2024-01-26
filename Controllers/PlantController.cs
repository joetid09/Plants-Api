using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Plants_Api;
using Plants_Api.Models;
using System.Drawing;
using System.Xml.Linq;

namespace Plants_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantController : ControllerBase
    {
        PlantDetails[] plantDetails = new PlantDetails[0];
        //{ 
        //    new PlantDetails {
        //        id = 0,
        //        name = "Bozo",
        //        city = "Chicago",
        //        state = "IL",
        //        photo = "./../assets/samplePlants/begoniaPolkaDot.jpg",
        //        availableUnits = 4,
        //        wifi = true,
        //        laundry = true
        //    }
        //};


        private readonly ILogger<PlantController> _logger;

        public PlantController(ILogger<PlantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPlants")]
        public IEnumerable<PlantDetails> Get()
        {
            IEnumerable<PlantDetails> results = plantDetails.OrderBy(plant => plant.name);
            return results;
        }
    }
}
