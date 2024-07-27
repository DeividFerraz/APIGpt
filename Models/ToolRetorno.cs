using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class Tool
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
