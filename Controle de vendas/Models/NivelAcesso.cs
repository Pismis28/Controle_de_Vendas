using System.ComponentModel.DataAnnotations;

namespace Controle_de_vendas.Models
{
    public class NivelAcesso
    {
   
        [Key]
        public int NivelAcessoID { get; set; }

        [Required]
        public string? Acesso { get; set; }


    }
}
