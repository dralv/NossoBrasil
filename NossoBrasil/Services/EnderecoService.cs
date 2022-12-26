using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using NossoBrasil.Dtos;
using NossoBrasil.Interfaces;
using NossoBrasil.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace NossoBrasil.Services
{
    public class EnderecoService : IEnderecoService
    {
        public const string baseUrl = "https://brasilapi.com.br/api/cep/v1";

        private readonly IMapper _mapper;

        public EnderecoService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<EnderecoDTO> EncontrarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/{cep}");

            var response = new EnderecoModel();

            using(var client = new HttpClient())
            {
                var enderecoResponse = await client.SendAsync(request);
                var conteudoResponse = await enderecoResponse.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(conteudoResponse);
                response = objResponse;
            }

            return _mapper.Map<EnderecoDTO>(response);
        }
    }
}
