using AutoMapper;
using NossoBrasil.Dtos;
using NossoBrasil.Models;

namespace NossoBrasil.Mappings
{
    public class EnderecoProfile:Profile
    {
        public EnderecoProfile()
        {
            CreateMap<EnderecoDTO, EnderecoModel>().ReverseMap();
        }
    }
}
