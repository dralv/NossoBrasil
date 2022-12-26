using AutoMapper;
using NossoBrasil.Dtos;
using NossoBrasil.Models;

namespace NossoBrasil.Mappings
{
    public class DDDProfile:Profile
    {
        public DDDProfile()
        {
            CreateMap<DDDModel,DDDDTO>().ReverseMap();
        }
    }
}
