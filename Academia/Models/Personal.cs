using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Personal : BaseEntity
    {
        [Required]
        [StringLength(25)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(75)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Clientes")]
        public List<Cliente> Clientes { get; set; } = new();
    }
}
