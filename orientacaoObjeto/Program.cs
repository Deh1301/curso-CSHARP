using System;
using System.Collections;
using System.Threading.Tasks;

namespace orientacaoObjeto{
    class OrientarObjeto{
        public static async Task Main(string[] args){
            System.Console.WriteLine("\nBem Vindo ao modulo de orientação a objeto");
            
            System.Console.WriteLine("\n1-Abstração");
            System.Console.WriteLine("\n2-Encapsulamento");
            System.Console.WriteLine("\n3-Interface");
            System.Console.WriteLine("\n4-Herança");
            System.Console.WriteLine("\n5-Polimorfismo");
            System.Console.WriteLine("\n6-Desafio");

            System.Console.Write("\nEscolha o exercicio: ");

            string escolha = Console.ReadLine();
            switch(escolha){
                case "1":
                Abstract.Executar();
                break;

                case "2":
                Seres.executando();
                break;

                case "3":
                Interface.Executar();
                break;

                case "4":
                Heranca.Executar();
                break;

                case "5":
                await new Polimorfismo().Executar();
                break;

                case "6":
                Desafio.Executar();
                break;
        }
    }
  }
}