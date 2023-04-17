using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; } = true;

        [DisplayName("Data de Adição")]
        public DateTime DataAdicionado { get; set; } = DateTime.Now;

        [DisplayName("Data de Modificação")]
        public DateTime DataModificado { get; set; } = DateTime.Now;
    }
}
