using ApiVersioning.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            //clienteService.Excluir(codigo);

            return NoContent();
        }

        [HttpPost]
        public IActionResult Post(ClienteVm cliente)
        {
            //clienteService.Inserir(cliente);

            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
