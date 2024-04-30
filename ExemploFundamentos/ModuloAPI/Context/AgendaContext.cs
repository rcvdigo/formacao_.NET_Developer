using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        // Configuração do Banco de Dados que passa para a classe Pai DbContext
        public AgendaContext(
            DbContextOptions<AgendaContext> options
        ) : base(options)
        {
            
        }

        // Representação da tabela no banco e a classe no C#
        public DbSet<Contato> Contatos { get; set; }
    }
}