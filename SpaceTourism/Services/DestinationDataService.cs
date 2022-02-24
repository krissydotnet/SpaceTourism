using SpaceTourism.Models;
using System.Net.Http.Json;

namespace SpaceTourism.Services
{
    public class DestinationDataService : IDestinationDataService
    {
        private readonly HttpClient _httpClient;

        public DestinationDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SpaceDestination>> GetAll()
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/destination.json?{randomid}";
            return await _httpClient.GetFromJsonAsync<IEnumerable<SpaceDestination>>(url_get);
        }

        public async Task<SpaceDestination> GetById(int id)
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/destination.json?{randomid}";
            var crew = await _httpClient.GetFromJsonAsync<IEnumerable<SpaceDestination>>(url_get);
            return crew.Where(x => x.Index == id).FirstOrDefault();
        }
    }
}
