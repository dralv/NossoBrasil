using Microsoft.AspNetCore.Mvc;
using NossoBrasil.Interfaces;

namespace NossoBrasil.Controllers
{
    public class DDDController : Controller
    {
        private readonly IDDDService _dddService;

        public DDDController(IDDDService dddService)
        {
            _dddService = dddService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Pesquisar(string ddd)
        {
            if (ddd == null) return BadRequest("DDD inválido");
            var dddDto = await _dddService.RetornarInformacoesPorDDD(ddd);
            return View(dddDto);    
        }
    }
}
