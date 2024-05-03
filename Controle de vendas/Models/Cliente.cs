using System.ComponentModel.DataAnnotations;

namespace Controle_de_vendas.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        public string? Acesso { get; set; }

        public string? Nome { get; set; }

        public string? Sobrenome { get; set; }

        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Ex: exemplo@email.com")]
        public string? Email { get; set; }

        [StringLength(11, MinimumLength = 10, ErrorMessage = "Digite o DDD + telefone")]
        public string? Telefone { get; set; }

    }
}
