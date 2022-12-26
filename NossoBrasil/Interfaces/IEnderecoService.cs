using NossoBrasil.Dtos;

namespace NossoBrasil.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDTO> EncontrarEnderecoPorCep(string cep);
    }
}
