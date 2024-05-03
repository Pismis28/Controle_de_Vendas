using System.ComponentModel.DataAnnotations;

namespace Controle_de_vendas.Models
{
    //somente o adm consegue cadastrar produtos
    public class Administrador {
        public int AdministradorId { get; set; }

        public string? Acesso { get; set; }

        public string? Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }
    }
}

   
