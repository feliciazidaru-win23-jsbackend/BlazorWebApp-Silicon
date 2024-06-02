using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorWebApp.Components.GraphQL;

public class GraphQlResponse
{
    [JsonPropertyName("data")]
    public JsonElement Data { get; set; }
}

