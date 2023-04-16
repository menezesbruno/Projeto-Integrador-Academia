using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Cliente : BaseEntity
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

        public Guid PersonalId { get; set; }
        public Guid FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set;}
        public Personal Personal { get; set; }
    }
}
