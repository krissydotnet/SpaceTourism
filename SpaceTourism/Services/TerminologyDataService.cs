using SpaceTourism.Models;
using System.Net.Http.Json;

namespace SpaceTourism.Services
{
    public class TerminologyDataService : ITerminologyDataService
    {
        private readonly HttpClient _httpClient;

        public TerminologyDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Terminology>> GetAll()
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/tech.json?{randomid}";
            return await _httpClient.GetFromJsonAsync<IEnumerable<Terminology>>(url_get);
        }

        public async Task<Terminology> GetById(int id)
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/tech.json?{randomid}";
            var crew = await _httpClient.GetFromJsonAsync<IEnumerable<Terminology>>(url_get);
            return crew.Where(x => x.Index == id).FirstOrDefault();
        }
    }
}
