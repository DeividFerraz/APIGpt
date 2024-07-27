using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class GptAssistente
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        public GptAssistente(string role, string content)
        {
            Role = role;
            Content = content;
        }
    }
}

