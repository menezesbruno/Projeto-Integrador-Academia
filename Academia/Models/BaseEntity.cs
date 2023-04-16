using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataAdicionado { get; set; } = DateTime.Now;
        public DateTime DataModificado { get; set; } = DateTime.Now;
    }
}
