using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Calculadora
    {
        private int soma;
        private int subtrair;
        private int multiplicar;
        private int dividir;
        private double potencia;
        private double seno;
        private double coseno;
        private double tangente;
        private double raiz;

        public void Somar(int x, int y)
        {
            soma = x + y;
            Console.WriteLine($"{x} + {y} = {soma}");
        }

        public void Subtrair(int x, int y)
        {
            subtrair = x - y;
            Console.WriteLine($"{x} - {y} = {subtrair}");
        }

        public void Multiplicar(int x, int y)
        {
            multiplicar = x * y;
            Console.WriteLine($"{x} * {y} = {multiplicar}");
        }

        public void Dividir(int x, int y)
        {
            dividir = x / y;
            Console.WriteLine($"{x} / {y} = {dividir}");
        }
        public void Potencia(double x, double y)
        {
            potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ** {y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}� = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}� = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            tangente = Math.Cos(radiano);
            Console.WriteLine($"Tangente de {angulo}� = {Math.Round(tangente, 4)}");
        }

        public void Raiz(double x)
        {
            raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} � = {Math.Round(raiz, 4)}");
        }
    }
}