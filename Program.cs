using JogoInfantil.Entities;
using System;

namespace JogoInfantil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos testes vai querer fazer?");
            var teste = 0;
            try
            {
                teste = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro, digite um numero inteiro");
            }
            Regras regras = new Regras(teste);
            regras.ImprimirGanhador();
        }
    }
}
