using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class PerguntaRequest
    {
        [JsonPropertyName("pergunta")]
        public string Pergunta { get; set; }
    }
}
