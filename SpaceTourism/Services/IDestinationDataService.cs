using SpaceTourism.Models;

namespace SpaceTourism.Services
{
    public interface IDestinationDataService
    {
        Task<IEnumerable<SpaceDestination>> GetAll();
        Task<SpaceDestination> GetById(int id);
    }
}