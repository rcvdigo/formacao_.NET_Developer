using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Vendas(int id, string produto, decimal preco)
    {
        public int Id { get; set; } = id;
        public string Produto { get; set; } = produto;
        public decimal Preco { get; set; } = preco;
    }
}