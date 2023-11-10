using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Treino : BaseEntity
    {
        internal object FormaPagamento;
        internal object Personal;

        [Required]
        [StringLength(10)]
        [DisplayName("Matrícula")]
        public string Matricula { get; set; }

        [Required]
        [StringLength(25)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Segunda")]
        public string Segunda { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Terca")]
        public string Terca { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Quarta")]
        public string Quarta { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Quinta")]
        public string Quinta { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Sexta")]
        public string Sexta { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Sabado")]
        public string Sabado { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Domingo")]
        public string Domingo { get; set; }

        [Required]
        [StringLength(6)]
        [DisplayName("Altura")]
        public string Altura { get; set; }

        [Required]
        [StringLength(6)]
        [DisplayName("Peso")]
        public string Peso { get; set; }

        [Required]
        [StringLength(6)]
        [DisplayName("IMC")]
        public string IMC { get; set; }
    }
}
