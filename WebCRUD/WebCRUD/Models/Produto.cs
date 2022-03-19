using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUD.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("produto_nome")]
        [Display(Name = "nome")]
        public string? produto_nome { get; set; }
        [Column("valor")]
        [Display(Name = "Valor")]
        public decimal valor { get; set; }
        [Column("data_vencimento")]
        [Display(Name = "Validade")]
        public DateTime data_vencimento { get; set; }
    }
}

