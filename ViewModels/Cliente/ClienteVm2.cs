using System.ComponentModel.DataAnnotations;

namespace ApiVersioning.ViewModels.Cliente
{
    public class ClienteVm2
    {
        [Required]
        public string? Rg { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? NomeMae { get; set; }
    }
}
