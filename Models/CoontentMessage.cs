using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class CoontentMessage
    {
        [JsonPropertyName("type")]
        public string ?Type { get; set; }

        [JsonPropertyName("text")]
        public TextContent ?Text { get; set; }
    }
}
