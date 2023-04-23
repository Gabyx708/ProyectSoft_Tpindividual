using Application.Interfaces;
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
        public IActionResult Get()
        {
            var result = _services.GetAll();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _services.GetById(id);

            if (result == null)
                    return NotFound();

            return new JsonResult(result);
        }

        [HttpPost]
        public IActionResult action()
        {
            return null;
        }
    }
}
