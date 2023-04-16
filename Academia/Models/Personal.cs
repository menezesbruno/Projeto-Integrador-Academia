using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Personal : BaseEntity
    {
        [Required]
        [StringLength(25)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(75)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; }

        public List<Cliente> Clientes { get; set; } = new();
    }
}
