using System.ComponentModel.DataAnnotations;

namespace Controle_de_vendas.Models
{
    public class Vendedor
    {
        public int VendedorID { get; set; }

        public string? Acesso { get; set; }

        [Display(Name= "Nome")]
        [Required]
        public string? VendedorName { get; set; }

        [Display(Name ="Sobrenome")]
        public string? VendedorSobrenome { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Digite 11 números!")]
        [Required]
        public string? CPF { get; set; }

        [StringLength(11, MinimumLength =10, ErrorMessage ="Digite o DDD + telefone")]
        public string? Telefone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Ex: exemplo@email.com")]
        public string? Email { get; set; }




    }
}
