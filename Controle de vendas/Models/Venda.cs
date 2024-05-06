using System.ComponentModel.DataAnnotations;

namespace Controle_de_vendas.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public string? Acesso { get; set; }

        public string? Produto { get; set; }

        [Display (Name = "ID do funcionário")]
        [Required]
        public string? FuncionarioId { get; set;}

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }

        
    }
}
