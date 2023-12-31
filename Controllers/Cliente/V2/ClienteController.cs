﻿using ApiVersioning.ViewModels.Cliente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiVersioning.Controllers.Cliente.V2
{
    [ApiVersion("2.0")]
    [ApiVersion("2.1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            //clienteService.Excluir(codigo);

            return NoContent();
        }

        [MapToApiVersion("2.0")]
        [HttpPost]
        public IActionResult Post(ClienteVm2 cliente)
        {
            //clienteService.Inserir(cliente);

            return StatusCode((int)HttpStatusCode.Created);
        }

        [MapToApiVersion("2.1")]
        [HttpPost]
        public IActionResult PostV21(ClienteVm2 cliente)
        {
            //clienteService.Inserir(cliente);

            return Ok("Post v2.1");
        }
    }
}
