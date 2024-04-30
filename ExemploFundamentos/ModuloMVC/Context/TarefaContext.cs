using Microsoft.EntityFrameworkCore;
using ModuloMVC.Models;

namespace ModuloMVC.Context
{
    public class TarefaContext(DbContextOptions<TarefaContext> options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}