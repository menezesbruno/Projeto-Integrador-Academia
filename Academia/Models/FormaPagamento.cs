using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class FormaPagamento : BaseEntity
    {
        [Required]
        [StringLength(25)]
        public string Nome { get; set; }

        public List<Cliente> Clientes { get; set; } = new();
    }
}
