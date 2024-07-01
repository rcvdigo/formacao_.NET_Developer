using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool IsPar(int num1)
        {
            int resultado = num1 % 2;
            if (resultado == 0)
            {
                return true;
            }
            return false;
        }
    }
}