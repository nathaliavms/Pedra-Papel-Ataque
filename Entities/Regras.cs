using System;

namespace JogoInfantil.Entities
{
    class Regras
    {
        public int Teste { get; set; }
        public string Resultado { get; set; }
        
        public Regras(int teste)
        {
            Teste = teste;
        }
        public void ImprimirGanhador()
        {
            string[] Jogador1 = new string[Teste];
            string[] Jogador2 = new string[Teste];

            for (int i = 0; i < Teste; i++)
            {
                Console.WriteLine("Escolha um sinal ao jogador 1 (ataque, pedra ou papel: )");
                Jogador1[i] = Console.ReadLine();
                Console.WriteLine("Escolha um sinal ao jogador 2 (ataque, pedra ou papel: )");
                Jogador2[i] = Console.ReadLine();
                
                if (Jogador1[i] == "ataque" && Jogador2[i] == "ataque")
                {
                    Console.WriteLine("Aniquilacao mutua");
                }
                else if (Jogador1[i] == "papel" && Jogador2[i] == "papel")
                {
                    Console.WriteLine("Ambos venceram");
                }
                else if (Jogador1[i] == "pedra" && Jogador2[i] == "pedra")
                {
                    Console.WriteLine("Sem ganhador");
                }
                else if (Jogador1[i] == "ataque" && Jogador2[i] == "papel"
                    || Jogador1[i] == "pedra" && Jogador2[i] == "papel"
                    || Jogador1[i] == "ataque" && Jogador2[i] == "pedra")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (Jogador1[i] == "papel" && Jogador2[i] == "ataque"
                    || Jogador1[i] == "papel" && Jogador2[i] == "pedra"
                    || Jogador1[i] == "pedra" && Jogador2[i] == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else
                {
                    Console.WriteLine("sinal digitado é invalido"); 
                } 
            }
        }  
    }
}
