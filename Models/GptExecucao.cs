using System.Text.Json.Serialization;

namespace ApiGptAssistent.Models
{
    public class GptExecucao
    {
        [JsonPropertyName("assistant_id")]
        public string AssistantId { get; set; }

        public GptExecucao(string assistantId)
        {
            AssistantId = assistantId;
        }
    }
}
