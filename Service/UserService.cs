using System.Text.Json;
using dotnet_blazor_server.models;

namespace dotnet_blazor_server.Service
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public UserService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<BaseResponse<IList<UserResponse>>?> GetUsers(int page)
        {
            var url = "https://reqres.in/api/users?page=" + page;

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<BaseResponse<IList<UserResponse>>>();
            return result;
        }
    }
}