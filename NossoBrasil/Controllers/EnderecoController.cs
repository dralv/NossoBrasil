using Microsoft.AspNetCore.Mvc;
using NossoBrasil.Interfaces;

namespace NossoBrasil.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
           _enderecoService = enderecoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Pesquisar(string cep)
        {
            if(cep == null) return BadRequest("Cep Inválido");
            var enderecoDto = await _enderecoService.EncontrarEnderecoPorCep(cep);
            return View(enderecoDto);
        }
    }
}
