using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaAbstraindoCelular.Models
{
    public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
    {
        public string Numero { get; set; } = numero;
        private string Modelo { get; set; } = modelo;
        private string IMEI { get; set; } = imei;
        private int Memoria { get; set; } = memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}