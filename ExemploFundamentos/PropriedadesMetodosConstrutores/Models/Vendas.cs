using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Vendas(int id, string produto, decimal preco, DateTime dataVenda, decimal? desconto)
    {
        public int Id { get; set; } = id;
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; } = produto;
        public decimal Preco { get; set; } = preco;
        public DateTime DataVenda { get; set; } = dataVenda;
        public decimal? Desconto { get; set; } = desconto;
    }
}