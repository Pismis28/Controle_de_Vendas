using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Controle_de_vendas.Models;

namespace Controle_de_vendas.Data
{
    public class Controle_de_vendasContext : DbContext
    {
        public Controle_de_vendasContext (DbContextOptions<Controle_de_vendasContext> options)
            : base(options)
        {
        }

        public DbSet<Controle_de_vendas.Models.Administrador> Administrador { get; set; } = default!;
        public DbSet<Controle_de_vendas.Models.Venda> Venda { get; set; } = default!;
        public DbSet<Controle_de_vendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Controle_de_vendas.Models.Vendedor> Vendedor { get; set; } = default!;
    }
}
