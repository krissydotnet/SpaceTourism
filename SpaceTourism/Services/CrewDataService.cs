using SpaceTourism.Models;
using System.Net.Http.Json;

namespace SpaceTourism.Services
{
    public class CrewDataService : ICrewDataService
    {
        private readonly HttpClient _httpClient;

        public CrewDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Member>> GetAll()
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/crew.json?{randomid}";
            return await _httpClient.GetFromJsonAsync<IEnumerable<Member>>(url_get);
        }

        public async Task<Member> GetById(int id)
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/crew.json?{randomid}";
            var crew = await _httpClient.GetFromJsonAsync<IEnumerable<Member>>(url_get);
            return crew.Where(x => x.Index == id).FirstOrDefault();
        }
    }
}
