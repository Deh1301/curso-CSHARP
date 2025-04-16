using System.Collections;
using System.Collections.Generic;

namespace Colecoes.modulos
{


    class Desafio
    {
        public static void Executar()
        {
            System.Console.WriteLine("Bem vindo ao Sistema de gerenciamento");

            var adicionar = new Queue<string>();
            var dadosLista = new HashSet<string>();

            while (true)
            {
                System.Console.WriteLine("Digite nome para entrar na fila:");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                {
                    break;

                }

                if (!dadosLista.Contains(entrada))
                {
                    adicionar.Enqueue(entrada);
                    dadosLista.Add(entrada);
                    System.Console.WriteLine($"Adicionando {entrada}");
                    
                }
                else
                {
                    System.Console.WriteLine($"Nome ja adiconado {entrada}");
                    

                }
                if(!entrada.Equals(dadosLista)){
                    List<string> nome = new List<string>();
                    
                    foreach(var nomes in nome){
                        System.Console.WriteLine(nomes);
                    }
                }
                

            }




        }
    }
}