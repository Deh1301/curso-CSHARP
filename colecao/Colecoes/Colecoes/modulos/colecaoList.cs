using System;
using System.Collections.Generic;
using System.Text;

namespace Colecao.Modulos
{
    //public class Produto
    //{
    //    public string Nome;
    //    public double Preco;

    //    public Produto(string Nome, double Preco)
    //    {
    //        Nome = nome;
    //        Preco = preco;

    //    }

    //}


    class ColecaoList
    {
        public static void Executar()
        {

            //var livro = new Produto("Avengers", 20.0);
            //var carrinho = new List<Produto>();

            List<string> nomes = new List<string>();
            nomes.Add("André");
            nomes.Add("Julia");
            nomes.Add("Anthony");

            Console.WriteLine("Os nomes sao:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            List<int> numeros = new List<int>();
            System.Console.WriteLine("Adicione 5 numeros: ");
            numeros.Add(int.Parse(Console.ReadLine()));
            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Add(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("\n os numeros adicionados sao : ");



            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);
            }

            System.Console.WriteLine("Qual vc deseja remover: ");
            numeros.Remove(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Agora os numeros sao");
            foreach (int numero in numeros)
            {

                System.Console.WriteLine(numero);
            }





        }

    }



    class ListaFilme
    {
        public string Nome { get; set; }
        public int Valor { get; set; }

        public ListaFilme(string nome, int valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public static void Executar()
        {
            var Livro = new ListaFilme("Marvel", 29);
            var nome = new List<ListaFilme>();
            nome.Add(Livro);
            var combo = new List<ListaFilme>{
                new ListaFilme("Avengers", 20),
                new ListaFilme("Capitao America", 15),
                new ListaFilme("Guerra Infinita",10)


            };
            nome.AddRange(combo);
            System.Console.WriteLine("Os nomes dos filmes sao: ");

            foreach (var nomes in combo)
            {
                System.Console.WriteLine($"{nomes.Nome}, valor: {nomes.Valor}");
            }


            List<string> filmes = new List<string>();

            filmes.Add("Avengers");
            filmes.Add("GUERA");
            System.Console.WriteLine("1- Adicione o Filme:");
            System.Console.WriteLine("2- Remover Filme:");
            System.Console.WriteLine("Voce seleciono: ");
            var escolha = Console.ReadLine();
            


            switch (escolha)
            {
                case "1":

                    filmes.Add(Console.ReadLine());
                    foreach (var filme in filmes)
                    {
                        System.Console.WriteLine($"Agora os filmes sao: {filme}");
                    }


                    break;
                case "2":
                    filmes.Remove(Console.ReadLine());
                    foreach (var filme in filmes)
                    {
                        System.Console.WriteLine($"Agora os filmes sao: {filme}");
                    }

                    break;



            }



        }
    }
}


