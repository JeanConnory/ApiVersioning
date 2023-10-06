using ApiVersioning.ViewModels.Cliente;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiVersioning.Controllers.Cliente.V1
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")] //Usa o version se quiser
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ClienteVm cliente)
        {
            //clienteService.Inserir(cliente);

            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
