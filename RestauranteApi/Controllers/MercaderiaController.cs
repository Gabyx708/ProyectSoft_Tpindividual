﻿using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestauranteApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MercaderiaController : ControllerBase
    {
        private readonly IMercaderiaService _services;

        public MercaderiaController(IMercaderiaService services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult GetAll()
        {   
            var result = _services.GetAll();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _services.GetById(id);
            return new JsonResult(result);
        }
    }
}