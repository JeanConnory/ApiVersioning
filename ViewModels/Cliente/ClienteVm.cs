using System.ComponentModel.DataAnnotations;

namespace ApiVersioning.ViewModels.Cliente
{
    public class ClienteVm
    {
        [Required]
        public string? Rg { get; set; }

        [Required]
        public string? Nome { get; set; }
    }
}
