using NossoBrasil.Dtos;

namespace NossoBrasil.Interfaces
{
    public interface IDDDService
    {
        Task<DDDDTO> RetornarInformacoesPorDDD(string ddd);
    }
}
