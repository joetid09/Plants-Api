using Plants_Api.Contexts;
using Plants_Api.Models;

namespace Plants_Api.Services
{
    public class PlantService : IPlantService
    {

        public PlantService() { }

        //PlantsContext db = new PlantsContext();
        public PlantDetails GetUser(string username)
        {
            PlantDetails plantDetails = new PlantDetails();
            //plantDetails = db.PlantDetails.Find(1);
            //user.First_Name = "Joseph";
            //user.Last_Name = "Tidwell";
            //User user = db.User
            return plantDetails;
        }
    }
}
