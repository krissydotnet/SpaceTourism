using SpaceTourism.Models;

namespace SpaceTourism.Services
{
    public interface ITerminologyDataService
    {
        Task<IEnumerable<Terminology>> GetAll();
        Task<Terminology> GetById(int id);
    }
}