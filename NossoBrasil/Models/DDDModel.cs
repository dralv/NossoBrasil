using System.Text.Json.Serialization;

namespace NossoBrasil.Models
{
    public class DDDModel
    {
        [JsonPropertyName("state")]
        public string Estado { get; set; }

        [JsonPropertyName("cities")]
        public List<string> Cidades { get; set; }
    }
}
