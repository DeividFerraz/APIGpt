using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class TruncationStrategyRetorno
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("last_messages")]
        public string LastMessages { get; set; }
    }
}
