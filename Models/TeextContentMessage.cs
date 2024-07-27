using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class TeextContent
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("annotations")]
        public List<object> ?Annotations { get; set; }
    }
}
