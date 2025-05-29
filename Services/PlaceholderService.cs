using System.Net.Http;
using System.Threading.Tasks;

namespace TesteBackend.ExternalApi.Services
{
    public class PlaceholderService
    {
        private readonly HttpClient _httpClient;

        public PlaceholderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetExternalUsersAsync()
        {
            var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
