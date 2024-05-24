using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorWebApp.Components.GraphQL;

public class GraphQlResponse
{
}
public class DynamicGraphQLResponse
{
    [JsonPropertyName("data")]
    public JsonElement Data { get; set; }
}
