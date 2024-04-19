#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHotel.Models
{
    public class Reserva
    {
        // Propriedades
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        // Construtores

        public Reserva() {  }


        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        // Métodos
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            var result = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                var percent = result * 0.10M;
                result -= percent;
            }
            
            return result;
        }
    }
}