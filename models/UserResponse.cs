using System.Text.Json.Serialization;

namespace dotnet_blazor_server.models
{
    public class UserResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = default!;

        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = default!;

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = default!;
    }
}