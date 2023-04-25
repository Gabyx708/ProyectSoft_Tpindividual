using Application.Interfaces;
using Application.Models.Comanda;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestauranteApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _services;

        public ComandaController(IComandaService services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult GetByFecha(string fecha)
        {  
            var result = _services.GetByDate(fecha);

            if (result == null)
                return BadRequest(new {message = "operacion invalida"});

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _services.GetById(id);
            return new JsonResult(result);
        }

        [HttpPost]
        public IActionResult CreateComanda(ComandaRequest request)
        {
            var result = _services.CreateComanda(request);
            return new JsonResult(result);
        }
    }
}
