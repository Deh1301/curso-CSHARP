using System;
using System.Threading.Tasks;
using Colecao.Modulos;
using Colecoes.modulos;


namespace Colecao
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Modulo de Coleções!\n\n");

            Console.WriteLine("Escolha seu exercicio:");
            Console.WriteLine("1- Arrays;");
            Console.WriteLine("2- Coleções de Listas;");
            Console.WriteLine("3- Matriz");
            Console.WriteLine("\n");
            Console.Write("O exercicio é o numero : ");
            
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    // ArrayModule.Executar();
                    // Exercicio.Executar();
                    // ExercicioArray.Executar();
                    await Task.Delay(2000);
                    break;
                case "2":
                    // ColecaoList.Executar();
                    // ListaFilme.Executar();
                    // ColecaoArrayList.Executar();
                    // Set.Executar();
                    // ColecoesQueueFila.Executar();
                    // Desafio.Executar();
                    // Equalidade.Executar();
                    // ColecaoStack.Executar();
                    ColecaoDictionary.Executar();


                    await Task.Delay(2000);
                    break;
                case "3":
                    Matriz.Executar();
                    await Task.Delay(2000);

                    break;    

            }
        }
    }
}
