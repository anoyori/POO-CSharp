using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();        
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer guilherme = new Designer("222.222.222-22");
            guilherme.Nome = "Guilherme";

            Diretor thatiana = new Diretor("333.333.333-33");
            thatiana.Nome = "Thatiana";

            Auxiliar daniel = new Auxiliar("444.444.444-44");
            daniel.Nome = "Daniel";

            GerenteDeConta rafael = new GerenteDeConta("555.555.555.-55");
            rafael.Nome = "Rafael";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(thatiana);
            gerenciadorBonificacao.Registrar(daniel);
            gerenciadorBonificacao.Registrar(rafael);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
