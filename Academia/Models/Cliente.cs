using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Cliente : BaseEntity
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

        public Guid PersonalId { get; set; }
        public Guid FormaPagamentoId { get; set; }

        [DisplayName("Forma de Pagamento")]
        public FormaPagamento FormaPagamento { get; set;}

        [DisplayName("Personal Trainer")]
        public Personal Personal { get; set; }
    }
}
