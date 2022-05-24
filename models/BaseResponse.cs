using System.Text.Json.Serialization;

namespace dotnet_blazor_server.models
{
    public class BaseResponse<T>
    {
        public int Page { get; set; }
        public int Total { get; set; }
        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }
        public T Data { get; set; } = default!;
    }
}