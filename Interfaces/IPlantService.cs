using Plants_Api.Models;

namespace Plants_Api.Services
{
    public interface IPlantService
    {
        PlantDetails GetUser(string username);
    }
}