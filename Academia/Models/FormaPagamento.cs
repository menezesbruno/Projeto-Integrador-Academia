using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class FormaPagamento : BaseEntity
    {
        [Required]
        [StringLength(25)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Clientes")]
        public List<Cliente> Clientes { get; set; } = new();
    }
}
