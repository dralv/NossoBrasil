using AutoMapper;
using NossoBrasil.Dtos;
using NossoBrasil.Interfaces;
using NossoBrasil.Models;
using System.Text.Json;

namespace NossoBrasil.Services
{
    public class DDDService : IDDDService
    {
        private readonly IMapper _mapper;
        public const string baseUrl = "https://brasilapi.com.br/api/ddd/v1";

        public DDDService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<DDDDTO> RetornarInformacoesPorDDD(string ddd)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/{ddd}");

            var response = new DDDModel();

            using(var client = new HttpClient())
            {
                var dddResponse = await client.SendAsync(request);
                var contentResponse = await dddResponse.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<DDDModel>(contentResponse);
                response = objResponse;
            }

            return _mapper.Map<DDDDTO>(response);
        }
    }
}
