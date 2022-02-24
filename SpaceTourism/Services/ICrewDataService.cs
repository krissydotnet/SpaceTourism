using SpaceTourism.Models;

namespace SpaceTourism.Services
{
    public interface ICrewDataService
    {
        Task<IEnumerable<Member>> GetAll();

        Task<Member> GetById(int id);
    }
}
