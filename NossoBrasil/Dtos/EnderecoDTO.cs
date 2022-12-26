using System.Text.Json.Serialization;

namespace NossoBrasil.Dtos
{
    public class EnderecoDTO
    {
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        [JsonIgnore]
        public string Servico { get; set; }

    }
}
